
```csharp 
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSpeedrun
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] myFavCars = { "Toyota", "BMW", "Tesla" };

            IEnumerable<string> myQuery = from car in myFavCars
                                          where car.Contains('s')
                                          select car;

            foreach (string car in myQuery)
            {
                Console.WriteLine(car);
            }
        }
    }
}
//Tesla
```