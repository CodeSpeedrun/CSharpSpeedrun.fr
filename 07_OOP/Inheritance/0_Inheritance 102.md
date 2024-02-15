# Inheritance in Object-Oriented Programming (OOP)

Inheritance is a fundamental concept in Object-Oriented Programming (OOP) that facilitates code reuse and promotes a hierarchical structure among classes. It allows a new class to inherit properties and behavior from an existing class, thereby establishing a relationship often referred to as the "is-a" relationship.

## Introduction to Inheritance

In OOP, code reuse is achieved through inheritance and the containment/delegation model. Inheritance signifies an "is-a" relationship, where one class (the derived or child class) inherits attributes and methods from another class (the base or parent class).

### Types of Relationships in OOP
1. **Inheritance**: "is-a" relationship.
2. **Containment/Delegation**: "has-a" relationship.

### Benefits of Inheritance
- Promotes code reuse.
- Enhances code organization and maintenance.
- Facilitates polymorphism and dynamic binding.

## Key Concepts and Terminology

### Base Class (Superclass or Parent Class)
- The existing class that serves as the foundation for derived classes.
- Contains common attributes and methods shared by its subclasses.

### Derived Class (Subclass or Child Class)
- Inherits properties and behavior from its base class.
- Can extend functionality by adding new methods or overriding existing ones.

## Implementation in C#

In C#, inheritance is implemented using the `:baseclass` syntax. Let's delve into a sample implementation of inheritance in C#:

```csharp
namespace OOPConcepts
{
    // Base class representing a generic 'Vehicle'.
    class Vehicle
    {
        // Common properties and methods for vehicles.
        public string Make { get; set; }
        public string Model { get; set; }
        public void StartEngine()
        {
            Console.WriteLine("Engine started!");
        }
    }

    // Derived class 'Car' inheriting from 'Vehicle'.
    class Car : Vehicle
    {
        // Additional properties and methods specific to cars.
        public int NumberOfDoors { get; set; }
        public void Accelerate()
        {
            Console.WriteLine("Car is accelerating!");
        }
    }

    // Derived class 'Truck' inheriting from 'Vehicle'.
    class Truck : Vehicle
    {
        // Additional properties and methods specific to trucks.
        public int PayloadCapacity { get; set; }
        public void LoadCargo()
        {
            Console.WriteLine("Cargo loaded onto the truck!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of derived classes.
            Car myCar = new Car();
            Truck myTruck = new Truck();

            // Accessing inherited members.
            myCar.StartEngine();
            myCar.Accelerate();

            myTruck.StartEngine();
            myTruck.LoadCargo();
        }
    }
}
```

In the above example:
- `Vehicle` serves as the base class with common properties and methods.
- `Car` and `Truck` are derived classes inheriting from `Vehicle`, representing specific types of vehicles.
- Each derived class extends functionality with its own properties and methods.

## Conclusion

Inheritance is a powerful mechanism in OOP, enabling code reuse and establishing hierarchical relationships among classes. Understanding how to effectively utilize inheritance is crucial for developing modular and maintainable software systems in C# and other object-oriented languages.

 

# Inheritance in C#

Inheritance is a fundamental concept in object-oriented programming (OOP) that allows a class (subclass/derived class) to inherit properties and behaviors from another class (superclass/base class). It promotes code reusability and allows for creating hierarchies of classes.

## Basic Example

Let's consider a scenario where we have a hierarchy of vehicles. We'll start with a base class `Vehicle` and derive a subclass `Car` from it. Additionally, we'll introduce another subclass `Van` derived from `Car`.

### Vehicle Class

```csharp
public class Vehicle
{
    protected string Manufacturer { get; set; }
    protected int Year { get; set; }
    
    public Vehicle(string manufacturer, int year)
    {
        Manufacturer = manufacturer;
        Year = year;
    }
}
```

The `Vehicle` class represents the basic attributes shared by all vehicles, such as manufacturer and year.

