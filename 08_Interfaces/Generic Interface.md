## Generic Interface

```csharp
using System;

namespace CSharpSpeedrun
{
    interface ICalculator<T>
    {
        double Addition(T number1, T number2);
        double Subtraction(T number1, T number2);
    }

    class Calculator<T> : ICalculator<T>
    {
        public double Addition(T number1, T number2)
        {
            double result = Convert.ToDouble(number1) + Convert.ToDouble(number2);
            return result;
        }

        public double Subtraction(T number1, T number2)
        {
            double result = Convert.ToDouble(number1) + Convert.ToDouble(number2);
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int> c1 = new Calculator<int>();
            double result1 = c1.Addition(12, 50);
            Console.WriteLine("Addition(12, 50) result = {0}", result1);

            Calculator<float> c2 = new Calculator<float>();
            double result2 = c2.Subtraction(3.118f, 5.623f);
            Console.WriteLine("Subtraction(3.118f, 5.623f) result = {0:f}", result2);
        }
    }
}
//Addition(12, 50) result = 62
//Subtraction(3.118f, 5.623f) result = 8.74
```