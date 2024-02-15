### Constructor chaining in C#
A constructor can call another constructor, this is known as constructor chaining. This technique allows code reusability. In the code snippet, : this() calls the default constructor.
```csharp
 //file 1
using System;
namespace CSharpSpeedrun
{
    class Program
    {
        static void Main()
        {
            Employee starEmployee =
               new Employee(1001, "Bill", "Gates");
        }
    }
 
    class Employee
    {
        public int id;
        public string firstName;
        public string lastName;

        public Employee(
            int employeeId,
            string employeeFirstName,
            string employeeLastName) : this()
        {
            id = employeeId;
            firstName = employeeFirstName;
            lastName = employeeLastName;

            Console.WriteLine("Parameters ok");
        }

        public Employee()
        {
            Console.WriteLine
                ("Default constructor activated");
        }
    }
}
/*
Default constructor activated
Parameters ok
*/
```