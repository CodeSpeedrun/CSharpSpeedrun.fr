Global Query Filters

Global query filters enable a where clause to be added into all LINQ queries for a particular entity. For example,
a common database design pattern is to use soft deletes instead of hard deletes.

modelBuilder.Entity<Car>(entity =>
{
entity.HasQueryFilter(c => c.IsDrivable == true);
entity.Property(p => p.IsDrivable).HasField("_isDrivable").HasDefaultValue(true);
});
With the global query filter in place, queries involving the Car entity will automatically filter out the
nondrivable cars. For example, executing this LINQ query:
var cars = Context.Cars.ToList();
executes the following SQL:
SELECT [i].[Id], [i].[Color], [i].[IsDrivable], [i].[MakeId], [i].[PetName], [i].[TimeStamp]
FROM [Dbo].[Inventory] AS [i]
WHERE [i].[IsDrivable] = CAST(1 AS bit)
If you need to see the filtered records, add IgnoreQueryFilters() into the LINQ the query, which
disables the global query filters for every entity in the LINQ query. Executing this LINQ query:
var cars = Context.Cars.IgnoreQueryFilters().ToList();
executes the following SQL:
SELECT [i].[Id], [i].[Color], [i].[IsDrivable], [i].[MakeId], [i].[PetName], [i].[TimeStamp]
FROM [Dbo].[Inventory] AS [i]


