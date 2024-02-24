Foreground Threads and Background Threads

Foreground threads can prevent the current application from terminating. The .NET
Core Runtime will not shut down an application (which is to say, unload the hosting
AppDomain) until all foreground threads have ended.
• Background threads (sometimes called daemon threads) are viewed by the .NET
Core Runtime as expendable paths of execution that can be ignored at any point
in time

Console.WriteLine("***** Background Threads *****\n");
Printer p = new Printer();
Thread bgroundThread =
new Thread(new ThreadStart(p.PrintNumbers));
// This is now a background thread.
bgroundThread.IsBackground = true;
bgroundThread.Start();


