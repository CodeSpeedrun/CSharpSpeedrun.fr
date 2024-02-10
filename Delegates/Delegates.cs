
/* What are delegates?
Delegate allows passing a function as a parameter. It is also used when workng with callback functions and events.
The delegate defines the method signature.

Delegate workflow
Declare a delegate
Bind methods
Call the delegate
*/
using System;
namespace CSharpSpeedrun.
{

public delegate void DemoDelegate(string msg); //declaring a delegate

class Program
{
    static void Main(string[] args)
    {
        DemoDelegate d = Greetings;
        d("Good morning");
 
        d = (string txt) => Console.WriteLine("lambda expression: " + txt);
        d("Good morning");
    }
 
    public static void Greetings(string txt)
    {
        Console.WriteLine("Called ClassA.MethodA() with parameter: " + txt);
    }
}
 

}
/*
  
*/