```csharp
// Interface Default Implementations

// Define an interface for regular pointy shapes
interface IPointy
{
    byte Points { get; }
}

// Extend the IPointy interface to include properties for side length and number of sides,
// as well as a default implementation for calculating the perimeter
interface IRegularPointy : IPointy
{
    int SideLength { get; set; }
    int NumberOfSides { get; set; }
    int Perimeter => SideLength * NumberOfSides;
}

// Define a base class for shapes
class Shape
{
    public string Name { get; }

    public Shape(string name)
    {
        Name = name;
    }

    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

// Implement the IRegularPointy interface in a class for a square shape
class QuadShape : Shape, IRegularPointy
{
    public QuadShape() { }
    
    public QuadShape(string name) : base(name) { }

    // Override the Draw method to specify how a square is drawn
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }

    // Implement the Points property from the IPointy interface
    public byte Points => 4;

    // Implement properties for side length and number of sides from the IRegularPointy interface
    public int SideLength { get; set; }
    public int NumberOfSides { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a square object with a name "Boxy" and set the number of sides and side length
        var quad = new QuadShape("Boxy") { NumberOfSides = 4, SideLength = 4 };

        // Draw the square
        quad.Draw();

        // Output the properties of the square
        Console.WriteLine($"{quad.Name} has {quad.NumberOfSides} sides of length {quad.SideLength} and a perimeter of {quad.Perimeter}");
    }
}
```
This code demonstrates the usage of interfaces and default implementations in C#. Here's a breakdown:

- **Interfaces**: Interfaces define a contract for classes to implement. In this code, `IPointy` and `IRegularPointy` are interfaces defining properties for pointy shapes and regular pointy shapes respectively.

- **Default Implementations**: The `Perimeter` property in the `IRegularPointy` interface provides a default implementation for calculating the perimeter of a regular pointy shape.

- **Base Class**: The `Shape` class serves as a base class for different types of shapes. It contains a `Name` property and a virtual `Draw` method which can be overridden by derived classes.

- **Derived Class**: The `QuadShape` class implements the `IRegularPointy` interface to represent a square shape. It inherits from the `Shape` class and provides an implementation for the `Draw` method.

- **Main Method**: In the `Main` method, a `QuadShape` object named "Boxy" is created with a specified number of sides and side length. It is then drawn and its properties are outputted, including its name, number of sides, side length, and perimeter.