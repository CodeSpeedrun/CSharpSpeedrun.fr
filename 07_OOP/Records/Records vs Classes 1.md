# C# Classes vs Records

## Introduction

In C#, classes and records are both used to define data structures, but they have different characteristics and use cases. Understanding the differences between them is crucial for writing efficient and maintainable code. In this guide, we'll explore the distinctions between classes and records in C#, along with examples to illustrate their usage.

## Classes

### Definition

A class in C# is a blueprint for creating objects. It encapsulates data for the object and behavior through methods. Here's a simple example of a class in C#:

```csharp
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    
    public void StartEngine()
    {
        Console.WriteLine("Engine started!");
    }
}
```

In the above code:
- The `Car` class has three properties: `Make`, `Model`, and `Year`.
- It also has a method `StartEngine()` which prints a message indicating the engine has started.

### Usage

You can create instances of the `Car` class and access its properties and methods like this:

```csharp
Car myCar = new Car();
myCar.Make = "Toyota";
myCar.Model = "Camry";
myCar.Year = 2022;

Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}");
myCar.StartEngine();
```

## Records

### Definition

Records are a new feature introduced in C# 9.0. They are similar to classes but are primarily intended for immutable data types. Records provide a concise syntax for defining immutable types. Here's an example:

```csharp
public record Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int Age { get; init; }
}
```

In the above code:
- The `Person` record defines properties for `FirstName`, `LastName`, and `Age`.
- The `init` accessor ensures that these properties can only be set during initialization and cannot be modified afterward.

### Usage

Records are often used for representing data transfer objects (DTOs) or immutable data structures. You can create instances of a record like this:

```csharp
Person person = new Person
{
    FirstName = "John",
    LastName = "Doe",
    Age = 30
};

Console.WriteLine($"Hello, {person.FirstName} {person.LastName}! You are {person.Age} years old.");
```

## Conclusion

In summary, classes and records are both essential tools for defining data structures in C#. Classes are more flexible and suitable for objects with mutable state and behavior, while records are optimized for immutable data and provide a more concise syntax. Understanding when to use each is crucial for writing efficient and maintainable code.