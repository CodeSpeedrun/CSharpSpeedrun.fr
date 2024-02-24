The Role of the Parallel Class

System.Threading.Tasks.Parallel. This class contains methods that allow you to
iterate over a collection of data (specifically, an object implementing IEnumerable<T>) in a parallel fashion,
mainly through two primary static methods, Parallel.For() and Parallel.ForEach(),

The benefit is that the Parallel class will pluck threads
from the thread pool (and manage concurrency) on your behalf.

System.Func<T> and System.Action<T> delegates to specify the
target method that will be called to process the data.


Func<T> represents a method that
can have a given return value and a varied number of arguments. The Action<T> delegate is like Func<T>, in
that it allows you to point to a method taking some number of parameters. However, Action<T> specifies a
method that can only return void.

