# The IComparable Interface
The `IComparable` interface specifies a behavior that allows an object to be sorted based on some specified key.

## Formal Definition
```csharp
// This interface allows an object to specify its relationship between other like objects.
public interface IComparable
{
    int CompareTo(object o);
}
```

The generic version of this interface (`IComparable<T>`) provides a more type-safe manner to handle comparisons between objects.

## Implementation Example
```csharp
namespace ComparableVehicle
{
    public class Vehicle : IComparable
    {
        // Properties
        public string Name { get; set; }
        public int CurrentSpeed { get; set; }
        public int VehicleID { get; set; }

        // Constructor
        public Vehicle(string name, int speed, int id)
        {
            Name = name;
            CurrentSpeed = speed;
            VehicleID = id;
        }

        // CompareTo method implementation
        int IComparable.CompareTo(object obj)
        {
            if (obj is Vehicle otherVehicle)
            {
                return this.VehicleID.CompareTo(otherVehicle.VehicleID);
            }
            throw new ArgumentException("Parameter is not a Vehicle!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Sorting *****\n");

            // Make an array of Vehicle objects.
            Vehicle[] myVehicles = new Vehicle[5];
            myVehicles[0] = new Vehicle("Car A", 80, 1);
            myVehicles[1] = new Vehicle("Car B", 40, 2);

            // Display current array.
            Console.WriteLine("Here is the unordered set of vehicles:");
            foreach (Vehicle v in myVehicles)
            {
                Console.WriteLine("{0} {1}", v.VehicleID, v.Name);
            }

            // Now, sort them using IComparable!
            Array.Sort(myVehicles);

            // Display sorted array.
            Console.WriteLine("\nHere is the ordered set of vehicles:");
            foreach (Vehicle v in myVehicles)
            {
                Console.WriteLine("{0} {1}", v.VehicleID, v.Name);
            }
        }
    }
}
```

In this implementation:
- `Vehicle` class represents a generic vehicle with properties like Name, CurrentSpeed, and VehicleID.
- `IComparable.CompareTo` method is implemented to compare vehicles based on their VehicleID.
- In the `Main` method, an array of `Vehicle` objects is created and sorted using `Array.Sort` method.

This allows custom types like `Vehicle` to be sorted in arrays using the `IComparable` interface.