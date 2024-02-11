## C# Development Notes with .NET 5 and Visual Studio 2019
These notes cover setting up your environment for C# development with .NET 5 and Visual Studio 2019. We'll go through essential tools, project creation, and how to run your application.

### Prerequisites:
- **.NET 5 SDK:** This includes the runtime needed for executing .NET applications. Download and install from [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).
- **Visual Studio 2019:** Choose the workloads based on your development needs (explained later).

### Checking your setup:
- Open a command prompt and run `dotnet --version`. This should display the installed .NET SDK version.
- Use `dotnet --info` to see detailed information about .NET installations.
- `dotnet --list-runtimes` and `dotnet --list-sdks` show available runtimes and SDKs respectively.

### Understanding Runtimes:
- **Microsoft.AspNetCore.App:** Used for building ASP.NET Core web applications.
- **Microsoft.NETCore.App:** The base runtime for .NET Core applications.
- **Microsoft.WindowsDesktop.App:** Targets WinForms and WPF desktop applications.

### Installing Visual Studio 2019 Workloads:
During installation, choose the following workloads:
- **.NET desktop development:** For WinForms and WPF applications.
- **ASP.NET and web development:** For web applications using ASP.NET Core.
- **Data storage and processing:** For working with databases and other data sources.
- **.NET Core cross-platform development:** To create applications that run on various platforms.

### Additional Tools:
On the "Individual components" tab, select:
- **Class Designer:** Visual tool for designing classes and their relationships.
- **Git for Windows:** Version control system for managing code changes.
- **GitHub extension for Visual Studio:** Integrates GitHub services within Visual Studio.

### Setting Up Console UI:
- Use `Console.Title` to set the console window title (e.g., `Console.Title = "My Awesome App";`).
- Change text and background colors with `Console.ForegroundColor` and `Console.BackgroundColor`.

### Creating a .NET Core Project:
1. Open Visual Studio and create a new project.
2. Select "Console Application" under ".NET Core".
3. In the project file (`*.csproj`), you'll see `<TargetFramework>netcoreapp3.1</TargetFramework>`. This specifies the runtime version (3.1 in this case).

### Target Framework Versions:
| Version       | C# Language Version | Default |
| ------------- | --------------------| --------|
| .NET 5.x      | C# 9.0              | Yes     |
| .NET Core 3.x | C# 8.0              | Yes     |
| .NET Core 2.x | C# 7.3              | No      |

### Running Your Application:
- **Visual Studio:** Press Ctrl+F5 to run the application within the IDE.
- **Command Line:** Open a command prompt in your project directory and type `dotnet run`.

### Visual Type Designer:
1. Right-click your project, select "Add" -> "New Item".
2. Choose "Class Diagram" and add it to your project.
3. This allows you to visually design classes and their relationships.

### Additional Resources:
- Microsoft's official .NET documentation: [https://docs.microsoft.com/en-us/dotnet/](https://docs.microsoft.com/en-us/dotnet/)
- Visual Studio documentation: [https://docs.microsoft.com/en-us/visualstudio/](https://docs.microsoft.com/en-us/visualstudio/)
- Learn C# tutorials: [https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/)

### Remember:
- These notes provide a basic starting point. Explore further resources for more advanced topics and functionalities.
- Adapt the provided steps based on your specific development goals and chosen project type.