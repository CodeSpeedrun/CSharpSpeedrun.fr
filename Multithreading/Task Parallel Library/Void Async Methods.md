
Void Async Methods

DoWorkAsync() method is returning a Task, which contains “real data” for the caller that
will be obtained transparently via the await keyword.

static async Task MethodReturningTaskOfVoidAsync()
{
await Task.Run(() => { /* Do some work here... */
Thread.Sleep(4_000);
});
Console.WriteLine("Void method completed");
}

static async void MethodReturningVoidAsync()
{
await Task.Run(() => { /* Do some work here... */
Thread.Sleep(4_000);
});
Console.WriteLine("Fire and forget void method completed");
}

