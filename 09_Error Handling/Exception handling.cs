/* Exception handling
The exceptions can be hard to understand, C# allows us to catch an exception and display understandable messages to the user. The try statement will test code for errors and the catch statement contains code to be executed if an error occurs.
We can use properties from the Exception class to output useful information when the compiler throws an error.
*/
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myLuckyNumers = { 14, 17, 54, 8 };
                Console.WriteLine(myLuckyNumers[7]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.TargetSite);
            }
        }
    }
}
/*
Index was outside the bounds of the array.
Main
Void Main()
*/