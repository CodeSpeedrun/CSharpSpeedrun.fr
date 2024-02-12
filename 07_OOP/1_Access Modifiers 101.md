# Access Modifiers in C#

## Introduction to Access Modifiers

Access modifiers in C# determine the visibility and accessibility of types, members, and nested types within an application. Understanding access modifiers is crucial for encapsulation and controlling the accessibility of various parts of your codebase.

### Public Access Modifier

Public types or type members have no access restrictions. They can be accessed from any part of the application, including objects and derived classes. Public types can also be accessed from external assemblies.

```csharp
public class PublicType
{
    public int PublicMember { get; set; }
}
```

### Private Access Modifier

Private type members or nested types can only be accessed by the class (or structure) that defines them.

```csharp
class PrivateType
{
    private int privateMember;
}
```

### Protected Access Modifier

Protected type members or nested types can be accessed by the defining class and any child class. They are not accessible from outside the inheritance chain.

```csharp
class BaseClass
{
    protected int protectedMember;
}
```

### Internal Access Modifier

Internal types or type members are accessible only within the current assembly. Other assemblies can be explicitly granted permission to see internal items.

```csharp
internal class InternalType
{
    internal int internalMember;
}
```

### Protected Internal Access Modifier

Protected internal type members or nested types are accessible within the defining assembly, by the defining class, and by derived classes both inside and outside of the defining assembly.

```csharp
class BaseClass
{
    protected internal int protectedInternalMember;
}
```

### Private Protected Access Modifier (C# 7.2)

Private protected type members or nested types are accessible within the defining class and by derived classes in the same assembly.

```csharp
class BaseClass
{
    private protected int privateProtectedMember;
}
```

## Class Definitions and Constructors

By default, a class definition is set to internal, and the type's default constructor is set to private.

```csharp
internal class Radio
{
    private Radio() {} // private default constructor
}
```

```csharp
public class Radio
{
    public Radio() {} // public default constructor
}
```

### Note on Nested Types

While it's permissible to apply the private access modifier on nested types, non-nested types must be defined with either public or internal modifiers.

### Example

```csharp
public class Library
{
    private class Book
    {
        public int numberOfPages;
    }

    public void CheckOutBook()
    {
        Book miniNovel = new Book();
        miniNovel.numberOfPages = 30000000; // Setting number of pages for a book
    }
}
```

In the above example, `numberOfPages` is accessed within the `Library` class, demonstrating encapsulation and access control.

 