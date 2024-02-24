The Internal Representation of LINQ Query Statements
building query expressions using various C# query
operators (such as from, in, where, orderby, and select). Also, you discovered that some functionality of
the LINQ to Objects API can be accessed only when calling extension methods of the Enumerable class. The
truth of the matter, however, is that when LINQ queries are compiled, the C# compiler translates all C# LINQ
operators into calls on methods of the Enumerable class.
A great many of the methods of Enumerable have been prototyped to take delegates as arguments. Many
methods require a generic delegate named Func<>, which was introduced to you during your examination of
generic delegates in Chapter 10. Consider the Where() method of Enumerable, which is called on your behalf
when you use the C# where LINQ query operator.

// Overloaded versions of the Enumerable.Where<T>() method.
// Note the second parameter is of type System.Func<>.
public static IEnumerable<TSource> Where<TSource>(
this IEnumerable<TSource> source,
System.Func<TSource,int,bool> predicate)
public static IEnumerable<TSource> Where<TSource>(
this IEnumerable<TSource> source,
System.Func<TSource,bool> predicate)

The Func<> delegate (as the name implies) represents a pattern for a given function with a set of up to
16 arguments and a return value. If you were to examine this type using the Visual Studio Object Browser,
you would notice various forms of the Func<> delegate. Here’s an example:
// The various formats of the Func<> delegate.
public delegate TResult Func<T1,T2,T3,T4,TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
public delegate TResult Func<T1,T2,T3,TResult>(T1 arg1, T2 arg2, T3 arg3)


