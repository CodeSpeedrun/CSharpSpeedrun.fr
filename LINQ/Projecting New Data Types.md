Projecting New Data Types
It is also possible to project new forms of data from an existing data source. Let’s assume you want to take the
incoming ProductInfo[] parameter and obtain a result set that accounts only for the name and description
of each item.

static void GetNamesAndDescriptions(ProductInfo[] products)
{
Console.WriteLine("Names and Descriptions:");
var nameDesc =
from p
in products
select new { p.Name, p.Description };
foreach (var item in nameDesc)
{



When you need to return projected data to a caller, one approach is to transform the query result into
a System.Array object using the ToArray() extension method. Thus, if you were to update your query
expression as follows:
// Return value is now an Array.
static Array GetProjectedSubset(ProductInfo[] products)
{
var nameDesc =
from p in products select new { p.Name, p.Description };
// Map set of anonymous objects to an Array object.
return nameDesc.ToArray();
}

