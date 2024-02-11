/* implicit casting
Implicit casting is done automatically by the compiler. Data is copied without any data loss. For e.g., when converting a smaller data type to a larger data type. Remember that each data type takes a specific size in memory, when converting data types, size is really important.

*/
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
           int myLuckyInt = 10;
           double myLuckyDouble = myLuckyInt; 
           Console.WriteLine(myLuckyDouble);
        }
    }
}
//10