
Building an Extendable Application


What exactly is meant by extendable? Well, consider the Visual Studio IDE. When this application was
developed, various “hooks” were inserted into the code base to allow other software vendors to “snap” (or
plug in) custom modules into the IDE. Obviously, the Visual Studio development team had no way to set


references to external .NET assemblies it had not developed yet (thus, no early binding), so how exactly
would an application provide the required hooks? Here is one possible way to solve this problem:
1. First, an extendable application must provide some input mechanism to allow
the user to specify the module to plug in (such as a dialog box or command-line
flag). This requires dynamic loading.
2. Second, an extendable application must be able to determine whether the
module supports the correct functionality (such as a set of required interfaces) to
be plugged into the environment. This requires reflection.
3. Finally, an extendable application must obtain a reference to the required
infrastructure (such as a set of interface types) and invoke the members to trigger
the underlying functionality. This may require late binding.


CommonSnappableTypes.dll: This assembly contains type definitions that will be
used by each snap-in object and will be directly referenced by the Windows Forms
application.
• CSharpSnapIn.dll: A snap-in written in C#, which leverages the types of
CommonSnappableTypes.dll.
• VBSnapIn.dll: A snap-in written in Visual Basic, which leverages the types of
CommonSnappableTypes.dll.
• MyExtendableApp.exe: A console application that may be extended by the
functionality of each snap-in.
This application will use dynamic loading, reflection, and late binding to dynamically gain the
functionality of assemblies it has no prior knowledge of.


// Get all IAppFunctionality compatible classes in assembly.
var theClassTypes = theSnapInAsm
.GetTypes()
.Where(t => t.IsClass && (t.GetInterface("IAppFunctionality") != null))
.ToList();
if (!theClassTypes.Any())
{
Console.WriteLine("Nothing implements IAppFunctionality!");
}
// Now, create the object and call DoIt() method.
foreach (Type t in theClassTypes)
{
// Use late binding to create the type.
IAppFunctionality itfApp = (IAppFunctionality) theSnapInAsm.CreateInstance(t.FullName,
true);
itfApp?.DoIt();
// Show company info.
DisplayCompanyData(t);
}
}


static void DisplayCompanyData(Type t)
{
// Get [CompanyInfo] data.
var compInfo = t
.GetCustomAttributes(false)
.Where(ci => (ci is CompanyInfoAttribute));
// Show data.
foreach (CompanyInfoAttribute c in compInfo)


Console.WriteLine("***** Welcome to MyTypeViewer *****");
string typeName = "";
do
{
Console.WriteLine("\nEnter a snapin to load");
Console.Write("or enter Q to quit: ");
// Get name of type.
typeName = Console.ReadLine();
// Does user want to quit?
if (typeName.Equals("Q", StringComparison.OrdinalIgnoreCase))
{
break;
}
// Try to display type.
try
{
LoadExternalModule(typeName);
}
catch (Exception ex)
{
Console.WriteLine("Sorry, can't find snapin");
}
}


