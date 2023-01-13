## Variables 
```c#
  static void Main(string[] args)
        {
            int myInt = 7;          //Integer
            float myFloat = 7.1;      //Floating point number
            char myChar = 'A';        //one character
            string myString = "AA";    //text
        }
}

static void Main(string[] args) 
{
            int a = 6, b = 12, c = 756;
}
```

## Using Convert.ToInt32();
```c#
Console.WriteLine("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine()); //int to int
Console.WriteLine("Age = " + age);
```

## Console.Read()
The second way to capture user input is the Console.Read() method that reads the whole input line but only returns the ASCII value of the first character. For example, the ASCII value of A is 65. Some devices still use ASCII encoding, so this method might come in handy.
```c#
Console.WriteLine("Enter coupon code: ");
int code = Console.Read();

Console.WriteLine("ASCII = " + code);
```

## Console.ReadKey()
The third way to capture user input is the Console.ReadKey() method. This method records the first keyboard keypress and returns the ConsoleKeyInfo struct which can be used to display additional information about the key that was pressed.
```c#
Console.WriteLine("Press any key to continue...");
ConsoleKeyInfo key = Console.ReadKey();

Console.WriteLine();
Console.WriteLine("Key pressed = " + key.Key);
```

##  logical Operators 
&& returns true if both statements are true otherwise it will return false.
|| will return true if one of the statements is true.
! reverses the result, returns false if the result true and returns true if the result is false.
```c#
int a = 5;
int b = 10;

Console.WriteLine("Logical and: " + ((a < 3) && b < 20) );
Console.WriteLine("Logical or: " + ((a < 3) || b < 20) );
Console.WriteLine("Logical not: " + (a != b));
```

## operator precedence
The evaluation of an expression is done from left to right. If multiple operators are used, then the operators with higher priority are evaluated before the operators with lower priority. However, with additional ( ), the priority of the operators can be manually changed as illustrated below:
```c#
int a = 5;
int b = 10;
Console.WriteLine( a + b * 3 ); 
Console.WriteLine((a + b) * 3 ); 
// (a + b) evaluated first

35
45
```

## Task List in Visual Studio
In Visual Studio, comment tokens like TODO, HACK, NOTE and UNDONE are available to track comments. Let’s say we need to develop a feature in a particular class, then we can tag that class with a comment token, and later we can easily find it with the Task List. The Task List can be activated by clicking on View > Task List.
```c#
 
```

## Math class in C#
The C# Math class contains many methods that performs mathematical operations. The most popular methods are: Min(), Max(), Round().
```c#
int min = Math.Min(56, 90);
Console.WriteLine(min);

56
```

## Math.Sqrt()
```c#
double sqrt = Math.Sqrt(16);
Console.WriteLine(sqrt );

4
```

## Math.Round()
```c#
double round = Math.Round(6.99);
Console.WriteLine(round);

7
```

## enum
```c#
 using System;

namespace CSharpSpeedrun 
{
    class Program
    {
        enum Days
        {
            Monday,     //0
            Tuesday,    //1
            Wednesday,  //2
            Thursday = 17,
            Friday,     //18
            Saturday,   //19
            Sunday      //20
        }

        static void Main(string[] args)
        {
            Days myFavDay = Days.Saturday;

            //(int)myFavDay
            Console.WriteLine((int)myFavDay);
        }
    }
}
```
## enum with a switch statement
```c#
 
using System;

namespace CSharpSpeedrun 
{
    class Program
    {
        enum Pet
        {
            Dog,
            Cat,
            Bird,
            Donkey
        }

        static void Main(string[] args)
        {
            Pet myFavPet = Pet.Dog;

            switch (myFavPet)
            {
                case Pet.Dog:
                    Console.WriteLine("woof woof");
                    break;
                case Pet.Cat:
                    Console.WriteLine("miaow");
                    break;
                case Pet.Bird:
                    Console.WriteLine("kui kui");
                    break;
                case Pet.Donkey:
                    Console.WriteLine("heee haw");
                    break;
                default:
                    break;
            }

        }
    }
}
```

## iterate an array
```c#
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFavFlowers = { "Rose", "Lily", "Tulip", "Orchid" };

            foreach (string element in myFavFlowers)
            {
                Console.WriteLine(element);
            }
        }
    }
}
Array.Sort(myFavFlowers);
Array.Reverse(myFavFlowers);
```

## else-if statement
```c#
 using System;

namespace CSharpSpeedrun. 
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 27;

            if (a == b)
            {
                Console.WriteLine("a is equal to b");
            }
            else if (a > b)
            {
                Console.WriteLine("a is greater than b");
            }
            else if (a < b)
            {
                Console.WriteLine("a is less than b");
            }
        }
    }
}
```

## ternary operator in C#
```c#
 
using System;

namespace CSharpSpeedrun 
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentGrade = 52;
            string result;

            result = (studentGrade < 40) ? "Student has failed module." : "Student has passed the module!";
            Console.WriteLine(result);
        }
    }
}

Student has passed the module!

```

## .NET aliases
Since C# applications run on top of the .NET framework, it is possible to use the .NET data type alias instead of the C# data types and the output will be identical.
```c#
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
         int myInt= 45643;
         System.Int32 mySpecialInt = 45643; 

         Console.WriteLine(myInt);
         Console.WriteLine(mySpecialInt);
        }
    }
}
```

