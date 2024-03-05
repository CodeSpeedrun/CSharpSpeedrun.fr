Eager Loading with Split Queries

When a LINQ query contains a lot of includes, there can be a negative performance impact. To resolve this
situation, EF Core 5 introduced split queries. Instead of executing a single query, EF Core will split the LINQ
query into multiple SQL queries and then wire up all of the related data. For example, the previous query can
be expected as multiple SQL queries by adding AsSplitQuery() into the LINQ query, like this:
var query = Context.Makes.AsSplitQuery()
.Include(x => x.Cars.Where(x=>x.Color == "Yellow")).ToList();
The queries that are executed are shown here:
SELECT [m].[Id], [m].[Name], [m].[TimeStamp]
FROM [dbo].[Makes] AS [m]
ORDER BY [m].[Id]
SELECT [t].[Id], [t].[Color], [t].[MakeId], [t].[PetName], [t].[TimeStamp], [m].[Id]
FROM [dbo].[Makes] AS [m]
INNER JOIN (
SELECT [i].[Id], [i].[Color], [i].[MakeId], [i].[PetName], [i].[TimeStamp]
FROM [Dbo].[Inventory] AS [i]
WHERE [i].[Color] = N'Yellow'
) AS [t] ON [m].[Id] = [t].[MakeId]
ORDER BY [m].[Id]
There is a downside to using split queries: if the data changes between executing the queries, then the
data returned will be inconsistent.


