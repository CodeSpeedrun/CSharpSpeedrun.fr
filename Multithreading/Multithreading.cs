
/* 
What is Multithreading?

A multithreading application denotes it executes several threads 
in paralell to conduct several tasks. 
For example, the Android operating system can open 
multiple applications like browser, music player and much more. 
Each application is handled by distinct threads.
*/
using System;
using System.Threading;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(app1));
            Thread t2 = new Thread(new ThreadStart(app2));
            t1.Start();
            t2.Start();
        }
        static void app1()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(50);
            }
            Console.WriteLine("app1 ended");
            Console.WriteLine();
        }
        static void app2()
        {
            for (int i = 10; i <= 12; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("app2 ended");
        }
    }
}
/*
1
10
11
12
app2 ended
2
3
app1 ended


In modern ASP.NET Core applications, 
multithreading is still used, 
but it's often abstracted away or managed by 
higher-level constructs such as async/await, 
Task Parallel Library (TPL), or higher-level 
abstractions provided by the framework.

Here's how multithreading is typically handled in ASP.NET Core applications:

1. **Async/Await**:
   - Async/await provides a more modern and 
   easier-to-use mechanism for handling asynchronous operations.
   - It allows you to write asynchronous code that 
   looks like synchronous code, making it easier to understand and maintain.
   - It's the recommended approach for handling I/O-bound 
   operations in ASP.NET Core applications.

2. **Task Parallel Library (TPL)**:
   - TPL provides a set of types and APIs for 
   writing parallel and concurrent code.
   - It includes constructs like `Task` and `Parallel.ForEach` 
   that make it easier to work with multithreading and parallelism.
   - TPL is widely used in ASP.NET Core applications 
   for parallelizing CPU-bound operations.

3. **Higher-level Abstractions**:
   - ASP.NET Core provides higher-level abstractions 
   for managing concurrency, such as `HttpClient`, 
   which is optimized for asynchronous I/O operations.
   - Libraries like Entity Framework Core also support 
   asynchronous database operations, allowing you 
   to perform database queries asynchronously without blocking the main thread.

While the low-level threading approach shown in your code 
is still technically valid, it's less common in modern ASP.NET Core applications 
due to the availability of more modern and 
higher-level concurrency constructs that offer better 
performance, scalability, and maintainability.

*/