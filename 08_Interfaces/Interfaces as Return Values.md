Interfaces as Return Values
For example, you could write a method that takes an
array of Shape objects and returns a reference to the first item that supports IPointy.
static IPointy FindFirstPointyShape(Shape[] shapes)
{
foreach (Shape s in shapes)
{
if (s is IPointy ip)
{
return ip;
}
}
return null;
}
Console.WriteLine("***** Fun with Interfaces *****\n");
// Make an array of Shapes.
Shape[] myShapes = { new Hexagon(), new Circle(),
new Triangle("Joe"), new Circle("JoJo")};
// Get first pointy item.
IPointy firstPointyItem = FindFirstPointyShape(myShapes);
// To be safe, use the null conditional operator.
Console.WriteLine("The item has {0} points",
firstPointyItem?.Points);
