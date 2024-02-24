Synchronization Using the System.Threading.Interlocked Type

a type that
allows you to operate on a single point of data atomically with less overhead than with the Monitor type. The
Interlocked class defines the key static members shown in Table 15-4.
Table 15-4. Select Static Members of the System.Threading.Interlocked Type
Member Meaning in Life
CompareExchange() Safely tests two values for equality and, if equal, exchanges one of the values with a third
Decrement() Safely decrements a value by 1
Exchange() Safely swaps two values

int intVal = 5;
object myLockToken = new();
lock(myLockToken)
{
intVal++;
}

you can simplify your code via the static Interlocked.Increment() method. Simply pass in the variable to
increment by reference. Do note that the Increment() method not only adjusts the value of the incoming
parameter but also returns the new value.
intVal = Interlocked.Increment(ref intVal);


For example, if you want to assign the value of a member variable to the
value 83, you can avoid the need to use an explicit lock statement (or explicit Monitor logic) and use the
Interlocked.Exchange() method, like so:
Interlocked.Exchange(ref myInt, 83);

public void CompareAndExchange()
{
// If the value of i is currently 83, change i to 99.
Interlocked.CompareExchange(ref i, 99, 83);
}


