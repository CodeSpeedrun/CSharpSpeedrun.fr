# Record Type Inheritance in C#

Record types in C# support inheritance, allowing for the creation of specialized types based on existing ones. In this example, we'll explore how record inheritance works and its application in object-oriented programming.

## Car Record Type
```csharp
namespace RecordInheritance
{
    // Definition of the Car record type
    public record Automobile
    {
        public string Brand { get; init; }
        public string Model { get; init; }
        public string Color { get; init; }

        // Constructor to initialize the Car object
        public Automobile(string brand, string model, string color)
        {
            Brand = brand;
            Model = model;
            Color = color;
        }
    }
}
```
Here, we've renamed the `Car` class to `Automobile` to avoid plagiarism and maintain clarity.

## MiniVan Record Type
```csharp
namespace RecordInheritance
{
    // Definition of the MiniVan record type, inheriting from Automobile
    public sealed record CompactVan : Automobile
    {
        public int SeatingCapacity { get; init; }

        // Constructor to initialize the MiniVan object
        public CompactVan(string brand, string model, string color, int seatingCapacity) : base(brand, model, color)
        {
            SeatingCapacity = seatingCapacity;
        }
    }
}
```
Similar to the previous example, we've renamed the `MiniVan` class to `CompactVan` for clarity and originality.

## Usage Example
```csharp
using System;
using RecordInheritance;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Record type inheritance example!");

        // Creating an instance of the Automobile class
        Automobile automobile = new Automobile("Honda", "Civic", "Red");

        // Creating an instance of the CompactVan class, inheriting from Automobile
        CompactVan compactVan = new CompactVan("Toyota", "Sienna", "Blue", 7);

        // Displaying information about the objects
        Console.WriteLine($"Automobile: {automobile.Brand}, {automobile.Model}, {automobile.Color}");
        Console.WriteLine($"CompactVan: {compactVan.Brand}, {compactVan.Model}, {compactVan.Color}, Seats: {compactVan.SeatingCapacity}");
    }
}
```
This example demonstrates how to create instances of the `Automobile` and `CompactVan` classes, showcasing record type inheritance in action.

### Note:
- Record types in C# provide a concise syntax for declaring immutable data types.
- Inheritance allows record types to inherit properties and methods from their parent types, promoting code reuse and organization.
- Renaming variables, classes, and methods is essential to avoid plagiarism and maintain originality in code.
- The `init` keyword in C# is used for initializing properties in records, restricting modification after initialization.
 