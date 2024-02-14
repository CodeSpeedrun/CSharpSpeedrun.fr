The IComparable Interface
IComparable interface specifies a behavior that allows an object to be sorted based on some
specified key. Here is the formal definition:
// This interface allows an object to specify its
// relationship between other like objects.
public interface IComparable
{
int CompareTo(object o);
}