### Car Class

```csharp
public class Car : Vehicle
{
    protected int NumSeats { get; set; }
    
    public Car(string manufacturer, int year, int numSeats) 
        : base(manufacturer, year)
    {
        NumSeats = numSeats;
    }
}
```

The `Car` class inherits from `Vehicle` and adds specific properties like the number of seats.

### Van Class

```csharp
public class Van : Car
{
    protected bool HasSlidingDoor { get; set; }
    
    public Van(string manufacturer, int year, int numSeats, bool hasSlidingDoor)
        : base(manufacturer, year, numSeats)
    {
        HasSlidingDoor = hasSlidingDoor;
    }
}
```

The `Van` class further extends `Car` and includes additional features like whether it has a sliding door or not.

## Key Concepts

- **Inheritance**: The process of deriving new classes from existing ones.
- **Base Class**: Also known as a superclass, it's the class from which other classes inherit properties and behaviors.
- **Derived Class**: Also known as a subclass, it's a class that inherits from another class.

## Benefits of Inheritance

- **Code Reusability**: Inherited classes can reuse the code of their base classes.
- **Abstraction**: Allows for abstracting common behaviors and attributes into a base class.
- **Polymorphism**: Enables polymorphic behavior where derived classes can be treated as instances of their base class.

## Conclusion

Inheritance is a powerful mechanism in C# that facilitates code organization, reuse, and abstraction. By understanding its principles, developers can design robust and scalable object-oriented systems.


# Inheritance in C#

Inheritance is a fundamental concept in object-oriented programming (OOP) where a class (subclass or derived class) inherits properties and behaviors from another class (superclass or base class). This allows for code reuse and the creation of hierarchical relationships between classes.

## Basic Syntax

In C#, the syntax for inheritance involves using the `:` symbol followed by the name of the base class.

```csharp
class BaseClass
{
    // Base class members
}

class DerivedClass : BaseClass
{
    // Derived class members
}
```

## The `protected` Keyword

In C#, the `protected` keyword is an access modifier that restricts access to members (fields, methods, properties) within the same class or derived classes. This keyword is particularly useful for implementing encapsulation and facilitating communication between base and derived classes.

```csharp
partial class Employee
{
    // Protected member accessible to derived classes
    protected string EmployeeName;

    // Example of a protected method
    protected void DoProtectedAction()
    {
        // Implementation details
    }
}
```

### Benefits and Considerations

- **Encapsulation**: Protected members allow for controlled access within the class hierarchy, preventing unauthorized access from outside classes.
- **Code Organization**: By exposing only necessary members, protected access promotes a cleaner and more organized class structure.
- **Flexibility**: Derived classes can utilize protected members to extend functionality or customize behavior without modifying the base class.

### Example Usage

```csharp
class Manager : Employee
{
    public void PrintEmployeeName()
    {
        Console.WriteLine($"Employee Name: {EmployeeName}");
    }

    public void DoManagerSpecificAction()
    {
        // Accessing a protected method
        DoProtectedAction();
    }
}
```

## Sealed Classes

In C#, a sealed class is one that cannot be inherited by other classes. It prevents derivation, meaning that the class cannot serve as a base class for any other class.

```csharp
sealed class UtilityClass
{
    // Utility class members
}
```

### Use Cases

- **Preventing Subclassing**: Sealing a class is useful when you want to ensure that its functionality cannot be extended or modified.
- **Optimization**: Compiler optimizations can be applied to sealed classes, potentially improving performance.

### Example

```csharp
sealed class MathUtility
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

// Cannot inherit from a sealed class
// class ExtendedMathUtility : MathUtility {} 
```

## Conclusion

Inheritance is a powerful mechanism in C# that facilitates code reuse and hierarchical organization of classes. Utilizing keywords like `protected` and `sealed` allows for fine-tuning access levels and class relationships, enhancing the maintainability and extensibility of your codebase.