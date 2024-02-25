Reflecting on Method Parameters and Return Values

static void ListMethods(Type t)
{
Console.WriteLine("***** Methods *****");
MethodInfo[] mi = t.GetMethods();
foreach (MethodInfo m in mi)
{
// Get return type.
string retVal = m.ReturnType.FullName;
string paramInfo = "( ";
// Get params.
foreach (ParameterInfo pi in m.GetParameters())
{
paramInfo += string.Format("{0} {1} ", pi.ParameterType, pi.Name);
}
paramInfo += " )";
// Now display the basic method sig.
Console.WriteLine("->{0} {1} {2}", retVal, m.Name, paramInfo);
}
Console.WriteLine();
}

static void ListMethods(Type t)
{
Console.WriteLine("***** Methods *****");
var methodNames = from n in t.GetMethods() select n;
foreach (var name in methodNames)
{
Console.WriteLine("->{0}", name);
}
Console.WriteLine();

