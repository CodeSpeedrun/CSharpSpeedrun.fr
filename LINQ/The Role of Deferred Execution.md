The Role of Deferred Execution
this is termed deferred
execution. The benefit of this approach is that you can apply the same LINQ query multiple times to the
same container and rest assured you are obtaining the latest and greatest results.

static void QueryOverInts()
{
int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
// Get numbers less than ten.
var subset = from i in numbers where i < 10 select i;
// LINQ statement evaluated here!
foreach (var i in subset)
{
Console.WriteLine("{0} < 10", i);
}
Console.WriteLine();
// Change some data in the array.
numbers[0] = 4;
// Evaluated again!
foreach (var j in subset)

