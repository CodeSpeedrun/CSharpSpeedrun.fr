using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Task task1 = App1Async();
        Task task2 = App2Async();

        await Task.WhenAll(task1, task2);

        Console.WriteLine("All tasks completed.");
    }

    static async Task App1Async()
    {
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"App1: {i}");
            await Task.Delay(50); // Simulate asynchronous work
        }
        Console.WriteLine("App1 ended");
    }

    static async Task App2Async()
    {
        for (int i = 10; i <= 12; i++)
        {
            Console.WriteLine($"App2: {i}");
            await Task.Delay(50); // Simulate asynchronous work
        }
        Console.WriteLine("App2 ended");
    }
}

/*
App1: 1
App2: 10
App2: 11
App1: 2
App1: 3
App2: 12
App1 ended
App2 ended
All tasks completed.
 */