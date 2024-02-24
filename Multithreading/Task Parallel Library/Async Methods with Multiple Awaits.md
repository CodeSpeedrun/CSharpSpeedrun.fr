Async Methods with Multiple Awaits

static async Task MultipleAwaits()
{
await Task.Run(() => { Thread.Sleep(2_000); });
Console.WriteLine("Done with first task!");
await Task.Run(() => { Thread.Sleep(2_000); });
Console.WriteLine("Done with second task!");
await Task.Run(() => { Thread.Sleep(2_000); });
Console.WriteLine("Done with third task!");
}


Again, here each task is not doing much more than suspending the current thread for a spell; however,
any unit of work could be represented by these tasks (calling a web service, reading a database, etc.).
Another option is to not await each task but await them all together. This is a more likely scenario,
where there are three things (check email, update server, download files) that must be completed in a batch,
but can be done in parallel. Here is the code updated using the Task.WhenAll() method:
static async Task MultipleAwaits()
{
var task1 = Task.Run(() =>
{
Thread.Sleep(2_000);
Console.WriteLine("Done with first task!");
});
var task2=Task.Run(() =>
{
Thread.Sleep(1_000);
Console.WriteLine("Done with second task!");
});
var task3 = Task.Run(() =>
{
Thread.Sleep(1_000);
Console.WriteLine("Done with third task!");
});
await Task.WhenAll(task1,task2,task3);
}

There is also a WhenAny(), which returns the task that completed. To demonstrate WhenAny(), change
the last line of the MultipleAwaits to this:
await Task.WhenAny(task1,task2,task3);



