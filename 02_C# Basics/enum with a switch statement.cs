/* enum with a switch statement
*/
 
using System;

namespace CSharpSpeedrun 
{
    class Program
    {
        enum Pet
        {
            Dog,
            Cat,
            Bird,
            Donkey
        }

        static void Main(string[] args)
        {
            Pet myFavPet = Pet.Dog;

            switch (myFavPet)
            {
                case Pet.Dog:
                    Console.WriteLine("woof woof");
                    break;
                case Pet.Cat:
                    Console.WriteLine("miaow");
                    break;
                case Pet.Bird:
                    Console.WriteLine("kui kui");
                    break;
                case Pet.Donkey:
                    Console.WriteLine("heee haw");
                    break;
                default:
                    break;
            }

        }
    }
}