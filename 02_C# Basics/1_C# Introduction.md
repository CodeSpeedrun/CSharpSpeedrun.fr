
# C# Speedrun

## Introduction
In this tutorial, we'll go through the process of creating a C# console application using .NET 5.0. We'll cover topics such as setting up a solution, creating a console application project, and understanding the structure of a simple C# program.

## Setting Up the Solution and Project
First, let's create a new solution named `AllProjects` and add a console application project named `CSharpApp` to it.

```bash
dotnet new sln -n AllProjects
dotnet new console -lang c# -n CSharpApp -o .\CSharpApp -f net5.0
dotnet sln .\AllProjects.sln add .\CSharpApp
```

## Understanding the Program Structure
Let's dive into the structure of the C# program created in `CSharpApp/Program.cs`.

```csharp
using System;

namespace CSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg => {0}", args[i]);
            }
        }
    }
}
```

### Main Method
The `Main` method serves as the entry point of the application. It accepts an array of strings (`args`) as parameters, which can contain command-line arguments passed to the program.

```csharp
static void Main(string[] args)
{
    // Application logic
}
```

### Command-Line Arguments
The `args` parameter allows access to command-line arguments passed when running the program. These arguments can be accessed within the `Main` method, as demonstrated in the code snippet above.

## Application Object
The class containing the `Main` method serves as the application object. It is possible for an application to have multiple application objects, useful for scenarios like unit testing. Specifying the startup object can be done via the project file or Visual Studio project properties.

### Startup Object
To specify the startup object, you can use the `<StartupObject>` element in the project file or the Startup Object dropdown in Visual Studio.

## Static Members
Static members are scoped to the class level rather than the object level. They can be invoked without the need to create a new class instance.

### Main Method Variations
The `Main` method can have variations in its signature. It can return an integer or void and accept command-line arguments or not.

#### Main Method with Integer Return Type
```csharp
static int Main(string[] args)
{
    // Application logic
    return 0; // Must return a value before exiting
}
```

#### Main Method with Void Return Type and No Parameters
```csharp
static void Main()
{
    // Application logic
}
 
### Asynchronous Main Method and Command-Line Argument Handling in C#

In C#, the `Main()` method can now be asynchronous, allowing for asynchronous programming capabilities. Async programming is covered in depth in Chapter 15. Here, we introduce the four additional signatures for the `Main()` method:

- `static Task Main()`
- `static Task<int> Main()`
- `static Task Main(string[])`
- `static Task<int> Main(string[])`

It's noteworthy that both the class (`Program`) and `Main()` methods can be removed. However, be aware that even if you construct a `Main()` method prototyped to return `void`, the value `0` is automatically returned.

### Accessing Command-Line Arguments

You can access command-line arguments using the static `GetCommandLineArgs()` method of the `System.Environment` type. Example:

```csharp
string[] theArgs = Environment.GetCommandLineArgs();
foreach(string arg in theArgs)
{
    Console.WriteLine("Arg: {0}", arg);
}
```

### Specifying Command-Line Flags

For testing purposes, you may want to specify possible command-line flags. In Visual Studio, you can do this by:

1. Right-clicking the project name in Solution Explorer.
2. Selecting Properties.
3. Navigating to the Debug tab on the left side.
4. Specifying values using the “Application arguments” text box.

### Showing Environment Details

To access and display environment details, you can use methods from the `Environment` class. Example:

```csharp
static void ShowEnvironmentDetails()
{
    // Print out the drives on this machine,
    foreach (string drive in Environment.GetLogicalDrives())
    {
        Console.WriteLine("Drive: {0}", drive);
    }
    Console.WriteLine("OS: {0}", Environment.OSVersion);
    Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
    Console.WriteLine(".NET Core Version: {0}", Environment.Version);
}
```

### Console Class Usage

The `Console` class encapsulates input, output, and error-stream manipulations for console-based applications. Example usage:

```csharp
Console.WriteLine("{0}, Number {0}, Number {0}", 7);
Console.WriteLine("c format: {0:c}", 7777);
// Output: c format: $7,777.00
```


 ## Conclusion
Understanding the structure of a C# console application is essential for building robust and efficient programs. By grasping concepts like the `Main` method and application object, you can effectively create and manage C# projects.
 
