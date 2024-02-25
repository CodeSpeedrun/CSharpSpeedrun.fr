Calling Members on Dynamically Declared Data

the validity of the members you specify will not be checked
by the compiler! Remember, unlike a variable defined as a System.Object, dynamic data is not statically
typed. It is not until runtime that you will know whether the dynamic data you invoked supports a specified
member, whether you passed in the correct parameters,


static void InvokeMembersOnDynamicData()
{
dynamic textData1 = "Hello";
Console.WriteLine(textData1.ToUpper());
// You would expect compiler errors here!
// But they compile just fine.
Console.WriteLine(textData1.toupper());
Console.WriteLine(textData1.Foo(10, "ee", DateTime.Now));
}

IntelliSense is not possible with dynamic data. However, remember that
this means you need to be extremely careful when you are typing C# code on such data points. Any
misspelling or incorrect capitalization of a member will throw a runtime error, specifically an instance of the
RuntimeBinderException clas

