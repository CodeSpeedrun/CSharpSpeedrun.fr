## Polymorphism in C#

Polymorphism is a fundamental concept in object-oriented programming that allows objects of different types to be treated as objects of a common base type. This trait captures a language’s ability to treat related objects in a similar manner.

### Virtual Members vs Abstract Methods

#### Virtual Members
A virtual member in a base class defines a default implementation that can be changed (overridden) by a derived class. This allows derived classes to provide their own implementation while still utilizing the base class's behavior as needed.

#### Abstract Methods
An abstract method, on the other hand, is a member in a base class that does not provide a default implementation but does provide a signature. When a class derives from a base class defining an abstract method, it must provide its own implementation. Abstract methods enforce derived classes to implement the method, ensuring consistency in behavior across different derived types.

### Example Code

Consider the following C# code snippet, which demonstrates polymorphism by instructing an array of `Shape`-derived types to render themselves using the `Draw()` method:

```csharp
Shape[] shapes = new Shape[3];
shapes[0] = new Hexagon();
shapes[1] = new Circle();
shapes[2] = new Hexagon();

foreach (Shape shape in shapes)
{
    // Use the polymorphic interface!
    shape.Draw();
}
```

In this example:
- `Shape` is a base class representing a geometric shape.
- `Hexagon` and `Circle` are derived classes inheriting from `Shape`.
- Each shape in the array `shapes` is treated uniformly through polymorphism, despite being different types.

### Implementation Details

1. **Shape Base Class**: This class serves as the base for various geometric shapes and defines a virtual method `Draw()`.
   
   ```csharp
   public abstract class Shape
   {
       // Virtual method
       public virtual void Draw()
       {
           Console.WriteLine("Drawing a shape.");
       }
   }
   ```

2. **Derived Classes**: `Hexagon` and `Circle` are derived from `Shape` and provide their own implementations of the `Draw()` method.
   
   ```csharp
   public class Hexagon : Shape
   {
       public override void Draw()
       {
           Console.WriteLine("Drawing a hexagon.");
       }
   }

   public class Circle : Shape
   {
       public override void Draw()
       {
           Console.WriteLine("Drawing a circle.");
       }
   }
   ```

3. **Polymorphic Usage**: In the main code, an array of `Shape` objects is created and populated with instances of `Hexagon` and `Circle`. The `foreach` loop iterates through each shape in the array and invokes the `Draw()` method, which dynamically calls the appropriate implementation based on the actual type of each shape.

### Conclusion

Polymorphism enhances code flexibility and extensibility by allowing different objects to be treated uniformly through a common interface. Virtual members and abstract methods play key roles in enabling polymorphic behavior in object-oriented programming languages like C#. Understanding these concepts is essential for developing robust and maintainable software systems.