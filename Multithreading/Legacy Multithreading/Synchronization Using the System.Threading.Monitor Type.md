Synchronization Using the System.Threading.Monitor Type

The C# lock statement is a shorthand notation for working with the System.Threading.Monitor class.

public void PrintNumbers()
{
Monitor.Enter(threadLock);
try
{
// Display Thread info.
Console.WriteLine("-> {0} is executing PrintNumbers()",
Thread.CurrentThread.Name);
// Print out numbers.
Console.Write("Your numbers: ");
for (int i = 0; i < 10; i++)
{
Random r = new Random();
Thread.Sleep(1000 * r.Next(5));
Console.Write("{0}, ", i);
}
Console.WriteLine();
}
finally
{
Monitor.Exit(threadLock);

benefits of using the Monitor type directly. The short
answer is control.

