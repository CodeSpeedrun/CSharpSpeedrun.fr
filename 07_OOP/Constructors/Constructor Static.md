## Static Constructor

### Explanation

A static constructor in C# is used to initialize any static data or perform a particular action only once, at the time of class loading. Unlike an instance constructor, a static constructor does not take any access modifiers and cannot have any parameters. It's called automatically before the first instance is created or any static members are accessed.

```csharp
static Motorcycle()
{
    // Static constructor implementation
}
```

### Example Usage

The following example demonstrates the usage of the `MakeSomeBikes` method, which instantiates `Motorcycle` objects with different combinations of constructor arguments.

```csharp
public static void MakeSomeBikes()
{
    // Create Motorcycle objects with different constructor arguments
}
```

#### Example Instantiation

```csharp
// Instantiate Motorcycle objects with different constructor arguments
Motorcycle bike1 = new Motorcycle();
Motorcycle bike2 = new Motorcycle(name: "Tiny");
Motorcycle bike3 = new Motorcycle(intensity: 7);
```

##### Output:

- **Bike 1:**
  - Driver Name: ""
  - Intensity: 0

- **Bike 2:**
  - Driver Name: "Tiny"
  - Intensity: 0

- **Bike 3:**
  - Driver Name: ""
  - Intensity: 7
 

In this demonstration, the static constructor of the `Motorcycle` class is not explicitly provided, but it's assumed to be present. Static constructors are useful for initializing static fields or performing one-time setup tasks for a class. They are automatically invoked by the runtime before any static members are accessed or any instances are created.