/* 
ternary operator in C#
*/
 
using System;

namespace CSharpSpeedrun 
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentGrade = 52;
            string result;

            result = (studentGrade < 40) ? "Student has failed module." : "Student has passed the module!";
            Console.WriteLine(result);
        }
    }
}

//Student has passed the module!