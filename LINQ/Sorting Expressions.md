Sorting Expressions
By default, the order will be ascending; thus, ordering by a string
would be alphabetical, ordering by numerical data would be lowest to highest, and so forth

static void AlphabetizeProductNames(ProductInfo[] products)
{
// Get names of products, alphabetized.
var subset = from p in products orderby p.Name select p;

Except() extension method, which will return a LINQ result set that contains the difference between two
containers, which, in this case, is the value Yugo.

var carDiff =
(from c in myCars select c)
.Except(from c2 in yourCars select c2);
Console.WriteLine("Here is what you don't have, but I do:");
foreach (string s in carDiff)



The Intersect() method will return a result set that contains the common data items in a set of
containers. For example, the following method returns the sequence Aztec and BMW:
static void DisplayIntersection()
{
List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };
// Get the common members.
var carIntersect =
(from c in myCars select c)
.Intersect(from c2 in yourCars select c2);


// Get the union of these containers.
var carUnion =
(from c in myCars select c)
.Union(from c2 in yourCars select c2);



var carConcat =
(from c in myCars select c)
.Concat(from c2 in yourCars select c2);



