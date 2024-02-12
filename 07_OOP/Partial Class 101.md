C# partial keyword. The partial
keyword allows for a single class to be partitioned across multiple code files.

Another reason is that maybe your class has grown over time into something
difficult to manage, and as an intermediate step toward refactoring that class, you can split it up into partials.

class Employee
{
// Field Data
// Constructors
// Methods
// Properties
}

// Employee.cs
partial class Employee
{
// Methods
// Properties
}

// Employee.Core.cs
partial class Employee
{
// Field data
// Properties
}

The whole idea of
a partial class is realized only during design time. After the application has been compiled, there is just a
single, unified class within the assembly.

