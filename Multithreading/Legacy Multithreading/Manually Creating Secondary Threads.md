Manually Creating Secondary Threads

using the types of the System.Threading namespace:
1. Create a method to be the entry point for the new thread.
2. Create a new ParameterizedThreadStart (or ThreadStart) delegate, passing the
address of the method defined in step 1 to the constructor.
3. Create a Thread object, passing the ParameterizedThreadStart/ThreadStart
delegate as a constructor argument.
4. Establish any initial thread characteristics (name, priority, etc.).
5. Call the Thread.Start() method. This starts the thread at the method referenced
by the delegate created in step 2 as soon as possible.


The limitation of ThreadStart is that you are unable to pass in parameters for processing. However,
the ParameterizedThreadStart delegate type allows a single parameter of type System.Object. Given that
anything can be represented as a System.Object, you can pass in any number of parameters via a custom
class or structure. Do note, however, that the ThreadStart and ParameterizedThreadStart delegates can
only point to methods that return void.

