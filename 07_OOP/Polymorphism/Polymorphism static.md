### How to implement static polymorphism?

- Let’s say we need a method that works well with int and double data types. The compiler automatically selects the correct method based on the data that is passed when the method is called. 
- For example, passing AdditionCalculator(1,4) calls the method that returns the int and passing dditionCalculator(1.1,4) calls the method that returns double.

```csharp
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static public int AdditionCalculator(int number1, int number2)
            => number1 + number2;

        static public double AdditionCalculator(double number1, double number2)
            => number1 + number2;

        static void Main(string[] args)
        {
            Console.WriteLine(AdditionCalculator(1, 4));
        }
    }
}
//5
```