LINQ and Extension Methods
LINQ query expressions can be used to iterate over data
containers that implement the generic IEnumerable<T> interface

However, the System.Array class type
(used to represent the array of strings and array of integers) does not implement this contract.
// The System.Array type does not seem to implement the
// correct infrastructure for query expressions!
public abstract class Array : ICloneable, IList,
IStructuralComparable, IStructuralEquatable
{

While System.Array does not directly implement the IEnumerable<T> interface, it indirectly gains the
required functionality of this type (as well as many other LINQ-centric members) via the static System.
Linq.Enumerable class type.
This utility class defines a good number of generic extension methods (such as Aggregate<T>(),
First<T>(), Max<T>(), etc.), which System.Array (and other types) acquires in the background. Thus, if you
apply the dot operator on the currentVideoGames local variable, you will find a good number of members
not found within the formal definition of System.Array.