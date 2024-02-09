/* How to break a while loop in C#?
There are multiple ways to stop a while loop. Instead of using a boolean expression, the break keyword can be used.
*/
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("Hello World!");
                i++;

                if (i >= 3)
                {
                    break;
                }
            }
        }
    }
}