Working with BinaryWriters and BinaryReaders

BinaryReader and BinaryWriter. Both
derive directly from System.Object. These types allow you to read and write discrete data types to an
underlying stream in a compact binary format. The BinaryWriter class defines a highly overloaded Write()
method to place a data type in the underlying stream.


BinaryWriter Core Members
Member Meaning in Life
BaseStream This read-only property provides access to the underlying stream used with the BinaryWriter
object.
Close() This method closes the binary stream.
Flush() This method flushes the binary stream.
Seek() This method sets the position in the current stream.
Write() This method writes a value to the current stream


BinaryReader Core Members
Member Meaning in Life
BaseStream This read-only property provides access to the underlying stream used with the BinaryReader
object.
Close() This method closes the binary reader.
PeekChar() This method returns the next available character without advancing the position in the
stream.
Read() This method reads a given set of bytes or characters and stores them in the incoming array.
ReadXXXX() The BinaryReader class defines numerous read methods that grab the next type from the
stream (e.g., ReadBoolean(), ReadByte(), and ReadInt32()).


using System;
using System.IO;
Console.WriteLine("***** Fun with Binary Writers / Readers *****\n");
// Open a binary writer for a file.
FileInfo f = new FileInfo("BinFile.dat");
using(BinaryWriter bw = new BinaryWriter(f.OpenWrite()))
{
// Print out the type of BaseStream.
// (System.IO.FileStream in this case).
Console.WriteLine("Base stream is: {0}", bw.BaseStream);
// Create some data to save in the file.
double aDouble = 1234.67;
int anInt = 34567;
string aString = "A, B, C";
// Write the data.
bw.Write(aDouble);
bw.Write(anInt);
bw.Write(aString);
}
Console.WriteLine("Done!");
Console.ReadLine();
Notice how the FileStream


Using this technique makes it easy to layer in a stream before writing out the data.
Note that the constructor of BinaryWriter takes any Stream-derived type (e.g., FileStream, MemoryStream,
or BufferedStream). Thus, writing binary data to memory instead is as simple as supplying a valid
MemoryStream object.


FileInfo f = new FileInfo("BinFile.dat");
...
// Read the binary data from the stream.
using(BinaryReader br = new BinaryReader(f.OpenRead()))
{
Console.WriteLine(br.ReadDouble());
Console.WriteLine(br.ReadInt32());
Console.WriteLine(br.ReadString());
}
Console.ReadLine();


