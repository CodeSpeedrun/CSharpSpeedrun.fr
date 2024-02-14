Interfaces as Parameters
interfaces are valid types, you may construct methods that take interfaces as parameters,
// Models the ability to render a type in stunning 3D.
public interface IDraw3D
{

// Circle supports IDraw3D.
class ThreeDCircle : Circle, IDraw3D
{
...
public void Draw3D()
=> Console.WriteLine("Drawing Circle in 3D!"); }
}

