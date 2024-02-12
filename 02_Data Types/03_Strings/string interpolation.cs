/* string interpolation
A better way of combining two strings is called string interpolation. The dollar $ symbol at the beginning tells the compiler it is an interpolated string. The variables are wrapped with { } and are switched when the application is executed.

*/
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John ";
            string lastName = "Cena";

            Console.WriteLine($"My best friend is {firstName}{lastName}!");
        }
    }
}