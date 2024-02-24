Reversing Result Sets
You can reverse the items within a result set quite simply using the Reverse<>() extension method of the
Enumerable class. For example, the following method selects all items from the incoming ProductInfo[]
parameter, in reverse:
static void ReverseEverything(ProductInfo[] products)
{
Console.WriteLine("Product in reverse:");
var allProducts = from p in products select p;
foreach (var prod in allProducts.Reverse())


