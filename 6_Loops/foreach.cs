/* What is a foreach loop?
The foreach loop is one of the most popular loop variations available in C#. It is a simplified version of the for loop, consequently, we’ll be using it in most of our code snippets.
*/
 using System;

namespace CSharpSpeedrun.com
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFavFruits = { "Apple", "Grape", "Banana" };

            foreach (string fruit in myFavFruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}

/* 
Apple
Grape
Banana 
*/