/* 
What is a Task?
A Task is an asynchronous operation that needs to be done. 
It usually represents a single operation that executes on the thread pool.
*/
using System;
using System.Threading.Tasks;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(app1);
            task1.Start();
            Console.WriteLine("Main thread ended");
        }

        static void app1()
        {
            for (int i = 10; i <= 12; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("app1 thread ended");
        }
    }
}
/*
Main thread ended
10
11
12
app1 thread ended
*/