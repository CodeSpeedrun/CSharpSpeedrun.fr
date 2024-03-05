Explicit Loading with Global Query Filters


Global query filters are also in effect when loading related data explicitly. For example, if you wanted to
load the Car records for a Make, the IsDrivable filter will prevent nondrivable cars from being loaded into
memory. Take the following code snippet as an example:
var make = Context.Makes.First(x => x.Id == makeId);
Context.Entry(make).Collection(c=>c.Cars).Load();


By now it should be no surprise that the generated SQL query includes the filter for nondrivable cars.
SELECT [i].[Id], [i].[Color], [i].[IsDrivable],
[i].[MakeId], [i].[PetName], [i].[TimeStamp]
FROM [Dbo].[Inventory] AS [i]
WHERE ([i].[IsDrivable] = CAST(1 AS bit)) AND ([i].[MakeId] = 1
There is a slight catch to ignoring query filters when explicitly loading data. The type returned
by the Collection() method is CollectionEntry<Make,Car> and does not explicitly implement the
IQueryable<T> interface. To call IgnoreQueryFilters(), you must first call Query(), which returns an
IQueryable<Car>.
var make = Context.Makes.First(x => x.Id == makeId);
Context.Entry(make).Collection(c=>c.Cars).Query().IgnoreQueryFilters().Load();
The same process applies when using the Reference() method to retrieve data from a reference
navigation property.


