Watching Files Programmatically

public enum NotifyFilters
{
Attributes, CreationTime,
DirectoryName, FileName,
LastAccess, LastWrite,
Security, Size
}

// The FileSystemEventHandler delegate must point
// to methods matching the following signature.
void MyNotificationHandler(object source, FileSystemEventArgs e)
You can also handle the Renamed event using the RenamedEventHandler delegate type, which can call
methods that match the following signature:
// The RenamedEventHandler delegate must point
// to methods matching the following signature.
void MyRenamedHandler(object source, RenamedEventArgs e)


using System;
using System.IO;
Console.WriteLine("***** The Amazing File Watcher App *****\n");
// Establish the path to the directory to watch.
FileSystemWatcher watcher = new FileSystemWatcher();
try
{
watcher.Path = @".";
}
catch(ArgumentException ex)
{
Console.WriteLine(ex.Message);
return;
}
// Set up the things to be on the lookout for.
watcher.NotifyFilter = NotifyFilters.LastAccess
| NotifyFilters.LastWrite
| NotifyFilters.FileName
| NotifyFilters.DirectoryName;
// Only watch text files.
watcher.Filter = "*.txt";
// Add event handlers.
// Specify what is done when a file is changed, created, or deleted.
watcher.Changed += (s, e) =>
Console.WriteLine($"File: {e.FullPath} {e.ChangeType}!");
watcher.Created += (s, e) =>
Console.WriteLine($"File: {e.FullPath} {e.ChangeType}!");
watcher.Deleted += (s, e) =>
Console.WriteLine($"File: {e.FullPath} {e.ChangeType}!");
// Specify what is done when a file is renamed.
watcher.Renamed += (s, e) =>
Console.WriteLine($"File: {e.OldFullPath} renamed to {e.FullPath}");
// Begin watching the directory.
watcher.EnableRaisingEvents = true;
// Wait for the user to quit the program.
Console.WriteLine(@"Press 'q' to quit app.");
// Raise some events.
using (var sw = File.CreateText("Test.txt"))
{
sw.Write("This is some text");
}
File.Move("Test.txt","Test2.txt");
File.Delete("Test2.txt");
while(Console.Read()!='q');

