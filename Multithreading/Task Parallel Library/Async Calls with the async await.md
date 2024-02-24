Async Calls with the async/await

when you use the new async and await keywords, the compiler will generate a good deal of
threading code on your behalf, using numerous members of the System.Threading and System.Threading.
Tasks namespaces.


with the async modifier, the .NET Core Runtime will create a new thread of execution to handle the task at
hand.

when you are calling an async method, the await keyword will automatically pause the
current thread from any further activity until the task is complete, leaving the calling thread free to continue.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
Console.WriteLine(" Fun With Async ===>");
Console.WriteLine(DoWork());
Console.WriteLine("Completed");
Console.ReadLine();
static string DoWork()
{
Thread.Sleep(5_000);
return "Done with work!";
}

string message = await DoWorkAsync();
Console.WriteLine(message);
...
static string DoWork()
{
Thread.Sleep(5_000);
return "Done with work!";
}
static async Task<string> DoWorkAsync()
{
return await Task.Run(() =>
{
Thread.Sleep(5_000);
return "Done with work!";
});
}


static async Task Main(string[] args)
{
...
string message = await DoWorkAsync();
Console.WriteLine(message);
...
}


Notice the await keyword before naming the method that will be called in an asynchronous manner.
This is important: if you decorate a method with the async keyword but do not have at least one internal
await-centric method call, you have essentially built a synchronous method call (in fact, you will be given a
compiler warning to this effect).

The implementation of DoWorkAsync() now directly returns a Task<T> object, which is the return value
of Task.Run(). The Run() method takes a Func<> or Action<> delegate, and as you know by this point in the
text, you can simplify your life by using a lambda expression. Basically, your new version of DoWorkAsync() is
essentially saying the following:
When you call me, I will run a new task. This task will cause the calling thread
to sleep for five seconds, and when it is done, it gives me a string return value.
I will put this string in a new Task<string> object and return it to the caller.

