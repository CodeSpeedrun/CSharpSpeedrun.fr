encapsulation, you must always consider which aspects of a type are visible to various
parts of your application.

public Types or type
members
Public items have no access restrictions. A public member can be
accessed from an object, as well as any derived class. A public type
can be accessed from other external assemblies.
private Type members or
nested types
Private items can be accessed only by the class (or structure) that
defines the item.
protected Type members or
nested types
Protected items can be used by the class that defines it and any child
class. They cannot be accessed from outside the inheritance chain.
internal Types or type
members
Internal items are accessible only within the current assembly.
Other assemblies can be explicitly granted permission to see the
internal items.
protected
internal
Type members or
nested types
When the protected and internal keywords are combined on an
item, the item is accessible within the defining assembly, within
the defining class, and by derived classes inside or outside of the
defining assembly.
private
protected
(new 7.2)
Type members or
nested types
When the private and protected keywords are combined on an
item, the item is accessible within the defining class and by derived
classes in the same assembly.

class definition is automatically set to internal, while the type’s default constructor is automatically set to
private

// An internal class with a private default constructor.
class Radio
{
Radio(){}
}

// An internal class with a private default constructor.
internal class Radio
{
private Radio(){}
}

// A public class with a public default constructor.
public class Radio
{
public Radio(){}
}

Here, it is permissible to apply the private access modifier on the nested type. However, non-nested
types (such as the SportsCar) can be defined only with the public or internal modifier.

miniNovel.numberOfPages = 30_000_000;