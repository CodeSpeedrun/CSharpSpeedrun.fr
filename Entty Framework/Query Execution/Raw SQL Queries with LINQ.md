Raw SQL Queries with LINQ


ometimes getting the correct LINQ statement for a complicated query can be harder than just writing
the SQL directly. Fortunately, EF Core has a mechanism to allow raw SQL statements to be executed on a
DbSet<T>. The FromSqlRaw() and FromSqlRawInterpolated() methods take in a string that becomes the
base of the LINQ query. This query is executed on the server side.

Presuming the global query filter is set on the Car entity, the following LINQ statement will get the first
inventory record where the Id is one, include the related Make data, and filter out nondrivable cars:
var car = Context.Cars
.FromSqlInterpolated($"Select * from dbo.Inventory where Id = {carId}")
.Include(x => x.MakeNavigation)
.First();
The LINQ to SQL translation engine combines the raw SQL statement with the rest of the LINQ
statements and executes the following query:
SELECT TOP(1) [c].[Id], [c].[Color], [c].[IsDrivable], [c].[MakeId],
[c].[PetName], [c].[TimeStamp],
[m].[Id], [m].[Name], [m].[TimeStamp]
FROM (Select * from dbo.Inventory where Id = 1) AS [c]
INNER JOIN [dbo].[Makes] AS [m] ON [c].[MakeId] = [m].[Id]
WHERE [c].[IsDrivable] = CAST(1 AS bit)


