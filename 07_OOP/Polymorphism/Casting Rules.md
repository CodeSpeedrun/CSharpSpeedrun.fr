# Object-Oriented Programming in C#

## Base Class/Derived Class Casting Rules

In object-oriented programming, understanding casting rules between base and derived classes is essential.

### The Ultimate Base Class: `System.Object`

In C#, the ultimate base class is `System.Object`. Every class implicitly inherits from this class. Hence, in the context of object-oriented programming, everything "is-an" `Object` and can be treated as such.

### Casting Examples

#### Example 1: Casting to `Object`

```csharp
// Creating a Manager instance
Manager aliceManager = new Manager("Alice", 10, 5000, 60000, "123-45-6789", 8);

// Storing the Manager instance in an object variable
object aliceObject = aliceManager;
```

In this example, we instantiate a `Manager` object named `aliceManager`. Since `Manager` is a derived class, it "is-an" `Object` due to inheritance. Therefore, we can safely store the `Manager` reference in an `object` variable.

#### Example 2: Casting Derived Classes

```csharp
// Creating a Manager instance
Manager bobManager = new Manager("Bob", 7, 4000, 55000, "987-65-4321", 5);

// Storing the Manager instance in an Employee reference
Employee bobEmployee = bobManager;
```

Here, we create a `Manager` object named `bobManager`. Since `Manager` inherits from `Employee`, we can assign a `Manager` reference to an `Employee` variable. This is possible due to the "is-a" relationship between `Manager` and `Employee`.

```csharp
// Creating a PtSalesPerson instance
PtSalesPerson carolSalesPerson = new PtSalesPerson("Carol", 234, 2000, 120000, "456-78-9123", 100);

// Casting PtSalesPerson to SalesPerson
SalesPerson carolSalesPersonBase = carolSalesPerson;
```

In this snippet, we instantiate a `PtSalesPerson` object named `carolSalesPerson`. Since `PtSalesPerson` is a specialized type of `SalesPerson`, we can safely cast `PtSalesPerson` to `SalesPerson`, which is its base class.

#### Example 3: Incorrect Casting

```csharp
// Creating a Manager instance
Manager daveManager = new Manager("Dave", 5, 3000, 45000, "135-79-2468", 3);

// Incorrect casting to Hexagon
Hexagon daveHexagon = (Hexagon)daveManager;
```

This example demonstrates an incorrect casting operation. Attempting to cast a `Manager` object to a `Hexagon`, which is unrelated, results in a runtime error.

### Conclusion

Understanding base class/derived class casting rules is crucial in C# programming. It enables efficient polymorphism and enhances code reusability by allowing objects of derived classes to be treated as objects of their base classes.

 