Limitations of the dynamic Keyword

a dynamic data item cannot make use of lambda expressions
or C# anonymous methods when calling a method.


dynamic a = GetDynamicObject();
// Error! Methods on dynamic data can't use lambdas!
a.Method(arg => Console.WriteLine(arg));


dynamic a = GetDynamicObject();
// Error! Dynamic data can't find the Select() extension method!
var data = from d in a select d;

