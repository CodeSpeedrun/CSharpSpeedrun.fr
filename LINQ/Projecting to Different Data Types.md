Projecting to Different Data Types
to projecting into anonymous types, you can project the results of your LINQ query into another
concrete type. This allows for static typing and using IEnumerable<T> as the result set.

static void GetNamesAndDescriptionsTyped(
ProductInfo[] products)
{
Console.WriteLine("Names and Descriptions:");
IEnumerable<ProductInfoSmall> nameDesc =
from p
in products
select new ProductInfoSmall
{ Name=p.Name, Description=p.Description };
foreach (ProductInfoSmall item in nameDesc)


