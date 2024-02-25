The System.Type Class

The System.Type class defines members that can be used to examine a type’s metadata, a great number
of which return types from the System.Reflection namespace. For example, Type.GetMethods() returns
an array of MethodInfo objects, Type.GetFields()

GetConstructors()
GetEvents()
GetFields()
GetInterfaces()
GetMembers()
GetMethods()
GetNestedTypes()
GetProperties()
These methods (among others) allow you to obtain an array representing
the items (interface, method, property, etc.) you are interested in. Each
method returns a related array (e.g., GetFields() returns a FieldInfo array,
GetMethods() returns a MethodInfo array, etc.). Be aware that each of these
methods has a singular form (e.g., GetMethod(), GetProperty(), etc.) that
allows you to retrieve a specific item by name, rather than an array of all
related items.
FindMembers() This method returns a MemberInfo array based on search criteria.
GetType() This static method returns a Type instance given a string name.
InvokeMember() This method allows “late binding” for a given item. You’ll learn about late
binding later in this chapter.


You can obtain an instance of the Type class in a variety of ways. However, the one thing you cannot do is
directly create a Type object using the new keyword, as Type is an abstract class.


// Obtain type information using a SportsCar instance.
SportsCar sc = new SportsCar();
Type t = sc.GetType();


// Get the type using typeof.
Type t = typeof(SportsCar);


// Obtain type information using the static Type.GetType() method
// (don't throw an exception if SportsCar cannot be found and ignore case).
Type t = Type.GetType("CarLibrary.SportsCar", false, true);


