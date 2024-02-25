Dynamically Loading Assemblies

There will be times when you need to load assemblies on the fly programmatically, even if there is no record
of said assembly in the manifest.

using System;
using System.Reflection;
using System.IO; // For FileNotFoundException definition.
Console.WriteLine("***** External Assembly Viewer *****");
string asmName = "";
Assembly asm = null;
do
{
Console.WriteLine("\nEnter an assembly to evaluate");
Console.Write("or enter Q to quit: ");
// Get name of assembly.
asmName = Console.ReadLine();
// Does user want to quit?
if (asmName.Equals("Q",StringComparison.OrdinalIgnoreCase))
{
break;
}
// Try to load assembly.
try
{
asm = Assembly.LoadFrom(asmName);
DisplayTypesInAsm(asm);
}
catch
{
Console.WriteLine("Sorry, can't find assembly.");
}
} while (true);
static void DisplayTypesInAsm(Assembly asm)
{
Console.WriteLine("\n***** Types in Assembly *****");
Console.WriteLine("->{0}", asm.FullName);
Type[] types = asm.GetTypes();
foreach (Type t in types)
{
Console.WriteLine("Type: {0}", t);
}
Console.WriteLine("");





using System;
using System.Linq;
using System.Reflection;
Console.WriteLine("***** The Framework Assembly Reflector App *****\n");
// Load Microsoft.EntityFrameworkCore.dll
var displayName =
"Microsoft.EntityFrameworkCore, Version=5.0.0.0, Culture=\"\", PublicKeyToken=adb9793829d
dae60";
Assembly asm = Assembly.Load(displayName);
DisplayInfo(asm);
Console.WriteLine("Done!");
Console.ReadLine();
private static void DisplayInfo(Assembly a)
{
Console.WriteLine("***** Info about Assembly *****");
Console.WriteLine($"Asm Name: {a.GetName().Name}" );
Console.WriteLine($"Asm Version: {a.GetName().Version}");
Console.WriteLine($"Asm Culture:
{a.GetName().CultureInfo.DisplayName}");
Console.WriteLine("\nHere are the public enums:");
// Use a LINQ query to find the public enums.
Type[] types = a.GetTypes();
var publicEnums =
from pe in types
where pe.IsEnum && pe.IsPublic
select pe;
foreach (var pe in publicEnums)
{
Console.WriteLine(pe);



