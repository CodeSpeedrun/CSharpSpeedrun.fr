
/* What is Multithreading?
A multithreading application denotes it executes several threads in paralell to conduct several tasks. For example, the Android operating system can open multiple applications like browser, music player and much more. Each application is handled by distinct threads.
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
*/