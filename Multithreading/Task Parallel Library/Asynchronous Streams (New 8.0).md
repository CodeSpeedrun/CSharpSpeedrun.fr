Asynchronous Streams (New 8.0)

A method
that returns an asynchronous stream
• Is declared with the async modifier
• Returns an IAsyncEnumerable<T>
• Contains yield return statements (covered in Chapter 8) to return successive
elements in the asynchronous stream

public static async IAsyncEnumerable<int> GenerateSequence()
{
for (int i = 0; i < 20; i++)
{

await Task.Delay(100);
yield return i;
}
}

The method is declared as async, returns an IAsyncEnumerable<int>, and uses the yield return to
return integers in from a sequence. To call this method, add the following to your calling code:
await foreach (var number in GenerateSequence())
{
Console.WriteLine(number);
}

