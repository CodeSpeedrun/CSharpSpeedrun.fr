/* enum
*/
 using System;

namespace CSharpSpeedrun 
{
    class Program
    {
        enum Days
        {
            Monday,     //0
            Tuesday,    //1
            Wednesday,  //2
            Thursday = 17,
            Friday,     //18
            Saturday,   //19
            Sunday      //20
        }

        static void Main(string[] args)
        {
            Days myFavDay = Days.Saturday;

            //(int)myFavDay
            Console.WriteLine((int)myFavDay);
        }
    }
}