# Nested Types in C#

In C#, it is possible to define a type (such as enum, class, interface, struct, or delegate) directly within the scope of another class or structure. This feature is known as nested types.

## Nested Type Definition

Nested types can be defined within the curly braces `{}` of an outer class or structure. These nested types can have different access modifiers, such as `public`, `private`, `protected`, or `internal`, defining their visibility and accessibility.

```csharp
public class OuterClass
{
    // Definition of a public nested class.
    public class PublicInnerClass {}
    
    // Example usage of the public inner class.
    OuterClass.PublicInnerClass inner = new OuterClass.PublicInnerClass();
}
```

## Accessing Nested Types

Nested types can be accessed using their fully qualified names, which include the name of the outer class followed by a dot (`.`) and then the name of the nested type.

```csharp
OuterClass.PublicInnerClass inner = new OuterClass.PublicInnerClass();
```

## Visibility of Nested Types

The visibility of a nested type determines where it can be accessed from. For instance, a public nested type can be accessed by any code that has access to the outer class, while a private nested type is only accessible within the containing class.

## Benefits of Nested Types

### Encapsulation

Nested types allow for encapsulation of related functionality within a single class or structure. This helps in organizing code and reducing namespace clutter.

### Information Hiding

By making certain nested types private, you can hide implementation details and only expose the necessary functionality to the outside world.

### Enhanced Readability

Nested types can improve code readability by grouping related types together, making it easier for developers to understand the relationships between them.

## Examples

### Nested Classes

```csharp
public class OuterClass
{
    // Nested class for representing a point in 2D space.
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    
    // Usage example:
    Point origin = new Point { X = 0, Y = 0 };
}
```

### Nested Enums

```csharp
public class OuterClass
{
    // Nested enum for representing the days of the week.
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    
    // Usage example:
    DaysOfWeek today = DaysOfWeek.Monday;
}
```

### Nested Interfaces

```csharp
public class OuterClass
{
    // Nested interface for representing a shape.
    public interface IShape
    {
        double CalculateArea();
    }
    
    // Nested class implementing the IShape interface.
    public class Circle : IShape
    {
        public double Radius { get; set; }
        
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
    
    // Usage example:
    IShape shape = new Circle { Radius = 5 };
    double area = shape.CalculateArea();
}
```

## Conclusion

Nested types are a powerful feature in C# that allows for better organization, encapsulation, and readability of code. By nesting types within other types, you can create more modular and maintainable software solutions.
 