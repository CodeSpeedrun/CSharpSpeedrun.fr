# Polymorphism in C#

Polymorphism is a fundamental concept in object-oriented programming (OOP) that allows objects of different types to be treated as objects of a common base type. In C#, polymorphism is achieved through method overriding and method overloading.

## Method Overriding and Virtual Methods

Method overriding is a feature that allows a subclass to provide a specific implementation of a method that is already defined in its superclass. This is achieved using the `override` keyword in C#. To enable method overriding, the superclass method must be declared as `virtual`.

### Example:

```csharp
public class Employee
{
    // A virtual method that can be overridden by derived classes.
    public virtual void GiveBonus(float amount)
    {
        // Base implementation of giving bonus.
    }
}
```

In the above code snippet, the `GiveBonus` method is declared as `virtual` in the `Employee` class, indicating that it can be overridden by subclasses.

## Method Overriding in Derived Classes

When a subclass wants to provide its own implementation of a method that is already defined in its superclass, it uses the `override` keyword.

### Example:

```csharp
public class SalesPerson : Employee
{
    // Overrides the GiveBonus method to provide a specific implementation for SalesPerson.
    public override void GiveBonus(float amount)
    {
        // Custom implementation of giving bonus for SalesPerson.
    }
}
```

In this example, the `SalesPerson` class inherits from the `Employee` class and overrides the `GiveBonus` method to provide a different implementation specific to salespersons.

## Additional Concepts

### Base Keyword

The `base` keyword in C# is used to access members of the base class from within a derived class. It is often used to call the constructor, methods, or properties of the base class.

### Example:

```csharp
public override void DisplayStats()
{
    base.DisplayStats(); // Calls the DisplayStats method of the base class.
    Console.WriteLine("Number of Sales: {0}", SalesNumber);
}
```

In this snippet, `base.DisplayStats()` calls the `DisplayStats` method of the base class before adding additional functionality specific to the `SalesPerson` class.

### Abstract Classes and Methods

In addition to `virtual` and `override`, C# also supports `abstract` classes and methods. Abstract methods are declared without implementation and must be overridden by derived classes. Abstract classes cannot be instantiated and are often used as base classes for other classes.

### Example:

```csharp
public abstract class Shape
{
    // Abstract method to calculate the area of a shape.
    public abstract float CalculateArea();
}
```

In the above code, `Shape` is an abstract class with an abstract method `CalculateArea()`. Any class inheriting from `Shape` must provide an implementation for `CalculateArea()`.

### Interfaces

Interfaces in C# define a contract that classes can implement. They contain only method signatures, properties, events, or indexers. Implementing an interface ensures that the implementing class provides concrete implementations for all members of the interface.

### Example:

```csharp
public interface IRenderable
{
    void Render();
}
```

In this example, `IRenderable` is an interface with a single method `Render()`. Any class implementing `IRenderable` must provide an implementation for the `Render` method.

## Conclusion

Polymorphism is a powerful concept in C# that enables code reusability, flexibility, and extensibility in object-oriented programming. By understanding method overriding, virtual methods, abstract classes, interfaces, and related concepts, developers can write more maintainable and scalable code.