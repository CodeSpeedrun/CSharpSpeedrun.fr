Global Query Filters on Navigation Properties

Global query filters can also be set on navigation properties. Suppose you want to filter out any orders that
contain a Car that is not drivable.


modelBuilder.Entity<Order>().HasQueryFilter(e => e.CarNavigation.IsDrivable);
When executing a standard LINQ query, any orders that contain a nondrivable car will be excluded
from the result. Here is the LINQ statement and the generated SQL statement:
//C# Code
var orders = Context.Orders.ToList();
/* Generated SQL query */
SELECT [o].[Id], [o].[CarId], [o].[CustomerId], [o].[TimeStamp]
FROM [Dbo].[Orders] AS [o]
INNER JOIN (SELECT [i].[Id], [i].[IsDrivable]
FROM [Dbo].[Inventory] AS [i]
WHERE [i].[IsDrivable] = CAST(1 AS bit)) AS [t]
ON [o].[CarId] = [t].[Id]
WHERE [t].[IsDrivable] = CAST(1 AS bit)
To remove the query filter, use IgnoreQueryFilters(). The following is the updated LINQ statements
and the subsequent generated SQL:
//C# Code
var orders = Context.Orders.IgnoreQueryFilters().ToList();
/* Generated SQL query */
SELECT [o].[Id], [o].[CarId], [o].[CustomerId], [o].[TimeStamp]
FROM [Dbo].[Orders] AS [o]


