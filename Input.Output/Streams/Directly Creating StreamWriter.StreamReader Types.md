Directly Creating StreamWriter/StreamReader Types

One of the confusing aspects of working with the types within System.IO is that you can often achieve
an identical result using different approaches.


Console.WriteLine("***** Fun with StreamWriter / StreamReader *****\n");
// Get a StreamWriter and write string data.
using(StreamWriter writer = new StreamWriter("reminders.txt"))
{
...
}
// Now read data from file.
using(StreamReader sr = new StreamReader("reminders.txt"))
{
...
}


