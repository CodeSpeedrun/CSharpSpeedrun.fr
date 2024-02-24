Filtering Data Using OfType<T>()

static void OfTypeAsFilter()
{
// Extract the ints from the ArrayList.
ArrayList myStuff = new ArrayList();
myStuff.AddRange(new object[] { 10, 400, 8, false, new Car(), "string data" });
var myInts = myStuff.OfType<int>();
// Prints out 10, 400, and 8.
foreach (int i in myInts)

