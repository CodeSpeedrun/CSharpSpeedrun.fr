Eager Loading

Eager loading is the term for loading related records from multiple tables in one database call. This is
analogous to creating a query in T-SQL linking two or more tables with joins.

For example, to load all the Car records with their related Make information, execute the following LINQ
query:
var queryable = Context.Cars.IgnoreQueryFilters().Include(c => c.MakeNavigation).ToList();
The previous LINQ executes the following query against the database:
SELECT [i].[Id], [i].[Color], [i].[MakeId], [i].[PetName], [i].[TimeStamp],
[m].[Id], [m].[Name], [m].[TimeStamp]
FROM [Dbo].[Inventory] AS [i]
INNER JOIN [dbo].[Makes] AS [m] ON [i].[MakeId] = [m].[Id]
Multiple Include() statements can be used in the same query to join more than one entity to the
original. To work down the navigation property tree, use ThenInclude() after an Include(). For example, to
get all the Cars records with their related Make and Order information and the Customer information related
to the Order, use the following statement:
var cars = Context.Cars.Where(c => c.Orders.Any())
.Include(c => c.MakeNavigation)
.Include(c => c.Orders).ThenInclude(o => o.CustomerNavigation).ToList();


