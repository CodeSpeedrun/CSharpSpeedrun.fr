Batching of Statements

EF Core has significantly improved the performance when saving changes to the database by executing
the statements in one or more batches.

var cars = new List<Car>
{
new Car { Color = "Yellow", MakeId = 1, PetName = "Herbie" },
new Car { Color = "White", MakeId = 2, PetName = "Mach 5" },
new Car { Color = "Pink", MakeId = 3, PetName = "Avon" },
new Car { Color = "Blue", MakeId = 4, PetName = "Blueberry" },
};
Context.Cars.AddRange(cars);
Context.SaveChanges();
EF Core would batch up the statements into a single call. The query generated is shown here:
exec sp_executesql N'SET NOCOUNT ON;
DECLARE @inserted0 TABLE ([Id] int, [_Position] [int]);
MERGE [Dbo].[Inventory] USING (
VALUES (@p0, @p1, @p2, 0),
(@p3, @p4, @p5, 1),
(@p6, @p7, @p8, 2),
(@p9, @p10, @p11, 3)) AS i ([Color], [MakeId], [PetName], _Position) ON 1=0
WHEN NOT MATCHED THEN
INSERT ([Color], [MakeId], [PetName])
VALUES (i.[Color], i.[MakeId], i.[PetName])
OUTPUT INSERTED.[Id], i._Position
INTO @inserted0;
SELECT [t].[Id], [t].[IsDrivable], [t].[TimeStamp] FROM [Dbo].[Inventory] t
INNER JOIN @inserted0 i ON ([t].[Id] = [i].[Id])
ORDER BY [i].[_Position];


',N'@p0 nvarchar(50),@p1 int,@p2 nvarchar(50),@p3 nvarchar(50),@p4 int,@p5 nvarchar(50),@
p6 nvarchar(50),@p7 int,@p8 nvarchar(50),@p9 nvarchar(50),@p10 int,@p11 nvarchar(50)',@
p0=N'Yellow',@p1=1,@p2=N'Herbie',@p3=N'White',@p4=2,@p5=N'Mach 5',@p6=N'Pink',@p7=3,@
p8=N'Avon',@p9=N'Blue',@p10=4,@p11=N'Blueberry'