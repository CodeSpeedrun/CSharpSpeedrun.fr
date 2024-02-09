/* How to use the KeyValuePair struct?
The KeyValuePair gives more flexibility when iterating a Dictionary because it provides many useful properties. foreach (KeyValuePair item in stockTracker)

*/
 using System;
using System.Collections.Generic;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> stockTracker = new Dictionary<string, int>();

            stockTracker.Add("shampoo", 21);
            stockTracker.Add("pen", 65);

            foreach (KeyValuePair<string, int> item in stockTracker)
            {
                Console.WriteLine(item.Key + " => " + item.Value + " in stock.");
            }
        }
    }
}
//shampoo => 21 in stock.
//pen => 65 in stock.