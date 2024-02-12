## Encapsulation of Field Data in .NET Core using Properties

In .NET Core languages, properties are preferred over traditional get and set methods for encapsulating field data. Properties provide a more concise and expressive way to enforce data encapsulation and maintain control over access to class fields.

### Basic Property Syntax

Properties in C# consist of a getter and a setter, which allow read and write access to the encapsulated data respectively. Here's an example of a property encapsulating an employee's ID:

```csharp
public int EmployeeId // Property declaration
{
    get { return _employeeId; } // Getter
    set { _employeeId = value; } // Setter
}
```

In this example:
- `EmployeeId` is the name of the property.
- `_employeeId` is the underlying field storing the data.
- `get` retrieves the value of `_employeeId`.
- `set` sets the value of `_employeeId` to the incoming value (`value`).

### Contextual Keyword: `value`

The `value` keyword represents the incoming value used to assign the property by the caller. It is a contextual keyword, specifically used within the set accessor of a property. Its type is inferred from the property type.

```csharp
public int Age
{
    get { return _employeeAge; }
    set { _employeeAge = value; } // 'value' represents the incoming value
}
```

### Expression-Bodied Members

In C# 6 and later, properties can be written as expression-bodied members, providing a more concise syntax for simple getter and setter methods.

```csharp
public int Age
{
    get => _employeeAge;
    set => _employeeAge = value;
}
```

### Read-Only Properties

To create a read-only property, omit the setter block. This ensures that the property can only be set within the class itself.

```csharp
public string SocialSecurityNumber { get; private set; }
```

In this example, `SocialSecurityNumber` can be accessed publicly for reading but can only be set within the class.

### Access Modifiers

Properties can have different access modifiers for their getter and setter, allowing fine-grained control over accessibility.

```csharp
public int EmployeeId
{
    get { return _employeeId; } // Public getter
    private set { _employeeId = value; } // Private setter
}
```

In this case, `EmployeeId` can be read from anywhere, but it can only be set within the class itself.

 
 
# C# Properties and Fields Overview

## Introduction
In C#, properties and fields are crucial components for encapsulating data within classes. They allow for controlled access to the internal state of an object, enabling the enforcement of business rules and maintaining the integrity of the program's data.

## Static Property
```csharp
// A static property.
public static double InterestRate
{
    get { return _currentInterestRate; }
    set { _currentInterestRate = value; }
}
```
Static properties are accessed through the class itself rather than an instance of the class. They are commonly used for values that are shared among all instances of the class, such as configuration settings or constants.

## Automatic Properties
```csharp
class Car
{
    // Automatic properties! No need to define backing fields.
    public string PetName { get; set; }

    // The hidden int backing field is set to zero!
    public int NumberOfCars { get; set; }

    // The hidden Car backing field is set to null!
    public Car MyAuto { get; set; }
}
```
Automatic properties provide a concise syntax for defining properties without explicitly declaring backing fields. The compiler generates the backing field and the get/set methods automatically.

## Initializing Automatic Properties
```csharp
class Car
{
    // The hidden backing field is set to 1.
    public int NumberOfCars { get; set; } = 1;
    
    // The hidden backing field is set to a new Car object.
    public Car MyAuto { get; set; } = new Car();
}
```
Automatic properties can be initialized directly at the point of declaration, simplifying object initialization.

## Init-Only Setters (C# 9.0)
```csharp
class PointReadOnlyAfterCreation
{
    public int X { get; init; }
}
```
Introduced in C# 9.0, init-only setters allow properties to be set during initialization but become read-only after construction. This feature is particularly useful for creating immutable objects.

## Read-Only Fields
```csharp
class MyMathClass
{
    // Read-only fields can be assigned in constructors.
    public readonly double PI;

    public MyMathClass ()
    {
        PI = 3.14;
    }
}
```
Read-only fields can only be assigned within constructors and are immutable once initialized. They are useful for values that should not change after object construction.

## Static Read-Only Fields
```csharp
class MyMathClass
{
    // Static read-only field.
    public static readonly double PI;
}
```
Static read-only fields are shared among all instances of the class and are initialized once before any instance of the class is created. They must be explicitly marked as static.

## Conclusion
Understanding properties and fields in C# is fundamental for developing robust and maintainable code. Whether it's enforcing business rules, creating immutable objects, or managing shared data, properties and fields provide powerful tools for managing the state of your objects.
```
This markdown document provides an overview of C# properties and fields, explaining their syntax, usage, and advanced features such as init-only setters and read-only fields. It aims to educate university students on fundamental concepts in C# programming.