/* .NET aliases
Since C# applications run on top of the .NET framework, 
it is possible to use the .NET data type alias instead of the C# data types and the output will be identical.
*/
using System;

namespace CSharpSpeedrun {
    class Program {
        static void Main(string[] args) {
            int myInt = 45643;
            System.Int32 mySpecialInt = 45643;

            Console.WriteLine(myInt);
            Console.WriteLine(mySpecialInt);
        }
    }
}

/* 
45643
45643 
*/