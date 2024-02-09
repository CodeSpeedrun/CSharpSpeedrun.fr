/* How to declare nested for loops in C#?
C# allows us to put a for loop inside another for loop. This technique is called nested for loops. It is useful in scenarios we have multiple iterations.
*/
 
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 2; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    Console.WriteLine("a = {0}, b = {1}", a, b);
                }
            }
        }
    }
}