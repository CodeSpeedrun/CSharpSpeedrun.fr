encapsulation. This trait boils down to the language’s ability to hide
unnecessary implementation details from the object user.

For example, assume you are using a class named
DatabaseReader, which has two primary methods, named Open() and Close().

Closely related to the notion of encapsulating programming logic is the idea of data protection. Ideally,
an object’s state data should be specified using either the private, internal, or protected keyword. In this
way, the outside world must ask politely in order to change or obtain the underlying value. This is a good
thing, as publicly declared data points can easily become corrupted

// A class with a single public field.
class Book
{
public int numberOfPages;
}
Book miniNovel = new Book();
miniNovel.numberOfPages = 30_000_000;

As you can see, public fields do not
provide a way to trap logical upper (or lower) limits.

Rather than defining
public fields (which can easily foster data corruption), you should get in the habit of defining private data,
which is indirectly manipulated using one of two main techniques.

a well-encapsulated class should protect its data
and hide the details of how it operates from the prying eyes of the outside world. This is often termed blackbox
programming. The beauty of this approach is that an object is free to change how a given method is
implemented under the hood.


using one of two main techniques.
• You can define a pair of public accessor (get) and mutator (set) methods.
• You can define a public property.