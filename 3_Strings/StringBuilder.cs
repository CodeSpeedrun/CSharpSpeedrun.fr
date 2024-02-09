/*What is StringBuilder?
The string data type is designed to be immutable. In other words, once it is created, it cannot be modified. When a string variable is assigned a new value, the compiler creates a new string object in memory. As you can guess, repeatedly assigning new values to variables hinders performance.

The StringBuilder was introduced to solve this issue. It doesn’t create a new string objects, instead, it constantly expands memory to house the newly modified string.
*/
using System;
using System.Text;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello ");
            sb.AppendLine("World!");
            sb.AppendLine("Welcome to CSharpSpeedrun");
            Console.WriteLine(sb);
        }
    }  
}
/*
Hello World!
Welcome to CSharp Speedrun
*/