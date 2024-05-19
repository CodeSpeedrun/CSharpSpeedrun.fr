/* SHORTCUTS
Shift + alt + F => format
Shift + alt + A => comment


***BUILDING PROJECTS
In the terminal window, enter the following command to create an empty .NET 5 solution file:
dotnet new sln -n CSharpConsoleApp -o .\VisualStudioCode

dotnet new console -lang c# -n CSharpConsoleApp -o .\VisualStudioCode\CSharpConsoleApp -f net5.0

add the created project to the solution with the following command:
dotnet sln .\VisualStudioCode\CSharpConsoleApp.sln add .\VisualStudioCode\CSharpConsoleApp

dotnet -h.

dotnet restore

dotnet build

To run your project without debugging, execute in the same directory as the project file (CSharpConsoleApp.csproj):
dotnet run
*/

dotnetnew //get template lsts