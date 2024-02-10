/* What is Regex (Regular Expression)?
A Regular Expression is a pattern that is often used to validate text. In C#, the related classes comes from the System.Text.RegularExpressions namespace.
*/
using System;
using System.Text.RegularExpressions;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "Hello world, warm welcome@to C#SharpSpeedrun";
            string result = Regex.Replace(txt, "[^a-zA-Z0-9_]+", " ");
            Console.Write( result); 
        }
    }
}
/*
Hello world warm welcome to C SharpSpeedrun
*/