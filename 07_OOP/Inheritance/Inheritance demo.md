### How to implement inheritance?
- In the code snippet, the title field is required for both Book and EBook classes. 
- Consequently, it is better to add it in the Book class and it will also be accessible from the EBook class. 
- Notice the colon to activate inheritance. EBook: Book

```csharp
using System;

namespace CSharpSpeedrun
{
    class Book //parent
    {
        public string title = "Sapiens"; 
    }

    class EBook: Book //child
    {
        public string format = "Pdf";
    }

    class Program
    {
        static void Main(string[] args)
        {
            EBook myEBook= new EBook();  
            Console.WriteLine(myEBook.title + ", format = " + myEBook.format);
        }
    }
}
//Sapiens, format = Pdf

```