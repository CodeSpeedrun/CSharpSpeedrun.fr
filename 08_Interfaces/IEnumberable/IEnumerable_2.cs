using System;
using System.Collections.Generic;

namespace CSharpSpeedrun
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> fruitsList = new List<string> { "apple", "banana", "corn", "durian" };
            IEnumerator<string> iterator = fruitsList.GetEnumerator();
            while (iterator.MoveNext())
            {
                string word = iterator.Current;
                Console.WriteLine(word);
            }
        }
    }
}
/*
apple
banana
corn
durian
*/