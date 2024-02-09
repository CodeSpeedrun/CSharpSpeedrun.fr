/* @ operator to escape characters
It can be very tedious to prefix a \ for every single special character found in a piece of text. Another way to escape special characters is by using the @ operator. It tells the compiler that every special character should be treated as a normal character.
The @ operator will escape most special characters except double-quotes. So, we’ll use it in combination with the \ to escape all the special characters found in common text.
*/
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            string helpdeskMessage = @"The \"software\" will be installed in D:\ProgramData\Adobe\Installer";

            Console.WriteLine(helpdeskMessage);
        }
    }
}

//The “software” will be installed in D:\ProgramData\Adobe\Installer