Exploring the System.IO Namespace

the System.IO namespace is the region of the base class libraries devoted to
file-based (and memory-based) input and output (I/O) services

System.IO defines a
set of classes, interfaces, enumerations, structures, and delegates, most of which you can find in mscorlib

Key Members of the System.IO Namespace
Nonabstract I/O
Class Type
Meaning in Life
BinaryReader
BinaryWriter
These classes allow you to store and retrieve primitive data types (integers,
Booleans, strings, and whatnot) as a binary value.
BufferedStream This class provides temporary storage for a stream of bytes that you can commit
to storage later.
Directory
DirectoryInfo
You use these classes to manipulate a machine’s directory structure. The
Directory type exposes functionality using static members, while the
DirectoryInfo type exposes similar functionality from a valid object reference.
DriveInfo This class provides detailed information regarding the drives that a given
machine uses.
File
FileInfo
You use these classes to manipulate a machine’s set of files. The File type
exposes functionality using static members, while the FileInfo type exposes
similar functionality from a valid object reference.
FileStream This class gives you random file access (e.g., seeking capabilities) with data
represented as a stream of bytes.
FileSystemWatcher This class allows you to monitor the modification of external files in a specified
directory.
MemoryStream This class provides random access to streamed data stored in memory rather
than in a physical file.
Path This class performs operations on System.String types that contain file or
directory path information in a platform-neutral manner.
StreamWriter
StreamReader
You use these classes to store (and retrieve) textual information to (or from) a file.
These types do not support random file access.
StringWriter
StringReader
Like the StreamReader/StreamWriter classes, these classes also work with
textual information. However, the underlying storage is a string buffer rather than
a physical file.


