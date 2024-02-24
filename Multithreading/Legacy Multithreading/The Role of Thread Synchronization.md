The Role of Thread Synchronization
multithreaded programs are in themselves quite volatile, as numerous
threads can operate on the shared resources at (more or less) the same time.

use any number of threading primitives
(such as locks, monitors, and the [Synchronization] attribute or language keyword support) to control
access among the executing threads.

Using types defined
within the System.Threading namespace, the Task Parallel Library, and the C# async and await language
keywords, you can work with multiple threads with minimal fuss and bother.

the new C# async and await
keywords offer a simpler alternative to asynchronous delegates, it is still important that you know how to
interact with code using this approach (trust me, there is a ton of code in production that uses asynchronous
delegates).

