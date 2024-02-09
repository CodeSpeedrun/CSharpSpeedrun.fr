/* How to iterate a Queue<T>?
The Queue<T> also implements the IEnumerable interface, consequently, we can use the foreach loop to iterate its content.
*/
using System;
using System.Collections.Generic;

namespace CSharpSpeedrun 
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<String> customers = new Queue<String>();

            customers.Enqueue("Mark");
            customers.Enqueue("Pooja");
            customers.Enqueue("Warren");

            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
/*
Mark
Pooja
Warren
  */