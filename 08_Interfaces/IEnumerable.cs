/*What is IEnumerable?
The uppercase I in IEnumerable denotes that it is an interface. 
It is mostly used to iterate non-generic collections. 
Above all, the IEnumerable holds the GetEnumerator() method 
which returns an IEnumerator object.

public interface IEnumerable<out T> : IEnumerable {
        IEnumerator<T> GetEnumerator();

public interface IEnumerator {
    bool MoveNext();
    object Current { get; }
    void Reset();
*/
using System;
using System.Collections.Generic;

namespace github.com.CodeSpeedrun.CSharpSpeedrun {
    public class Program {
        static void Main() {
            int[] ballIds = { 51, 7, 83 };
            List<int> batIds = new List<int>() { 12, 29, 27 };

            DisplayIds(ballIds);
            DisplayIds(batIds);
        }

        /*
        IEnumerable indicates that it's a collection that can be enumerated (iterated over).
        <int> specifies the type of elements in the collection, in this case, integers.
        */
        static void DisplayIds(IEnumerable<int> values) {
            foreach (int value in values) {
                Console.WriteLine(value);
            }
        }
    }
}
/*
51
7
83
12
29
27
*/