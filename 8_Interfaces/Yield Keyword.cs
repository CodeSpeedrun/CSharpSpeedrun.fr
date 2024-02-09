/*What is the Yield Keyword?
The return type of yield keyword always returns an IEnumerable object.
*/ 
using System;
using System.Collections.Generic;


namespace CSharpSpeedrun
{
    class Program
    {
       static void Main(string[] args)
       {
          foreach (int i in Fibonacci(7))
          {
             Console.WriteLine(i);
          } 
       }
 
       public static  IEnumerable<int>  Fibonacci(int range)  
        {  
            int number1 = 0, number2 = 1, result = 0;  
            Console.WriteLine(number1);  
            Console.WriteLine(number2);  
            for (int i = 2; i < range; i++)  
            {  
                result = number1 + number2;  
                yield return result;  
                number1 = number2;  
                number2 = result;  
            }  
        }  
    }
}
/*
0
1
1
2
3
5
8
*/