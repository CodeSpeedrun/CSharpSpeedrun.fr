Synchronization Using the C# lock Keyword

to define a scope of statements that must be synchronized between threads. By doing
so, incoming threads cannot interrupt the current thread, thus preventing it from finishing its work

private void SomePrivateMethod()
{
// Use the current object as the thread token.
lock(this)
{
// All code within this scope is thread safe.
}
}
However, if you are locking down a region of code within a public member, it is safer (and a best
practice) to declare a private object member variable to serve as the lock token, like so:
public class Printer
{
// Lock token.
private object threadLock = new object();
public void PrintNumbers()
{
// Use the lock token.
lock (threadLock)
{
...


public void PrintNumbers()
{
// Use the private object lock token.
lock (threadLock)
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

Once a thread enters into a lock scope, the lock token (in this case, a reference to the current object)
is inaccessible by other threads until the lock is released after the lock scope has exited.



