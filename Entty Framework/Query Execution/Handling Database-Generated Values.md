Handling Database-Generated Values

var car = new Car
{
Color = "Yellow",
MakeId = 1,
PetName = "Herbie"
};
Context.Cars.Add(car);
Context.SaveChanges();
When SaveChanges is executed, the new record is inserted into the table, and then the Id and Timestamp
values are returned from the table to EF Core, where the entity’s properties are updated accordingly.
INSERT INTO [Dbo].[Inventory] ([Color], [MakeId], [PetName])
VALUES (N'Yellow', 1, N'Herbie');
SELECT [Id], [TimeStamp]
FROM [Dbo].[Inventory]
WHERE @@ROWCOUNT = 1 AND [Id] = scope_identity();


