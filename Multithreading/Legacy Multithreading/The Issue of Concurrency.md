The Issue of Concurrency

ensure that any piece of shared data
is protected against the possibility of numerous threads changing its value.

As the thread scheduler will force threads to
suspend their work at random, what if thread A is kicked out of the way before it has fully completed its
work? Thread B is now reading unstable data.

using System;
using System.Threading;
namespace MultiThreadedPrinting
{
public class Printer
{
public void PrintNumbers()
{
// Display Thread info.
Console.WriteLine("-> {0} is executing PrintNumbers()",
Thread.CurrentThread.Name);
// Print out numbers.
for (int i = 0; i < 10; i++)
{
// Put thread to sleep for a random amount of time.
Random r = new Random();
Thread.Sleep(1000 * r.Next(5));
Console.Write("{0}, ", i);
}
Console.WriteLine();


using System;
using System.Threading;
using MultiThreadedPrinting;
Console.WriteLine("*****Synchronizing Threads *****\n");
Printer p = new Printer();
// Make 10 threads that are all pointing to the same
// method on the same object.
Thread[] threads = new Thread[10];
for (int i = 0; i < 10; i++)
{
threads[i] = new Thread(new ThreadStart(p.PrintNumbers))
{
Name = $"Worker thread #{i}"
};
}
// Now start each one.
foreach (Thread t in threads)
{
t.Start();


have taken no precautions to lock
down this object’s shared resources (the console), there is a good chance that the current thread will be
kicked out of the way before the PrintNumbers() method is able to print the complete results. Because
you do not know exactly when (or if ) this might happen, you are bound to get unpredictable results.

