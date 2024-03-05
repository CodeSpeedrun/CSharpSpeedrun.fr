Working with the FileInfo Class

FileInfo Core Members
Member Meaning in Life
AppendText() Creates a StreamWriter object (described later) that appends text to a file
CopyTo() Copies an existing file to a new file
Create() Creates a new file and returns a FileStream object (described later) to interact with the
newly created file
CreateText() Creates a StreamWriter object that writes a new text file
Delete() Deletes the file to which a FileInfo instance is bound
Directory Gets an instance of the parent directory
DirectoryName Gets the full path to the parent directory
Length Gets the size of the current file
MoveTo() Moves a specified file to a new location, providing the option to specify a new filename
Name Gets the name of the file
Open() Opens a file with various read/write and sharing privileges
OpenRead() Creates a read-only FileStream object
OpenText() Creates a StreamReader object (described later) that reads from an existing text file
OpenWrite() Creates a write-only FileStream object


One way you can create a file
handle is to use the FileInfo.Create() method, like so:
using System;
using System.IO;
Console.WriteLine("***** Simple IO with the File Type *****\n");
//Change to a folder on your machine that you have read/write access to, or run as
administrator
var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}temp{Path.
DirectorySeparatorChar}Test.dat";
// Make a new file on the C drive.
FileInfo f = new FileInfo(fileName);
FileStream fs = f.Create();
// Use the FileStream object...
// Close down file stream.
fs.Close();


var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Test.dat";
...
//wrap the file stream in a using statement
// Defining a using scope for file I/O
FileInfo f1 = new FileInfo(fileName);
using (FileStream fs1 = f1.Create())
{
// Use the FileStream object...
}
f1.Delete();


The FileInfo.Open() Method
var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Test.dat";
...
// Make a new file via FileInfo.Open().
FileInfo f2 = new FileInfo(fileName);
using(FileStream fs2 = f2.Open(FileMode.OpenOrCreate,
FileAccess.ReadWrite, FileShare.None))
{
// Use the FileStream object...
}
f2.Delete();


Members of the FileMode Enumeration
Member Meaning in Life
CreateNew Informs the OS to make a new file. If it already exists, an IOException is thrown.
Create Informs the OS to make a new file. If it already exists, it will be overwritten.
Open Opens an existing file. If the file does not exist, a FileNotFoundException is thrown.
OpenOrCreate Opens the file if it exists; otherwise, a new file is created.
Truncate Opens an existing file and truncates the file to 0 bytes in size.
Append Opens a file, moves to the end of the file, and begins write operations (you can use this flag
only with a write-only stream). If the file does not exist, a new file is created.




The FileInfo.OpenRead() and FileInfo.OpenWrite() Methods

f3.Create().Close();
Here are the full examples:
var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Test.dat";
...
// Get a FileStream object with read-only permissions.
FileInfo f3 = new FileInfo(fileName);
//File must exist before using OpenRead
f3.Create().Close();
using(FileStream readOnlyStream = f3.OpenRead())
{
// Use the FileStream object...
}
f3.Delete();
// Now get a FileStream object with write-only permissions.
FileInfo f4 = new FileInfo(fileName);