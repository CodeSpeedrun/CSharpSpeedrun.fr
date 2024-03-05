Filtered Include

For example, if you want to get all Make records, but only the related Car records where the color is
yellow, you filter the navigation property in the lambda expression, like this:
var query = Context.Makes
.Include(x => x.Cars.Where(x=>x.Color == "Yellow")).ToList();
The query that is executed is as follows:
SELECT [m].[Id], [m].[Name], [m].[TimeStamp], [t].[Id], [t].[Color],
[t].[MakeId], [t].[PetName], [t].[TimeStamp]
FROM [dbo].[Makes] AS [m]
LEFT JOIN (
SELECT [i].[Id], [i].[Color], [i].[MakeId], [i].[PetName], [i].[TimeStamp]
FROM [Dbo].[Inventory] AS [i]
WHERE [i].[Color] = N'Yellow') AS [t] ON [m].[Id] = [t].[MakeId]
ORDER BY [m].[Id], [t].[Id]

