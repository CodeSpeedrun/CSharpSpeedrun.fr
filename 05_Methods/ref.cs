/* What is the ref modifier?
The ref modifier is short for reference. Using ref, passes a reference to the original data instead of a copy. Notice the ref modifier is added in two places. Firstly, inside the method declaration GetSquared(ref myFavNumber);. Secondly, when calling the method. static void GetSquared(ref int number)

This time, we get the expected result 49 instead of 7.
*/
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main()
        {
            int myFavNumber = 7;

            GetSquared(ref myFavNumber);

            Console.WriteLine(myFavNumber);
        }

        static void GetSquared(ref int number)
        {
            number = number * number;
        }
    }
}