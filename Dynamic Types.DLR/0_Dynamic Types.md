Dynamic Types and the Dynamic
Language Runtime

dynamic. This keyword allows you to
incorporate scripting-like behaviors into the strongly typed world of type safety, semicolons, and curly
brackets. Using this loose typing, you can greatly simplify some complex coding tasks and also gain the
ability to interoperate with a number of dynamic languages that are .NET Core savvy.

how loosely typed
calls are mapped to the correct in-memory object using the Dynamic Language Runtime (DLR).

Don’t confuse the C# dynamic keyword with the concept of a dynamic assembly

implicit typing is useful
with LINQ, as many LINQ queries return enumerations of anonymous classes (via projections) that you
cannot directly declare in your C# code.


From a high level, you can consider the dynamic keyword a
specialized form of System.Object, in that any value can be assigned to a dynamic data type.


static void PrintThreeStrings()
{
var s1 = "Greetings";
object s2 = "From";
dynamic s3 = "Minneapolis";
Console.WriteLine("s1 is of type: {0}", s1.GetType());
Console.WriteLine("s2 is of type: {0}", s2.GetType());
Console.WriteLine("s3 is of type: {0}", s3.GetType());

s1 is of type: System.String
s2 is of type: System.String
s3 is of type: System.String


static void ChangeDynamicDataType()
{
// Declare a single dynamic data point
// named "t".
dynamic t = "Hello!";
Console.WriteLine("t is of type: {0}", t.GetType());
t = false;
Console.WriteLine("t is of type: {0}", t.GetType());
t = new List<int>();
Console.WriteLine("t is of type: {0}", t.GetType());
}
t is of type: System.String
t is of type: System.Boolean
t is of type: System.Collections.Generic.List`1[System.Int32]


