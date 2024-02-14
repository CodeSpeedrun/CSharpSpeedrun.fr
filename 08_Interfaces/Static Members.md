Static Constructors and Members
interface IRegularPointy : IPointy
{
int SideLength { get; set; }
int NumberOfSides { get; set; }
int Perimeter => SideLength * NumberOfSides;
//Static members are also allowed in C# 8
static string ExampleProperty { get; set; }
static IRegularPointy() => ExampleProperty = "Foo";
}
Static constructors must be parameterless and can only access static properties and methods. To access
the interface static property,

Console.WriteLine($"Example property: {IRegularPointy.ExampleProperty}");
IRegularPointy.ExampleProperty = "Updated";
Console.WriteLine($"Example property: {IRegularPointy.ExampleProperty}");
Notice how the static property must be invoked from the interface and not an instance variable.

