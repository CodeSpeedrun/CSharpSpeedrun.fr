Multithreaded,
the original threading namespace that has shipped since .NET 1.0, specifically System.
Threading.


three more recent techniques .NET Core developers
can use to build multithreaded software, specifically the Task Parallel Library (TPL), Parallel LINQ (PLINQ),
and the relatively new (as of C# 6) intrinsic asynchronous keywords of C# (async and await).

While many
.NET Core applications can live happy and productive single-threaded lives, an assembly’s primary thread
(spawned by the runtime when the application’s entry point executes) may create secondary threads of
execution at any time to perform additional units of work.

static void ExtractExecutingThread()
{
// Get the thread currently
// executing this method.
Thread currThread = Thread.CurrentThread;
}

static void ExtractAppDomainHostingThread()
{
// Obtain the AppDomain hosting the current thread.
AppDomain ad = Thread.GetDomain();
}



static void ExtractCurrentThreadExecutionContext()
{
// Obtain the execution context under which the
// current thread is operating.
ExecutionContext ctx =
Thread.CurrentThread.ExecutionContext;
}

