The FileInfo.OpenText() Method

var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Test.dat";
...
// Get a StreamReader object.
//If not on a Windows machine, change the file name accordingly
FileInfo f5 = new FileInfo(fileName);
//File must exist before using OpenText
f5.Create().Close();
using(StreamReader sreader = f5.OpenText())
{
// Use the StreamReader object...
}
f5.Delete();




The FileInfo.CreateText() and FileInfo.AppendText() Methods
var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Test.dat";
...
FileInfo f6 = new FileInfo(fileName);
using(StreamWriter swriter = f6.CreateText())
{
// Use the StreamWriter object...
}
f6.Delete();
FileInfo f7 = new FileInfo(fileName);
using(StreamWriter swriterAppend = f7.AppendText())
{
// Use the StreamWriter object...
}
f7.Delete();



