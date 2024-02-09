/* What is a Tuple?
A tuple is a data structure that stores data of different data types. It is mostly used to return multiple values from a method. Above all, Tuple can pass multiple values to a method through a single parameter.
*/
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main()
        {
            static void Main(string[] args)
            {
                Console.WriteLine(GetEmployeeDetails());
            }

            static Tuple<int, string, string> GetEmployeeDetails()
            {
                return Tuple.Create(152, "John", "Dow");
            }
        }
    }
}
  
using System;

namespace CSharpSpeedrun
{
    class Program
    {

        static void Main()
        {
            var player = Tuple.Create(190, "Marylyn", "Banners");
            DisplayPlayers(player);
        }

        static void DisplayPlayers(Tuple<int, string, string> player)
        {
            Console.WriteLine(player.Item1);
            Console.WriteLine(player.Item2);
            Console.WriteLine(player.Item3);
        }
    }
}
/*
  
*/