## string interpolation
A better way of combining two strings is called string interpolation. The dollar $ symbol at the beginning tells the compiler it is an interpolated string. The variables are wrapped with { } and are switched when the application is executed.

```c#
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John ";
            string lastName = "Cena";

            Console.WriteLine($"My best friend is {firstName}{lastName}!");
        }
    }
}
```

## @ operator to escape characters
It can be very tedious to prefix a \ for every single special character found in a piece of text. Another way to escape special characters is by using the @ operator. It tells the compiler that every special character should be treated as a normal character.
The @ operator will escape most special characters except double-quotes. So, we’ll use it in combination with the \ to escape all the special characters found in common text.
```c#
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            string helpdeskMessage = @"The \"software\" will be installed in D:\ProgramData\Adobe\Installer";

            Console.WriteLine(helpdeskMessage);
        }
    }
}

//The “software” will be installed in D:\ProgramData\Adobe\Installer
```

## implicit casting
Implicit casting is done automatically by the compiler. Data is copied without any data loss. For e.g., when converting a smaller data type to a larger data type. Remember that each data type takes a specific size in memory, when converting data types, size is really important.

```c#
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
           int myLuckyInt = 10;
           double myLuckyDouble = myLuckyInt; 
           Console.WriteLine(myLuckyDouble);
        }
    }
}
//10
```

## What is explicit casting?
Explicit casting is not done automatically because the compiler knows there will be data loss. So we need to do the casting manually by putting the target type in parentheses.

In other words, we have to prefix the variable with the target data type. For e.g., converting a larger numeric data type to a smaller data type.
```c#
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
           double myLuckyDouble = 3.23175D; 
           int myLuckyInt = (int)myLuckyDouble; //prefix
           Console.WriteLine(myLuckyInt );
        }
    }
}
//3
```

## What is non-compatible type casting?
Sometimes we cannot use implicit or explicit conversion because the data types are too different. For example, the compiler will throw an error when converting string to int data types.
```c#
namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
           string myLuckyText = "938473"; 
           int myLuckyInt = Convert.ToInt32(myLuckyText); 
           Console.WriteLine(myLuckyInt);
        }
    }
}
```

## How to declare nested for loops in C#?
C# allows us to put a for loop inside another for loop. This technique is called nested for loops. It is useful in scenarios we have multiple iterations.
```c#
 
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 2; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    Console.WriteLine("a = {0}, b = {1}", a, b);
                }
            }
        }
    }
}
```

## How to break a while loop in C#?
There are multiple ways to stop a while loop. Instead of using a boolean expression, the break keyword can be used.
```c#
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("Hello World!");
                i++;

                if (i >= 3)
                {
                    break;
                }
            }
        }
    }
}
```

## What is a do-while loop?
It is a variation of the while loop with one key difference. The while loop is executed at least once even if the conditional expression is false. It always starts with the do keyword.
```c#
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            do
            {
                Console.WriteLine("Hello World");
                counter++;

                if (counter > 3)
                {
                    break;
                }

            } while (true);
        }
    }
}
```

## What is a foreach loop?
The foreach loop is one of the most popular loop variations available in C#. It is a simplified version of the for loop, consequently, we’ll be using it in most of our code snippets.
```c#
 using System;

namespace CSharpSpeedrun.com
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFavFruits = { "Apple", "Grape", "Banana" };

            foreach (string fruit in myFavFruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
Apple
Grape
Banana
```

## How to declare named arguments?
because c# is a strongly typed language When creating methods with multiple parameters, the order of the arguments and parameters needs to be respected. However, passing arguments with the key: value syntax allows us to bypass that rule. Now the order of the arguments is irrelevant.
```c#
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main()
        {
            int numberOfHearts = 5; string currentWeapon = "Giant Spoon";

            GetHeroStatus(weapon: currentWeapon, hearts: numberOfHearts);
        }

        static void GetHeroStatus(int hearts, string weapon)
        {
            if (hearts < 10)
            {
                Console.WriteLine("Let's buy some health packs!");
            }
            else
            {
                Console.WriteLine("Ready for adventure!");
            }
            Console.WriteLine("Current weapon: " + weapon);
        }
    }
}
Let’s buy some health packs!
Current weapon: Giant Spoon
```

## What is the ref modifier?
The ref modifier is short for reference. Using ref, passes a reference to the original data instead of a copy. Notice the ref modifier is added in two places. Firstly, inside the method declaration GetSquared(ref myFavNumber);. Secondly, when calling the method. static void GetSquared(ref int number)

This time, we get the expected result 49 instead of 7.
```c#
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main()
        {
            int myFavNumber = 7;

            GetSquared(ref myFavNumber);

            Console.WriteLine(myFavNumber);
        }

        static void GetSquared(ref int number)
        {
            number = number * number;
        }
    }
}
```

##
```c#
 
```

##
```c#
 
```

##
```c#
 
```

##
```c#
 
```

##
```c#
 
```

##
```c#
 
```

##
```c#
 
```

##
```c#
 
```

##
```c#
 
```

##
```c#
 
```

##
```c#
 
```

##
```c#
 
```

##
```c#
 
```

##
```c#
 
```
<details id=1>
<summary><h2>Step 1</h2></summary>
 
</details>
