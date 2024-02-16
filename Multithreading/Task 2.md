```csharp
using System;
using System.Threading.Tasks;

class Program {
    static void Main(string[] args) {
        Task task1 = Task.Run(() => App1());
        Task task2 = Task.Run(() => App2());

        Task.WaitAll(task1, task2);

        Console.WriteLine("All tasks completed.");
    }

    static void App1() {
        for (int i = 1; i <= 3; i++) {
            Console.WriteLine($"App1: {i}");
            Task.Delay(50).Wait(); // Simulate work
        }
        Console.WriteLine("App1 ended");
    }

    static void App2() {
        for (int i = 10; i <= 12; i++) {
            Console.WriteLine($"App2: {i}");
        }
        Console.WriteLine("App2 ended");
    }
}

/*
App1: 1
App2: 10
App2: 11
App2: 12
App2 ended
App1: 2
App1: 3
App1 ended
All tasks completed.
 */
 ```