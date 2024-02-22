LINQ and Implicitly Typed Local Variables
static void QueryOverInts()
{
int[] numbers = {10, 20, 30, 40, 1, 2, 3, 8};
// Print only items less than 10.
IEnumerable<int> subset = from i in numbers where i < 10 select i;

static void QueryOverInts()
{
int[] numbers = {10, 20, 30, 40, 1, 2, 3, 8};
// Use implicit typing here...
var subset = from i in numbers where i < 10 select i;

Exactly what this type is under the covers (OrderedEnumerable<TElement, TKey>,
WhereArrayIterator<T>, etc.) is irrelevant and not necessary to discover

