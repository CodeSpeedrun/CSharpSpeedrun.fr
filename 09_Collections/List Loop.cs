/* How to iterate using foreach loop in C#?
Since the List collection class implements the IEnumerable interface, we are allowed to use the foreach loop to iterate its content.
*/
 using System;
using System.Collections.Generic;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> popularGames = new List<string>()
            {
                "baseball",
                "Scrabble"
            };

            List<string> myFavGames = new List<string>();
            myFavGames.Add("golf");
            myFavGames.Add("chess");
            myFavGames.Add("poker");

            myFavGames.AddRange(popularGames);

            foreach (string game in myFavGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}