The Problem of Concurrency
you have little control
over how the underlying operating system or the runtime uses its threads. For example, if you craft a block
of code that creates a new thread of execution, you cannot guarantee that the thread executes immediately.

given that threads can be moved between application and contextual boundaries as
required by the runtime, you must be mindful of which aspects of your application are thread-volatile
(e.g., subject to multithreaded access) and which operations are atomic

assume a thread is invoking a method of a specific object. Now assume that
this thread is instructed by the thread scheduler to suspend its activity to allow another thread to access the
same method of the same object.
If the original thread was not finished with its operation, the second incoming thread may be viewing
an object in a partially modified state. At this point, the second thread is basically reading bogus data, which
is sure to give way to extremely odd (and hard to find) bugs, which are even harder to replicate and debug.

