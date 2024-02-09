/* What is an indexer?
Previously we have covered arrays. An indexer allows a class to be indexed and accessed like an array. Similar to a property, an indexer is defined using this keyword and square brackets [].
*/
using System;

namespace CSharpSpeedrun
{
    class Team
    {
        private string[] tempArray = new string[4];

        //indexer
        public string this[int number]
        {
            get { return tempArray[number]; }
            set { tempArray[number] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Team teams = new Team();
            teams[0] = "Chicago Bulls";
            teams[1] = "New York Scavengers";
            teams[2] = "Mumbai Rockstars";
            teams[3] = "Mumbai Rockstars";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(teams[i]);
            }
        }
    }  
}
/*
  
*/