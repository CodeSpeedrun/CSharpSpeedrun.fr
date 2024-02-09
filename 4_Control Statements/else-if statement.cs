/* else-if statement
*/
 using System;

namespace CSharpSpeedrun. 
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 27;

            if (a == b)
            {
                Console.WriteLine("a is equal to b");
            }
            else if (a > b)
            {
                Console.WriteLine("a is greater than b");
            }
            else if (a < b)
            {
                Console.WriteLine("a is less than b");
            }
        }
    }
}