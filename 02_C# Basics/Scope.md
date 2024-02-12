## Scope in C#
In C#, a scope is created using curly braces `{}`. You've encountered this syntax in various contexts such as namespaces, classes, and methods.

## Example:
```csharp
using System;

namespace ScopeExample
{
    class Program
    {
        static void Main()
        {
            // This is the scope of the Main method
            int x = 10; // Variable 'x' is scoped within Main method
            {
                // This is an inner scope
                int y = 20; // Variable 'y' is scoped within this inner block
                Console.WriteLine(x + y); // Accessing variables from outer and inner scope
            } // End of inner scope
            // 'y' is not accessible here; it's out of scope
            Console.WriteLine(x); // Variable 'x' is accessible here
        } // End of Main method scope
    } // End of Program class scope
} // End of namespace scope
```

## Explanation:
- **Curly Braces `{}`**: In C#, curly braces define the beginning and end of a scope.
- **Namespace Scope**: Curly braces define the scope of a namespace. Everything within the braces belongs to that namespace.
- **Class Scope**: Similarly, curly braces define the scope of a class. All members and methods within the braces belong to that class.
- **Method Scope**: The curly braces of a method define the scope of that method. Variables declared within the method are only accessible within the method's scope.
- **Variable Scope**: Variables declared within a scope are accessible only within that scope or its nested scopes. Once the scope ends, the variables are no longer accessible.
- **Nested Scopes**: Scopes can be nested within each other. Inner scopes have access to variables declared in outer scopes, but not vice versa.

### Additional Information:
- **Scope Resolution**: Understanding scope is crucial for avoiding naming conflicts and managing variable lifetimes effectively.
- **Global Scope**: Variables declared outside of any method or class have global scope and can be accessed from anywhere within the file.
- **Local Scope**: Variables declared within a method or block have local scope and are accessible only within that method or block.
- **Scope Hierarchy**: The hierarchy of scopes determines the visibility and accessibility of variables and members.
- **Scope and Memory Management**: Properly managing variable scope helps in efficient memory usage and prevents memory leaks.

