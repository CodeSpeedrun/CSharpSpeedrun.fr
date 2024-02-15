### How to implement dynamic polymorphism?
For example, let’s say a base class Vehicle has a method ActivateWiper() and child classes are Car, Truck and they have their own implementation of ActivateWiper().

```csharp
using System;

namespace CSharpSpeedrun
{
    class Vehicle  //parent
    {
        public virtual void ActivateWiper() 
        {
            Console.WriteLine("generic wiper activated");
        }
    }

    class Car : Vehicle  //child
    {
        public override void ActivateWiper() 
        {
            Console.WriteLine("car wiper activated");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle  myVehicle = new Vehicle();
            Car myCar = new Car();
            myVehicle.ActivateWiper(); 
            myCar.ActivateWiper(); 
        }
    }
}
//generic wiper activated
//car wiper activated
```