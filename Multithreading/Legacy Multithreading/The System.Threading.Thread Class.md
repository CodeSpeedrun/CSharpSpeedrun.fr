The System.Threading.Thread Class

Key Static Members of the Thread Type
Static Member Meaning in Life
ExecutionContext This read-only property returns information relevant to the logical thread of execution,
including security, call, synchronization, localization, and transaction contexts.
CurrentThread This read-only property returns a reference to the currently running thread.
Sleep() This method suspends the current thread for a specified time.

Select Instance-Level Members of the Thread Type
Instance-Level
Member
Meaning in Life
IsAlive Returns a Boolean that indicates whether this thread has been started (and has not
yet terminated or aborted).
IsBackground Gets or sets a value indicating whether this thread is a “background thread” (more
details in just a moment).
Name Allows you to establish a friendly text name of the thread.
Priority Gets or sets the priority of a thread, which may be assigned a value from the
ThreadPriority enumeration.
ThreadState Gets the state of this thread, which may be assigned a value from the ThreadState
enumeration.
(

