/* What is a do-while loop?
It is a variation of the while loop with one key difference. The while loop is executed at least once even if the conditional expression is false. It always starts with the do keyword.
*/
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            do
            {
                Console.WriteLine("Hello World");
                counter++;

                if (counter > 3)
                {
                    break;
                }

            } while (true);
        }
    }
}