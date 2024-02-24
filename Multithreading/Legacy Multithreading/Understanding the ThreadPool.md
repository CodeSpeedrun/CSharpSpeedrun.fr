Understanding the ThreadPool

is a cost with starting a new thread, so for purposes of efficiency, the thread pool holds onto created (but
inactive) threads until needed.


public static class ThreadPool
{
...
public static bool QueueUserWorkItem(WaitCallback callBack);
public static bool QueueUserWorkItem(WaitCallback callBack,
object state);
}


using System;
using System.Threading;
using ThreadPoolApp;
Console.WriteLine("***** Fun with the .NET Core Runtime Thread Pool *****\n");
Console.WriteLine("Main thread started. ThreadID = {0}",
Thread.CurrentThread.ManagedThreadId);
Printer p = new Printer();
WaitCallback workItem = new WaitCallback(PrintTheNumbers);
// Queue the method ten times.
for (int i = 0; i < 10; i++)
{
ThreadPool.QueueUserWorkItem(workItem, p);
}
Console.WriteLine("All tasks queued");
Console.ReadLine();
static void PrintTheNumbers(object state)
{
Printer task = (Printer)state;
task.PrintNumbers();



Consider these benefits of leveraging
the thread pool:
• The thread pool manages threads efficiently by minimizing the number of threads
that must be created, started, and stopped.
• By using the thread pool, you can focus on your business problem rather than the
application’s threading infrastructure.
However, using manual thread management is preferred in some cases. Here is an example:
• If you require foreground threads or must set the thread priority. Pooled threads are
always background threads with default priority (ThreadPriority.Normal).
• If you require a thread with a fixed identity to abort it, suspend it, or discover it by name.

