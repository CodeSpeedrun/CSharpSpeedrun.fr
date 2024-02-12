# Object-Oriented Programming in C#

## Introduction
In this tutorial, we'll explore various concepts of object-oriented programming (OOP) in C#. We'll cover topics like constructor chaining, the `this` keyword, and creating classes with methods.

## The `this` Keyword
The `this` keyword in C# refers to the current instance of the class. It is primarily used to differentiate between class members and parameters with the same name, or to call other constructors in the same class.

```csharp
public void SetDriver(string driverName) => this.driverName = driverName;
```
In this code snippet, the `SetDriver` method takes a `driverName` parameter and assigns it to the `driverName` field of the class. The usage of `this.driverName` explicitly refers to the field of the class, distinguishing it from the parameter with the same name.

## Constructor Chaining
Constructor chaining is a technique where one constructor calls another constructor in the same class. This allows for code reuse and simplifies the initialization process.

```csharp
public class Bike
{
    public int intensityLevel;
    public string bikeOwner;

    // Default constructor
    public Bike() {}

    // Constructor chaining
    public Bike(int intensity) : this(intensity, "") {}
    
    public Bike(string owner) : this(0, owner) {}

    // Master constructor
    public Bike(int intensity, string owner)
    {
        if (intensity > 10)
        {
            intensity = 10;
        }
        intensityLevel = intensity;
        bikeOwner = owner;
    }
}
```
In the `Bike` class above, we demonstrate constructor chaining. Each constructor calls another constructor in the class using the `this` keyword with different parameter combinations. This ensures that regardless of which constructor is called, the initialization logic defined in the "master" constructor is executed.

## Additional Concepts
- **Method Overloading**: In C#, you can define multiple methods with the same name but different parameter lists. This is called method overloading and allows for flexibility in how methods are called.
- **Encapsulation**: Encapsulation is the principle of bundling the data and methods that operate on the data into a single unit or class. It helps in hiding the internal state of an object and only exposing necessary functionality through methods.
- **Access Modifiers**: C# provides access modifiers like `public`, `private`, `protected`, etc., to control the accessibility of classes, methods, and other members. This helps in enforcing encapsulation and ensuring the proper usage of classes and objects.

