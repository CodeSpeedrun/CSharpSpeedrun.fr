Building a Custom Metadata Viewer

// Display method names of type.
static void ListMethods(Type t)
{
Console.WriteLine("***** Methods *****");
MethodInfo[] mi = t.GetMethods();
foreach(MethodInfo m in mi)
{
Console.WriteLine("->{0}", m.Name);
}
Console.WriteLine();
}

using System.Linq;
static void ListMethods(Type t)
{
Console.WriteLine("***** Methods *****");
var methodNames = from n in t.GetMethods() select n.Name;
foreach (var name in methodNames)
{
Console.WriteLine("->{0}", name);
}
Console.WriteLine();
}


// Display property names of type.
static void ListProps(Type t)
{
Console.WriteLine("***** Properties *****");
var propNames = from p in t.GetProperties() select p.Name;
foreach (var name in propNames)
{
Console.WriteLine("->{0}", name);
}
Console.WriteLine();
}

// Just for good measure.
static void ListVariousStats(Type t)
{
Console.WriteLine("***** Various Statistics *****");
Console.WriteLine("Base class is: {0}", t.BaseType);
Console.WriteLine("Is type abstract? {0}", t.IsAbstract);
Console.WriteLine("Is type sealed? {0}", t.IsSealed);
Console.WriteLine("Is type generic? {0}", t.IsGenericTypeDefinition);
Console.WriteLine("Is type a class type? {0}", t.IsClass);
Console.WriteLine();
}


