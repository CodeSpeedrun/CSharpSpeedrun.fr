Reading from a Text File

TextReader Core Members
Member Meaning in Life
Peek() Returns the next available character (expressed as an integer) without changing the
position of the reader. A value of -1 indicates you are at the end of the stream.
Read()
ReadAsync()
Reads data from an input stream.
ReadBlock()
ReadBlockAsync()
Reads a specified maximum number of characters from the current stream and writes
the data to a buffer, beginning at a specified index.
ReadLine()
ReadLineAsync()
Reads a line of characters from the current stream and returns the data as a string (a
null string indicates EOF).
ReadToEnd()
ReadToEndAsync()
Reads all characters from the current position to the end of the stream and returns
them as a single string


Console.WriteLine("***** Fun with StreamWriter / StreamReader *****\n");
...
// Now read data from file.
Console.WriteLine("Here are your thoughts:\n");
using(StreamReader sr = File.OpenText("reminders.txt"))
{
string input = null;
while ((input = sr.ReadLine()) != null)
{
Console.WriteLine (input);
}
}
Console.ReadLine();


