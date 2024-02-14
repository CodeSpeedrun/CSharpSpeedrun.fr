# Arrays of Interface Types in C#

In C#, interfaces provide a way to define a contract that classes can adhere to. Arrays of interface types allow for flexibility in working with different types of objects that implement the same interface. This concept is essential for polymorphism and abstraction in object-oriented programming.

## Interface Implementation

Interfaces in C# define a set of method and property signatures without specifying the implementation. Classes that implement an interface must provide concrete implementations for all the members of that interface.

```csharp
// ISharp.cs
namespace CustomInterfaces
{
    interface ISharp
    {
        byte Points { get; }
    }
}
```

In the above code snippet, we define an interface called `ISharp`, which has a property `Points` returning a byte value.

## Implementing Interfaces

Let's implement the `ISharp` interface in different classes representing various sharp objects like knives, forks, and pitchforks.

```csharp
// Knife.cs
namespace CustomInterfaces
{
    class Knife : ISharp
    {
        public byte Points => 2;
    }
}

// Fork.cs
namespace CustomInterfaces
{
    class Fork : ISharp
    {
        public byte Points => 4;
    }
}

// PitchFork.cs
namespace CustomInterfaces
{
    class PitchFork : ISharp
    {
        public byte Points => 3;
    }
}
```

Here, `Knife`, `Fork`, and `PitchFork` classes implement the `ISharp` interface, providing the implementation for the `Points` property.

## Array of Interface Types

Arrays of interface types allow for collections of objects that implement the same interface, providing flexibility in working with different types of objects interchangeably.

```csharp
using System;

namespace CustomInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of objects implementing ISharp interface
            ISharp[] sharpObjects = { new Knife(), new Fork(), new PitchFork() };

            foreach (ISharp sharpObject in sharpObjects)
            {
                Console.WriteLine("Object has {0} points.", sharpObject.Points);
            }

            Console.ReadLine();
        }
    }
}
```

In the `Main` method of the `Program` class, we create an array `sharpObjects` of type `ISharp[]`, which can hold objects of classes implementing the `ISharp` interface. We then iterate through the array and print out the number of points each object has.

## Polymorphism and Abstraction

Arrays of interface types exemplify polymorphism and abstraction, allowing code to be written in terms of interfaces rather than concrete implementations. This enhances flexibility and extensibility in the codebase, as new classes implementing the interface can seamlessly integrate with existing code.

## Conclusion

Understanding arrays of interface types in C# is crucial for writing flexible and maintainable code. By leveraging interfaces, polymorphism, and abstraction, developers can design robust systems that can accommodate changes and additions with minimal impact on existing code.