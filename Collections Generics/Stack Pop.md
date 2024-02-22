```csharp
using System;
using System.Collections.Generic;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myFavBooks = new Stack<string>();

            myFavBooks.Push("Le Petit Prince");
            myFavBooks.Push("Le Hobbit");
            myFavBooks.Push("One Piece");

            Console.WriteLine("_____AVANT_____");
            foreach (string livre in myFavBooks)
            {
                Console.WriteLine(livre);
            }
            Console.WriteLine();

            Console.WriteLine("Dernier livre => " + myFavBooks.Pop());

            Console.WriteLine();
            Console.WriteLine("_____APRÈS_____");
            foreach (string livre in myFavBooks)
            {
                Console.WriteLine(livre);
            }
        }
    }
}
/*
___AVANT____
One Piece
Le Hobbit
Le Petit Prince

Dernier livre => One Piece

___APRÈS___
Le Hobbit
Le Petit Prince
*/
```  