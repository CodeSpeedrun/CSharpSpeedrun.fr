The Directory(Info) and File(Info) Types

System.IO provides four classes that allow you to manipulate individual files, as well as interact with a
machine’s directory structure. The first two types, Directory and File, expose creation, deletion, copying,
and moving operations using various static members

FileSystemInfo Properties
Property Meaning in Life
Attributes Gets or sets the attributes associated with the current file that are represented by the
FileAttributes enumeration (e.g., is the file or directory read-only, encrypted, hidden,
or compressed?)
CreationTime Gets or sets the time of creation for the current file or directory
Exists Determines whether a given file or directory exists
Extension Retrieves a file’s extension
FullName Gets the full path of the directory or file
LastAccessTime Gets or sets the time the current file or directory was last accessed
LastWriteTime Gets or sets the time when the current file or directory was last written to
Name Obtains the name of the current file or directory


Key Members of the DirectoryInfo Type
Member Meaning in Life
Create()
CreateSubdirectory()
Creates a directory (or set of subdirectories) when given a path name
Delete() Deletes a directory and all its contents
GetDirectories() Returns an array of DirectoryInfo objects that represent all subdirectories in
the current directory
GetFiles() Retrieves an array of FileInfo objects that represent a set of files in the given
directory
MoveTo() Moves a directory and its contents to a new path
Parent Retrieves the parent directory of this directory
Root Gets the root portion of a path

// Bind to the current working directory.
DirectoryInfo dir1 = new DirectoryInfo(".");
// Bind to C:\Windows,
// using a verbatim string.
DirectoryInfo dir2 = new DirectoryInfo(@"C:\Windows");


If you are developing .NET
Core applications for different platforms, you should use the Path.VolumeSeparatorChar and Path.
DirectorySeparatorChar constructs, which will yield the appropriate characters based on the platform.
Update the previous code to the following:
DirectoryInfo dir3 = new DirectoryInfo(
$@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}MyCode{Path.DirectorySeparatorCh
ar}Testing");


using System;
using System.IO;
Console.WriteLine("***** Fun with Directory(Info) *****\n");
ShowWindowsDirectoryInfo();
Console.ReadLine();
static void ShowWindowsDirectoryInfo()
{
// Dump directory information. If you are not on Windows, plug in another directory
DirectoryInfo dir = new DirectoryInfo($@"C{Path.VolumeSeparatorChar}
{Path.DirectorySeparatorChar}Windows");
Console.WriteLine("***** Directory Info *****");
Console.WriteLine("FullName: {0}", dir.FullName);
Console.WriteLine("Name: {0}", dir.Name);
Console.WriteLine("Parent: {0}", dir.Parent);
Console.WriteLine("Creation: {0}", dir.CreationTime);
Console.WriteLine("Attributes: {0}", dir.Attributes);
Console.WriteLine("Root: {0}", dir.Root);
Console.WriteLine("**************************\n");
}


