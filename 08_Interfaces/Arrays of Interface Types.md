Arrays of Interface Types
For example, assume you have developed three new class types
within your current project that model kitchen utensils (via Knife and Fork classes) and another modeling
gardening equipment (à la PitchFork).
//Fork.cs
namespace CustomInterfaces
{
class Fork : IPointy
{
public byte Points => 4;
}
}
//PitchFork.cs
namespace CustomInterfaces
{
class PitchFork : IPointy
{
public byte Points => 3;
}
}

// This array can only contain types that
// implement the IPointy interface.
IPointy[] myPointyObjects = {new Hexagon(), new Knife(),
new Triangle(), new Fork(), new PitchFork()};
foreach(IPointy i in myPointyObjects)
{
Console.WriteLine("Object has {0} points.", i.Points);
}
Console.ReadLine();
Just to highlight the importance of this example, remember this: when you have an array of a given
interface, the array can contain any class or structure that implements that interface.

