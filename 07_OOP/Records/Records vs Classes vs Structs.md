# C# Classes vs Records vs Structs

In C#, there are several ways to define custom data types: classes, records, and structs. Each has its own use cases, advantages, and limitations. Understanding the differences between them is crucial for writing efficient and maintainable code.

## Classes

Classes are reference types and are the most commonly used way to define custom data types in C#. They are flexible and can contain fields, properties, methods, events, indexers, constructors, and even nested types.

```csharp
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
```

### Usage:

```csharp
var person = new Person { Name = "John", Age = 30 };
person.DisplayInfo();
```

#### Advantages:
- Support for inheritance and polymorphism.
- Flexibility in defining behavior through methods and properties.
- Can implement interfaces.

#### Disadvantages:
- Consumes more memory due to being reference types.
- Slower performance compared to structs.

## Records

Records were introduced in C# 9.0 and are immutable reference types. They are primarily used for modeling immutable data and come with built-in value-based equality semantics.

```csharp
public record Point(int X, int Y);
```

### Usage:

```csharp
var point1 = new Point(1, 2);
var point2 = new Point(1, 2);

Console.WriteLine(point1.Equals(point2)); // true
```

#### Advantages:
- Concise syntax for defining immutable data.
- Built-in value-based equality comparison.
- Efficient memory usage for small, immutable data structures.

#### Disadvantages:
- Immutability might not always be desirable.
- Limited customization compared to classes.

## Structs

Structs are value types in C# and are commonly used for small, lightweight objects that are frequently copied, such as coordinates, colors, and other simple data types.

```csharp
public struct Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int Area() => Width * Height;
}
```

### Usage:

```csharp
var rect = new Rectangle { Width = 5, Height = 10 };
Console.WriteLine(rect.Area()); // 50
```

#### Advantages:
- Better performance compared to classes due to being value types.
- Suitable for small, frequently copied data.
- Stack allocation can lead to better memory usage in some scenarios.

#### Disadvantages:
- Limited support for inheritance and polymorphism.
- Boxing and unboxing can occur when used in certain contexts.

## Conclusion

Choosing between classes, records, and structs depends on the specific requirements of your application. Classes offer flexibility and support for complex scenarios, while records are ideal for immutable data modeling. Structs provide better performance and memory efficiency for small, frequently copied data. Understanding the strengths and weaknesses of each allows you to make informed decisions when designing your C# applications.