Working with the File Type

var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Test.dat";
...
//Using File instead of FileInfo
using (FileStream fs8 = File.Create(fileName))
{
// Use the FileStream object...
}
File.Delete(fileName);
// Make a new file via FileInfo.Open().
using(FileStream fs9 = File.Open(fileName,
FileMode.OpenOrCreate, FileAccess.ReadWrite,
FileShare.None))
{
// Use the FileStream object...
}
// Get a FileStream object with read-only permissions.
using(FileStream readOnlyStream = File.OpenRead(fileName))
{}
File.Delete(fileName);
// Get a FileStream object with write-only permissions.
using(FileStream writeOnlyStream = File.OpenWrite(fileName))
{}
// Get a StreamReader object.
using(StreamReader sreader = File.OpenText(fileName))
{}
File.Delete(fileName);
// Get some StreamWriters.
using(StreamWriter swriter = File.CreateText(fileName))
{}
File.Delete(fileName);
using(StreamWriter swriterAppend =
File.AppendText(fileName))
{}
File.Delete(fileName);





Console.WriteLine("***** Simple I/O with the File Type *****\n");
string[] myTasks = {
"Fix bathroom sink", "Call Dave",
"Call Mom and Dad", "Play Xbox One"};
// Write out all data to file on C drive.
File.WriteAllLines(@"tasks.txt", myTasks);
// Read it all back and print out.
foreach (string task in File.ReadAllLines(@"tasks.txt"))
{
Console.WriteLine("TODO: {0}", task);
}
Console.ReadLine();
File.Delete("tasks.txt");



