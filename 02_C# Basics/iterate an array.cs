/* iterate an array
*/
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFavFlowers = { "Rose", "Lily", "Tulip", "Orchid" };

            foreach (string element in myFavFlowers)
            {
                Console.WriteLine(element);
            }
        }
    }
}
Array.Sort(myFavFlowers);
Array.Reverse(myFavFlowers);