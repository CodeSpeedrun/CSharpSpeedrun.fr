Calling Async Methods from Non-async Methods

The first is to simply use the Result property on the Task<T> or Wait on Task/Task<T> methods.
(Remember that a method that returns a value must return Task<T> when async, and a method without a
return value returns Task when async). If the method fails, an AggregateException is returned.
You can also call GetAwaiter().GetResult(), which accomplishes the same thing as the await
keyword in an async method and propagates exceptions the same manner as aync/await. However, these
methods are marked in the documentation as “not for external use,”


or example, you could call the DoWorkAsync() method like this:
Console.WriteLine(DoWorkAsync().Result);
Console.WriteLine(DoWorkAsync().GetAwaiter().GetResult());
To halt execution until an async method returns with a void return type, simply call Wait() on the Task,
like this:
MethodReturningVoidAsync().Wait();

