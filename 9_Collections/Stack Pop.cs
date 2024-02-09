/* How to retrieve the latest element in C#?
The Pop() method is used to retrieve the latest element from a Stack. Notice that it retrieves and removes the element from the collection.

*/
 using System;
using System.Collections.Generic;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myFavBooks = new Stack<string>();

            myFavBooks.Push("The Little Prince");
            myFavBooks.Push("Hobbit");
            myFavBooks.Push("One Piece");

            Console.WriteLine("_____BEFORE_____");
            foreach (string book in myFavBooks)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();

            Console.WriteLine("latest book =>" + myFavBooks.Pop());

            Console.WriteLine();
            Console.WriteLine("_____AFTER_____");
            foreach (string book in myFavBooks)
            {
                Console.WriteLine(book);
            }
        }
    }
}
/*
___BEFORE____
One Piece
Hobbit
The Little Prince

latest book =>One Piece

___AFTER ___
Hobbit
The Little Prince
*/