is polymorphism. This trait captures a language’s ability to treat related objects in
a similar manner.

a virtual member is a member in a base class that defines a default implementation that
may be changed (or more formally speaking, overridden) by a derived class. In contrast, an abstract method
is a member in a base class that does not provide a default implementation but does provide a signature.
When a class derives from a base class defining an abstract method, it must be overridden by a derived
type. In either case, when derived types override the members defined by a base class, they are essentially
redefining how they respond to the same request.
To preview polymorphism, let’s provide some

Consider the following code, which instructs an array of Shape-derived types to render themselves
using the Draw() method:
Shape[] myShapes = new Shape[3];
myShapes[0] = new Hexagon();
myShapes[1] = new Circle();
myShapes[2] = new Hexagon();
foreach (Shape s in myShapes)
{
// Use the polymorphic interface!
s.Draw();
}
Console.