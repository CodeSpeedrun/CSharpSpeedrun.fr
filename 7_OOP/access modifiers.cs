/* What access modifiers are available in C#?
public	Public means it is accessible for all classes in the application.
private	Private denotes that it is only accessible within the same class or the compiler will throw an error.
protected	Protected means it is accessible within the same class, or through inheritance.
internal	This one is used to make code accessible only within its own assembly.
*/
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main()
        {
             Book myBook = new Book();
             Console.WriteLine(myBook.id);
        }
    }
 
    class Book
    {
        public int id = 523;
        private string title = "Harry Potter"; 
    }
}
//523