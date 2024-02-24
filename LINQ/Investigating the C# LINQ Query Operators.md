Investigating the C# LINQ Query Operators
Common LINQ Query Operators
Query Operators Meaning in Life
from, in Used to define the backbone for any LINQ expression, which allows you to extract
a subset of data from a fitting container.
where Used to define a restriction for which items to extract from a container.
select Used to select a sequence from the container.
join, on, equals, into Performs joins based on specified key. Remember, these “joins” do not need to
have anything to do with data in a relational database.
orderby, ascending,
descending
Allows the resulting subset to be ordered in ascending or descending order.
groupby Yields a subset with data grouped by a specified value.

Basic Selection Syntax
Because the syntactical correctness of a LINQ query expression is validated at compile time, you need to
remember that the ordering of these operators is critical. In the simplest terms, every LINQ query expression
is built using the from, in, and select operators.

// Get everything!
Console.WriteLine("All product details:");
var allProducts = from p in products select p;
foreach (var prod in allProducts)

static void ListProductNames(ProductInfo[] products)
{
// Now get only the names of the products.
Console.WriteLine("Only product names:");
var names = from p in products select p.Name;


