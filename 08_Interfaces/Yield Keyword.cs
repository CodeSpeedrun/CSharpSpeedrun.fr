/*
What is the Yield Keyword?
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

        public static IEnumerable<int> Fibonacci(int range)
        {
            int number1 = 0, number2 = 1, result = 0;
            Console.WriteLine(number1); //print 0,1
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
 

The reason the Fibonacci method appears to be "going in and out of the method" 
is due to its use of the `yield return` statement. 

In C#, when you use `yield return` in a method, 
you're indicating that the method is an iterator, 
and it will produce a sequence of values lazily as requested. 
Each time you call `yield return`, it produces one value 
in the sequence and then temporarily suspends the method's execution, 
returning control to the caller.

Here's how it works in your Fibonacci method:

1. The method starts executing when called in the `foreach` loop in the `Main` method.
2. It calculates the next Fibonacci number (`result`) and `yield return` it.
3. The control returns to the caller (`Main` method), and 
the next iteration of the `foreach` loop continues from where it left off.
4. The `Main` method prints the yielded value (`i`) and 
then calls the Fibonacci method again.
5. The Fibonacci method continues execution from where it was suspended, 
and the process repeats until the loop terminates.

So, each time you iterate over the `Fibonacci` method using `foreach`, 
it calculates the next Fibonacci number and yields it back to the caller, 
allowing the caller to process the value before proceeding to the next iteration. 
This lazy evaluation is why it seems like the method is "going in and out" of the loop.

*/