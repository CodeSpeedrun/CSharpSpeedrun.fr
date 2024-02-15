# Understanding Constructors in C#

In C#, constructors are special methods within a class that allow you to initialize the state of an object at the time of its creation. 
They are essential for setting up the initial values of fields and properties in an object. 

## Basic Constructor

```csharp
class Vehicle
{
    // Fields representing the state of the Vehicle.
    public string ModelName;
    public int CurrentSpeed;

    // A custom default constructor.
    public Vehicle()
    {
        ModelName = "Toyota";
        CurrentSpeed = 0;
    }
}
```

In the above example, `Vehicle` class contains a constructor `Vehicle()` with no parameters. This constructor initializes the `ModelName` to "Toyota" and `CurrentSpeed` to 0 whenever a new instance of `Vehicle` is created without specifying any values.

## Constructor Overloading

```csharp
class Motorcycle
{
    // Fields representing the state of the Motorcycle.
    public string RiderName;
    public int RiderIntensity;

    // Constructor with optional arguments.
    public Motorcycle(int intensity = 0, string name = "")
    {
        RiderIntensity = intensity;
        RiderName = name;
    }
}
```

The `Motorcycle` class demonstrates constructor overloading by providing a constructor with optional parameters. This allows for flexibility when creating instances of `Motorcycle`, as parameters can be provided in any order or omitted altogether. 

### Example Usage:

```csharp
static void CreateMotorcycles()
{
    // Creating instances of Motorcycle with different parameters.
    Motorcycle m1 = new Motorcycle(); // RiderName = "", RiderIntensity = 0
    Motorcycle m2 = new Motorcycle(name: "Tiny"); // RiderName = "Tiny", RiderIntensity = 0
    Motorcycle m3 = new Motorcycle(7); // RiderName = "", RiderIntensity = 7
}
```

In the `CreateMotorcycles()` method, instances of `Motorcycle` are created with different combinations of parameters. This demonstrates how constructor overloading allows for various ways to initialize object state based

 
# Motorcycle Class

The `Motorcycle` class represents a motorcycle object with properties related to its driver's name and intensity level. This class showcases the usage of a static constructor and optional parameters in the constructor.

## Constructor

### Single Constructor with Optional Arguments

The `Motorcycle` class has a single constructor that accepts two optional arguments: `intensity` (an integer representing the intensity level of the driver) and `name` (a string representing the name of the driver). If no arguments are provided, default values are used.

```csharp
public Motorcycle(int intensity = 0, string name = "")
{
    // Constructor implementation
}
```

