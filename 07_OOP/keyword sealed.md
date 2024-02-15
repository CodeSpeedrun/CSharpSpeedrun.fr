### What is the sealed keyword in C#?

The sealed keyword blocks the inheritance of the class. C# will throw an error when trying to inherit from a sealed class.
```csharp
using System;

namespace CSharpSpeedrun
{
    sealed class Book //parent
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
```