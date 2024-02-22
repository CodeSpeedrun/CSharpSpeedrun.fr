


Implicit Typing of Local Variables
var keyword of C#. This keyword allows you to define a local variable
without explicitly specifying the underlying data type. The variable, however, is strongly typed, as the
compiler will determine the correct data type based on the initial assignment
Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);

many LINQ queries will return a sequence of data types, which are not known until compile time.
Given that the underlying data type is not known until the application is compiled, you obviously can’t
declare a variable explicitly!





Object and Collection Initialization Syntax
object initialization syntax, which allows you to create a class or structure
variable and to set any number of its public properties in one fell swoop.
List<Rectangle> myListOfRects = new List<Rectangle>
{
new Rectangle {TopLeft = new Point { X = 10, Y = 10 },
BottomRight = new Point { X = 200, Y = 200}},



Lambda Expressions
C# lambda operator (=>)
which can be used any time you invoke a method that requires a strongly typed delegate
as an argument. Lambdas greatly simplify how you work with delegates, in that they reduce the amount of
code you must author by hand.
( ArgumentsToProcess ) => { StatementsToProcessThem }

static void LambdaExpressionSyntax()
{
// Make a list of integers.
List<int> list = new List<int>();
list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
// C# lambda expression.
List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);

Lambdas will be useful when working with the underlying object model of LINQ. As you will soon
find out, the C# LINQ query operators are simply a shorthand notation for calling true-blue methods on a
class named System.Linq.Enumerable. These methods typically require delegates (the Func<> delegate in
particular) as parameters, which are used to process your data to yield the correct result set. Using lambdas,
you can streamline your code and allow the compiler to infer the underlying delegate.




Extension Methods
C# extension methods allow you to tack on new functionality to existing classes without the need to subclass.

the first parameter is qualified with the this keyword and marks the type being extended.

namespace MyExtensions
{
static class ObjectExtensions
{
// Define an extension method to System.Object.
public static void DisplayDefiningAssembly(
this object obj)
{
When you are working with LINQ, you will seldom, if ever, be required to manually build your own
extension methods. However, as you create LINQ query expressions, you will be making use of numerous
extension methods already defined by Microsoft. In fact, each C# LINQ query operator is a shorthand
notation for making a manual call on an underlying extension method, typically defined by the System.
Linq.Enumerable utility class.




Anonymous Types
This feature can be used to quickly model the “shape” of data by allowing the compiler to
generate a new class definition at compile time, based on a supplied set of name-value pairs
To define an anonymous type, declare an implicitly typed variable and specify the
data’s shape using object initialization syntax.
// Make an anonymous type that is composed of another.
var purchaseItem = new {
TimeBought = DateTime.Now,
ItemBought =
new {Color = "Red", Make = "Saab", CurrentSpeed = 55},
Price = 34.000};

LINQ makes frequent use of anonymous types when you want to project new forms of data on the fly.
For example, assume you have a collection of Person objects and want to use LINQ to obtain information on
the age and Social Security number of each. Using a LINQ projection, you can allow the compiler to generate
a new anonymous type that contains your information












