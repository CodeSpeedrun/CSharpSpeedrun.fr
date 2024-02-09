/* What is explicit casting?
Explicit casting is not done automatically because the compiler knows there will be data loss. So we need to do the casting manually by putting the target type in parentheses.

In other words, we have to prefix the variable with the target data type. For e.g., converting a larger numeric data type to a smaller data type.
*/
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
           double myLuckyDouble = 3.23175D; 
           int myLuckyInt = (int)myLuckyDouble; //prefix
           Console.WriteLine(myLuckyInt );
        }
    }
}
//3