/* Variables 
*/
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

/* Using Convert.ToInt32();
*/
Console.WriteLine("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine()); //int to int
Console.WriteLine("Age = " + age);
```

/* Console.Read()
The second way to capture user input is the Console.Read() method that reads the whole input line but only returns the ASCII value of the first character. For example, the ASCII value of A is 65. Some devices still use ASCII encoding, so this method might come in handy.
*/
Console.WriteLine("Enter coupon code: ");
int code = Console.Read();

Console.WriteLine("ASCII = " + code);
```

/* Console.ReadKey()
The third way to capture user input is the Console.ReadKey() method. This method records the first keyboard keypress and returns the ConsoleKeyInfo struct which can be used to display additional information about the key that was pressed.
*/
Console.WriteLine("Press any key to continue...");
ConsoleKeyInfo key = Console.ReadKey();

Console.WriteLine();
Console.WriteLine("Key pressed = " + key.Key);
```

/*  logical Operators 
&& returns true if both statements are true otherwise it will return false.
|| will return true if one of the statements is true.
! reverses the result, returns false if the result true and returns true if the result is false.
*/
int a = 5;
int b = 10;

Console.WriteLine("Logical and: " + ((a < 3) && b < 20) );
Console.WriteLine("Logical or: " + ((a < 3) || b < 20) );
Console.WriteLine("Logical not: " + (a != b));
```

/* operator precedence
The evaluation of an expression is done from left to right. If multiple operators are used, then the operators with higher priority are evaluated before the operators with lower priority. However, with additional ( ), the priority of the operators can be manually changed as illustrated below:
*/
int a = 5;
int b = 10;
Console.WriteLine( a + b * 3 ); 
Console.WriteLine((a + b) * 3 ); 
// (a + b) evaluated first

35
45
```

/* Task List in Visual Studio
In Visual Studio, comment tokens like TODO, HACK, NOTE and UNDONE are available to track comments. Let’s say we need to develop a feature in a particular class, then we can tag that class with a comment token, and later we can easily find it with the Task List. The Task List can be activated by clicking on View > Task List.
*/
 
```

/* Math class in C#
The C# Math class contains many methods that performs mathematical operations. The most popular methods are: Min(), Max(), Round().
*/
int min = Math.Min(56, 90);
Console.WriteLine(min);

56
```

/* Math.Sqrt()
*/
double sqrt = Math.Sqrt(16);
Console.WriteLine(sqrt );

4
```

/* Math.Round()
*/
double round = Math.Round(6.99);
Console.WriteLine(round);

7
```

/* enum
*/
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
/* enum with a switch statement
*/
 
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

/* iterate an array
*/
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

/* else-if statement
*/
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

/* ternary operator in C#
*/
 
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

/* .NET aliases
Since C# applications run on top of the .NET framework, it is possible to use the .NET data type alias instead of the C# data types and the output will be identical.
*/
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

/* string interpolation
A better way of combining two strings is called string interpolation. The dollar $ symbol at the beginning tells the compiler it is an interpolated string. The variables are wrapped with { } and are switched when the application is executed.

*/
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

/* @ operator to escape characters
It can be very tedious to prefix a \ for every single special character found in a piece of text. Another way to escape special characters is by using the @ operator. It tells the compiler that every special character should be treated as a normal character.
The @ operator will escape most special characters except double-quotes. So, we’ll use it in combination with the \ to escape all the special characters found in common text.
*/
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

/* implicit casting
Implicit casting is done automatically by the compiler. Data is copied without any data loss. For e.g., when converting a smaller data type to a larger data type. Remember that each data type takes a specific size in memory, when converting data types, size is really important.

*/
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

/* What is explicit casting?
Explicit casting is not done automatically because the compiler knows there will be data loss. So we need to do the casting manually by putting the target type in parentheses.

In other words, we have to prefix the variable with the target data type. For e.g., converting a larger numeric data type to a smaller data type.
*/
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

/* What is non-compatible type casting?
Sometimes we cannot use implicit or explicit conversion because the data types are too different. For example, the compiler will throw an error when converting string to int data types.
*/
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

/* How to declare nested for loops in C#?
C# allows us to put a for loop inside another for loop. This technique is called nested for loops. It is useful in scenarios we have multiple iterations.
*/
 
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

/* How to break a while loop in C#?
There are multiple ways to stop a while loop. Instead of using a boolean expression, the break keyword can be used.
*/
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

/* What is a do-while loop?
It is a variation of the while loop with one key difference. The while loop is executed at least once even if the conditional expression is false. It always starts with the do keyword.
*/
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

/* What is a foreach loop?
The foreach loop is one of the most popular loop variations available in C#. It is a simplified version of the for loop, consequently, we’ll be using it in most of our code snippets.
*/
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

/* How to declare named arguments?
because c# is a strongly typed language When creating methods with multiple parameters, the order of the arguments and parameters needs to be respected. However, passing arguments with the key: value syntax allows us to bypass that rule. Now the order of the arguments is irrelevant.
*/
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

/* What is the ref modifier?
The ref modifier is short for reference. Using ref, passes a reference to the original data instead of a copy. Notice the ref modifier is added in two places. Firstly, inside the method declaration GetSquared(ref myFavNumber);. Secondly, when calling the method. static void GetSquared(ref int number)

This time, we get the expected result 49 instead of 7.
*/
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

/* Constructor chaining in C#
A constructor can call another constructor, this is known as constructor chaining. This technique allows code reusability. In the code snippet, : this() calls the default constructor.
*/
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
Default constructor activated
Parameters ok
```

/* What access modifiers are available in C#?
public	Public means it is accessible for all classes in the application.
private	Private denotes that it is only accessible within the same class or the compiler will throw an error.
protected	Protected means it is accessible within the same class, or through inheritance.
internal	This one is used to make code accessible only within its own assembly.
*/
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main()
        {
             Book myBook = new Book();
             Console.WriteLine(myBook.id);
        }
    }
 
    class Book
    {
        public int id = 523;
        private string title = "Harry Potter"; 
    }
}
//523
```

/* How to declare property in C#?
It is common practice to name the property after the private field but written in CamelCase. The code snippet below illustrates how get { return username; } returns and set { username = value; } assigns data to the private field. Notice the value keyword represents the data to be assigned.
*/
 using System;
namespace CSharpSpeedrun
{
    class Player
    {
        private string username; // field
        public string UserName   // property
        {
            get { return username; }
            set { username = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player starPlayer = new Player();
            starPlayer.UserName = "Tom";
            Console.WriteLine(starPlayer.UserName);
        }
    }
}
//Tom
```

/* How to implement inheritance?
In the code snippet, the title field is required for both Book and EBook classes. Consequently, it is better to add it in the Book class and it will also be accessible from the EBook class. Notice the colon to activate inheritance. EBook: Book
*/
 using System;

namespace CSharpSpeedrun
{
    class Book //parent
    {
        public string title = "Sapiens"; 
    }

    class EBook: Book //child
    {
        public string format = "Pdf";
    }

    class Program
    {
        static void Main(string[] args)
        {
            EBook myEBook= new EBook();  
            Console.WriteLine(myEBook.title + ", format = " + myEBook.format);
        }
    }
}
//Sapiens, format = Pdf
```

/* What is the sealed keyword in C#?
The sealed keyword blocks the inheritance of the class. C# will throw an error when trying to inherit from a sealed class.
*/
 using System;

namespace CSharpSpeedrun
{
    sealed class Book //parent
    {
        public string title = "Sapiens"; 
    }

    class EBook: Book //child
    {
        public string format = "Pdf";
    }

    class Program
    {
        static void Main(string[] args)
        {
            EBook myEBook= new EBook();  
            Console.WriteLine(myEBook.title + ", format = " + myEBook.format);
        }
    }
}
```

/* How to implement dynamic polymorphism?
For example, let’s say a base class Vehicle has a method ActivateWiper() and child classes are Car, Truck and they have their own implementation of ActivateWiper().
*/
 using System;

namespace CSharpSpeedrun
{
    class Vehicle  //parent
    {
        public virtual void ActivateWiper() 
        {
            Console.WriteLine("generic wiper activated");
        }
    }

    class Car : Vehicle  //child
    {
        public override void ActivateWiper() 
        {
            Console.WriteLine("car wiper activated");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle  myVehicle = new Vehicle();
            Car myCar = new Car();
            myVehicle.ActivateWiper(); 
            myCar.ActivateWiper(); 
        }
    }
}
//generic wiper activated
//car wiper activated
```

/* How to implement static polymorphism?
Let’s say we need a method that works well with int and double data types. The compiler automatically selects the correct method based on the data that is passed when the method is called. For example, passing AdditionCalculator(1,4) calls the method that returns the int and passing dditionCalculator(1.1,4) calls the method that returns double.
*/
 using System;

namespace CSharpSpeedrun
{
    class Program 
    {
        static public int AdditionCalculator(int number1, int number2) 
        {
            return number1 + number2;
        }
        static public double AdditionCalculator(double number1, double number2) 
        {
            return number1 + number2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AdditionCalculator(1,4));
        }
    }
}
//5
```

/* What is abstraction?
Data abstraction is the process of showing only the crucial data to the user. For example, we can use the brakes of a car or bike without knowing how it works internally.
Some of the ways to achieve abstraction are:

Abstract class and abstract method. An abstract class describes something abstract, something that is more of a concept than a tangible thing. It cannot instantiate objects, but other classes can inherit its members and create objects. Addtionally, an abstract class contains both abstract and regular methods.
Note the abstract method does not contain any body, the content is provided by the child class. A class inheriting an asbtract class is binded by contract to implement all the abstract methods.
It can only be placed inside an abstract class.

Interfaces
*/
 using System;
namespace CSharpSpeedrun
{
    abstract class Clock
    {
        public abstract void AlarmSound();
 
        public void ShutDown()
        {
            Console.WriteLine("Shut down initiated.");
        }
    }
    
    class AlarmClock : Clock //child class 
    {
        public override void AlarmSound()
        {
            Console.WriteLine("Rise and shine!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock myAlarmClock = new AlarmClock();
            myAlarmClock.AlarmSound();
            myAlarmClock.ShutDown();  
        }
    }
}
//Rise and shine!
//Shut down initiated.
```

/* as-keyword
The as keyword converts a class instance to an interface type that it implements. We check for null values to ensure the cast was successful.

*/ 
 using System;
namespace CSharpSpeedrun
{
    interface IRobot
    {
        void BootUpSound();
    }

    class IndustrialRobot : IRobot
    {
        void IRobot.BootUpSound()
        {
            Console.WriteLine("I am ready to rock and roll!");
        }
        public void SendNotification()
        {
            Console.WriteLine("Email sent");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            IndustrialRobot starIndustrialRobot = new IndustrialRobot();

            IRobot starIndustrialRobot_2 = starIndustrialRobot as IRobot;
            if (starIndustrialRobot_2 != null)
            {
                starIndustrialRobot_2.BootUpSound();
            }
        }
    }
}
//I am ready to rock and roll!

using System;
using System.Collections.Generic;

namespace CSharpSpeedrun
{
    public class Program
    {
        static void Main()
        {
            IMarkingSystem ms = getMarkingSystem();
            Console.WriteLine(ms.calculatePassingMark());
        }

        public static IMarkingSystem getMarkingSystem()
        {
            return new MarkingSystem2019();
        }
    }

    public class MarkingSystem2022 : IMarkingSystem
    {
        public float calculatePassingMark()
        {
            return 40;
        }
    }
    public class MarkingSystem2019 : IMarkingSystem
    {
        public float calculatePassingMark()
        {
            return 35;
        }

        public float calculateGPA()
        {
            return 3;
        }
    }
    public interface IMarkingSystem
    {
        float calculatePassingMark();
    }
}
//35

using System;

namespace CSharpSpeedrun
{
    public class Program
    {
        static void Main()
        {
            DrawUiElement(new TextBox());
        }

        static void DrawUiElement(IUIController uIController)
        {
            uIController.DrawElement();
        }
    }

    interface IUIController
    {
        void DrawElement();
    }

    public class Button : IUIController
    {
        public void DrawElement()
        {
            Console.WriteLine("Drawing Button");
        }
    }

    public class TextBox : IUIController
    {
        public void DrawElement()
        {
            Console.WriteLine("Drawing TextBox");
        }
    }
}
//Drawing TextBox
```

/* Generic Interface

*/
 using System;

namespace CSharpSpeedrun
{
    interface ICalculator<T>
    {
        double Addition(T number1, T number2);
        double Subtraction(T number1, T number2);
    }

    class Calculator<T> : ICalculator<T>
    {
        public double Addition(T number1, T number2)
        {
            double result = Convert.ToDouble(number1) + Convert.ToDouble(number2);
            return result;
        }

        public double Subtraction(T number1, T number2)
        {
            double result = Convert.ToDouble(number1) + Convert.ToDouble(number2);
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        { 
            Calculator<int> c1 = new Calculator<int>();
            double result1 = c1.Addition(12, 50);
            Console.WriteLine("Addition(12, 50) result = {0}", result1);

            Calculator<float> c2 = new Calculator<float>();
            double result2 = c2.Subtraction(3.118f, 5.623f);
            Console.WriteLine("Subtraction(3.118f, 5.623f) result = {0:f}", result2);
        }
    }
}
//Addition(12, 50) result = 62
//Subtraction(3.118f, 5.623f) result = 8.74
```

/* How to iterate using foreach loop in C#?
Since the List collection class implements the IEnumerable interface, we are allowed to use the foreach loop to iterate its content.
*/
 using System;
using System.Collections.Generic;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> popularGames = new List<string>()
            {
                "baseball",
                "Scrabble"
            };

            List<string> myFavGames = new List<string>();
            myFavGames.Add("golf");
            myFavGames.Add("chess");
            myFavGames.Add("poker");

            myFavGames.AddRange(popularGames);

            foreach (string game in myFavGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
```

/* How to use the KeyValuePair struct?
The KeyValuePair gives more flexibility when iterating a Dictionary because it provides many useful properties. foreach (KeyValuePair item in stockTracker)

*/
 using System;
using System.Collections.Generic;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> stockTracker = new Dictionary<string, int>();

            stockTracker.Add("shampoo", 21);
            stockTracker.Add("pen", 65);

            foreach (KeyValuePair<string, int> item in stockTracker)
            {
                Console.WriteLine(item.Key + " => " + item.Value + " in stock.");
            }
        }
    }
}
//shampoo => 21 in stock.
//pen => 65 in stock.
```

/* How to retrieve the latest element in C#?
The Pop() method is used to retrieve the latest element from a Stack. Notice that it retrieves and removes the element from the collection.

*/
 using System;
using System.Collections.Generic;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myFavBooks = new Stack<string>();

            myFavBooks.Push("The Little Prince");
            myFavBooks.Push("Hobbit");
            myFavBooks.Push("One Piece");

            Console.WriteLine("_____BEFORE_____");
            foreach (string book in myFavBooks)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();

            Console.WriteLine("latest book =>" + myFavBooks.Pop());

            Console.WriteLine();
            Console.WriteLine("_____AFTER_____");
            foreach (string book in myFavBooks)
            {
                Console.WriteLine(book);
            }
        }
    }
}
/*
___BEFORE____
One Piece
Hobbit
The Little Prince

latest book =>One Piece

___AFTER ___
Hobbit
The Little Prince
*/
```

/* How to iterate a Queue<T>?
The Queue<T> also implements the IEnumerable interface, consequently, we can use the foreach loop to iterate its content.
*/
using System;
using System.Collections.Generic;

namespace CSharpSpeedrun.com
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<String> customers = new Queue<String>();

            customers.Enqueue("Mark");
            customers.Enqueue("Pooja");
            customers.Enqueue("Warren");

            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
/*
Mark
Pooja
Warren
  */
```
 
/* What is Single Responsibility Principle?
This principle recomments every software modules such as class, structures, methods among others should accomplish only one job. Hence only one reason to change. The modules should not multitask like a Swiss knife, just because we can put every line of code in a single class, doesn’t mean we should.
*/
 using System;

namespace CSharpSpeedrun
{
    public class UserRegistration
    {
        public static void Main()
        {
            FilterUserInput();
            SaveDataToDb();
            MailSender();
        }

        public static void FilterUserInput() { }

        public static void SaveDataToDb() { }

        public static void MailSender() { }
    }
}
```

##
*/
 
```

/* What is Open/Closed Principle?
This principle advocates that a software module should be open for extension but closed for modification. In other words, new functionality should be easily added without altering existing codes which has already been tested. Inheritance is one of the techniques to accomplish this.
*/
 
```

/* What is Liskov Substitution Principle?
It is recommended that any derived class should be interchangeble with the parent class and the output should be identical. In other words, a derived class must be substitutable for its parent class. Let’s say a mother is an Engineer while her son is a teacher, although they are related, the son cannot replace the Engineer at work.

*/
 
```


/* What is Interface Segregation Principle (ISP)?
This principle recommends that classes should not be forced to implement methods they dont use. In other words, instead of a multipurpose interface, it is better to have multiple smaller ones.

*/
 public class Manager: Developper 
{  
   public void MeetClients()  
   {    
   }  
   public void CreateToDoItem()  
   {  
   }  
   public void DevelopFeature()  
   {  
      throw new Exception(" ");  
   }  
} 
```

/* What is Dependency Inversion Principle?
DIP advocates that upper-level modules should not be dependent on low-level modules. In other words, both should depend upon abstractions, there should not be tight coupling among components of a software.
*/
 using System;

namespace CSharpSpeedrun.com
{
    public interface IBackupController
    {
        void PowerOn();
        void ShutDown();
    }

    public class XpressBackupSoftware : IBackupController
    {
        public void PowerOn()
        {
            Console.WriteLine("Backup started");
        }

        public void ShutDown()
        {
            Console.WriteLine("Backup stopped");
        }
    }

    public class BackupController
    {
        IBackupController _backupController;

        public BackupController(IBackupController backupController)
        {
            this._backupController = backupController;
        }

        public void PowerOn()
        {
            _backupController.PowerOn();
        }

        public void ShutDown()
        {
            _backupController.ShutDown();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BackupController bc = new BackupController(new XpressBackupSoftware());
            bc.PowerOn();
            bc.ShutDown();
        }
    }
}
/*
Backup started
Backup stopped
*/
```

/* What are design patterns?
Design patterns are conceptual solutions to common software problems. They advocate the reusability and maintainability of applications. The most popular design patterns come from the book by GOF.
*/
 
```

/* What is Singleton Design Pattern?
SDP is one of the most popular and simple design pattern. It makes sure there is only one global instance for the class.
*/
using System;
using System.Collections.Generic;

namespace CSharpSpeedrun.com
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton(); 

        //Private constructor prevent creation of instances 
        private Singleton() { }
        public static Singleton Instance
        {
            get
            { 
                return instance;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            Singleton s1 = Singleton.Instance; 
        }
    }
}//vs
  
using System;
using System.IO;

namespace CSharpSpeedrun.com
{ 
    public class SingletonDemo
    {
        private static SingletonDemo instance = new SingletonDemo(); 

        public static SingletonDemo GetInstance
        {
            get
            {
                return instance;
            }
        }
    } 
}
/*
  
*/
```

/* What is LINQ?
LINQ or Language Integrated Query allows us to query data from various sources and formats such as file, database, xml and much more.
*/
string[] myFavCars = {"Toyota", "BMW", "Tesla"};

var myQuery = from car in myFavCars 
                where car.Contains('s')
                select car;
    
foreach(var car in myQuery ){
    Console.WriteLine(car);
}
/*
  
*/
```

/* What is an indexer?
Previously we have covered arrays. An indexer allows a class to be indexed and accessed like an array. Similar to a property, an indexer is defined using this keyword and square brackets [].
*/
using System;

namespace CSharpSpeedrun
{
    class Team
    {
        private string[] tempArray = new string[4];

        //indexer
        public string this[int number]
        {
            get { return tempArray[number]; }
            set { tempArray[number] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Team teams = new Team();
            teams[0] = "Chicago Bulls";
            teams[1] = "New York Scavengers";
            teams[2] = "Mumbai Rockstars";
            teams[3] = "Mumbai Rockstars";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(teams[i]);
            }
        }
    }  
}
/*
  
*/
```

/* What is the partial keyword?
Using the partial keyword, we can break up the implementaton of classes, methods or even interfaces into several .cs files.
*/
using System;

namespace CSharpSpeedrun
{
    public partial class Enemy
    {
        public void DisplayHP() {
            Console.WriteLine("100 hp");
        }
        partial void GenerateEmployeeId();
    }
    public partial class Enemy
    {
        public void DisplayWeapons()
        {
            Console.WriteLine("Giant spoon");
        }
         partial void GenerateEmployeeId(){}
    }
    class Program
    {
        static void Main(string[] args)
        {
            var enemy = new Enemy(); 
            enemy.DisplayHP();
            enemy.DisplayWeapons();
        }
    }
}
/*
  
*/
```

  
/* What is a Tuple?
A tuple is a data structure that stores data of different data types. It is mostly used to return multiple values from a method. Above all, Tuple can pass multiple values to a method through a single parameter.
*/
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main()
        {
            static void Main(string[] args)
            {
                Console.WriteLine(GetEmployeeDetails());
            }

            static Tuple<int, string, string> GetEmployeeDetails()
            {
                return Tuple.Create(152, "John", "Dow");
            }
        }
    }
}
  
using System;

namespace CSharpSpeedrun
{
    class Program
    {

        static void Main()
        {
            var player = Tuple.Create(190, "Marylyn", "Banners");
            DisplayPlayers(player);
        }

        static void DisplayPlayers(Tuple<int, string, string> player)
        {
            Console.WriteLine(player.Item1);
            Console.WriteLine(player.Item2);
            Console.WriteLine(player.Item3);
        }
    }
}
/*
  
*/
```

/* What are delegates?
Delegate allows passing a function as a parameter. It is also used when workng with callback functions and events.
The delegate defines the method signature.

Delegate workflow
Declare a delegate
Bind methods
Call the delegate
*/
using System;
namespace CSharpSpeedrun.
{

public delegate void DemoDelegate(string msg); //declaring a delegate

class Program
{
    static void Main(string[] args)
    {
        DemoDelegate d = Greetings;
        d("Good morning");
 
        d = (string txt) => Console.WriteLine("lambda expression: " + txt);
        d("Good morning");
    }
 
    public static void Greetings(string txt)
    {
        Console.WriteLine("Called ClassA.MethodA() with parameter: " + txt);
    }
}
 

}
/*
  
*/
```

/* What is an Extension Method?
Extension methods are simply additional methods that are injected to the original class without editing or recompiling it.
*/
using System;
namespace CSharpSpeedrun
{

public static class MethodExtension
     {
        public static bool IsEvenNumber(this int i)
        {
            if(i%2 == 0){
               return true;
            }else{
               return false;
             }
        }
    }

class Program
{
    static void Main(string[] args)
    {
        int myNum  = 12;

        bool result = myNum.IsEvenNumber(); 

        Console.WriteLine(result);
    }
}

}
//public static bool IsEvenNumber(this int i, int value)
/*
  
*/
```

/* What is nullable types?
Nullable types allows assignment of null to value type variables.
*/
Nullable<int> highScore = null;
int? highScore = null;
/*
  
*/
```

/* What is an Event?
An event is simply a delegate wrapper.
It is recommented to use the built-in delegate EventHandler for common events.
Events are created using Publisher classes and Subscriber classes. Publisher raises event, whereas Subscribers registers for events and implement the event handler methods.
  
Event Steps
Define delegate
Define event based on delegate
Publisher raises the event
*/
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main()
        {
            var product = new Product() { Title = "Nutella Breakfast Bar" };
            var mailSender = new MailSender();
            var faxSender = new FaxSender();

            var orderManager = new OrderManager();
            orderManager.ProductOrderedEventHandler += mailSender.OnProductOrdered;
            orderManager.ProductOrderedEventHandler += faxSender.OnVideoEncoded;
            orderManager.OrderProduct(product);
        }
    }
    class ProductEventArgs : EventArgs
    {
        public Product Product { get; set; }
    }
    class MailSender
    {
        public void OnProductOrdered(object source, ProductEventArgs e)
        {
            Console.WriteLine("Mail order sent for => " + e.Product.Title);
        }
    }
    class FaxSender
    {
        public void OnVideoEncoded(object source, ProductEventArgs e)
        {
            Console.WriteLine("Fax order sent for => " + e.Product.Title);
        }
    }
    class Product
    {
        public string Title { get; set; }

    }

    class OrderManager
    {
        //step 1: define delegate
        //step 2: define event based on delegate
        //step 3: Make publisher raise the event

        public event EventHandler<ProductEventArgs> ProductOrderedEventHandler;

        public void OrderProduct(Product product)
        {
            Console.WriteLine("ordering product ...");

            var data = new ProductEventArgs() { Product = product };

            OnProductOrdered(data);
        }

        protected virtual void OnProductOrdered(ProductEventArgs e)
        {
            /*if (ProductOrdered != null)
            {
                ProductOrdered(this, new ProductEventArgs() { Product = product });
            }*/ //second version
            //del.Invoke("Hello -!");
// or 
            //del("Hello!");
            ProductOrderedEventHandler?.Invoke(this, e);
        }
    }
}
/*
ordering product …
Mail order sent for => Nutella Breakfast Bar
Fax order sent for => Nutella Breakfast Bar
*/
```

/* Exception handling
The exceptions can be hard to understand, C# allows us to catch an exception and display understandable messages to the user. The try statement will test code for errors and the catch statement contains code to be executed if an error occurs.
We can use properties from the Exception class to output useful information when the compiler throws an error.
*/
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myLuckyNumers = { 14, 17, 54, 8 };
                Console.WriteLine(myLuckyNumers[7]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.TargetSite);
            }
        }
    }
}
/*
Index was outside the bounds of the array.
Main
Void Main()
*/
```

/* What is Regex (Regular Expression)?
A Regular Expression is a pattern that is often used to validate text. In C#, the related classes comes from the System.Text.RegularExpressions namespace.
*/
using System;
using System.Text.RegularExpressions;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "Hello world, warm welcome@to C#SharpSpeedrun.com";
            string result = Regex.Replace(txt, "[^a-zA-Z0-9_]+", " ");
            Console.Write( result); 
        }
    }
}
/*
Hello world warm welcome to C SharpSpeedrun com
*/
```

/* What is a Task?
A Task is an asynchronous operation that needs to be done. It usually represents a single operation that executes on the thread pool.
*/
using System;
using System.Threading.Tasks;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(app1);
            task1.Start();
            Console.WriteLine("Main thread ended"); 
        }

        static void app1()
        {
            for (int i = 10; i <= 12; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("app1 thread ended");
        }
    }
}
/*
10
11
12
app1 thread ended
Main Thread Ended
*/
```

/* What is Multithreading?
A multithreading application denotes it executes several threads in paralell to conduct several tasks. For example, the Android operating system can open multiple applications like browser, music player and much more. Each application is handled by distinct threads.
*/
using System;
using System.Threading;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        { 
            Thread t1 = new Thread(new ThreadStart(app1));
            Thread t2 = new Thread(new ThreadStart(app2));
            t1.Start();
            t2.Start(); 
        }
        static void app1()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(50);
            }
            Console.WriteLine("app1 ended");
            Console.WriteLine();
        }
        static void app2()
        {
            for (int i = 10; i <= 12; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("app2 ended");
        }
    }
}
/*
1
10
11
12
app2 ended
2
3
app1 ended
*/
 

/* What is the Yield Keyword?
The return type of yield keyword always returns an IEnumerable object.
*/ 
using System;
using System.Collections.Generic;


namespace CSharpSpeedrun
{
    class Program
    {
       static void Main(string[] args)
       {
          foreach (int i in Fibonacci(7))
          {
             Console.WriteLine(i);
          } 
       }
 
       public static  IEnumerable<int>  Fibonacci(int range)  
        {  
            int number1 = 0, number2 = 1, result = 0;  
            Console.WriteLine(number1);  
            Console.WriteLine(number2);  
            for (int i = 2; i < range; i++)  
            {  
                result = number1 + number2;  
                yield return result;  
                number1 = number2;  
                number2 = result;  
            }  
        }  
    }
}
/*
0
1
1
2
3
5
8
*/
```

/* What is IEnumerable?
The uppercase I in IEnumerable denotes that it is an interface. It is mostly used to iterate non-generic collections. Above all, the IEnumerable holds the GetEnumerator() method which returns an IEnumerator object.
*/
public interface IEnumerator
{
   bool MoveNext();
   object Current { get; }
   void Reset();
}
                                      using System;
using System.Collections.Generic;

namespace CSharpSpeedrun
{ 
    public class Program
    {
        static void Main()
        {
            int[] ballIds = { 51, 7, 83 };
            List<int> batIds = new List<int>() { 12, 29, 27 }; 

            DisplayIds(ballIds);
            DisplayIds(batIds);
        }

        static void DisplayIds(IEnumerable<int> values)
        {
            foreach (int value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
/*
51
7
83
12
29
27
*/
```

/* What is StringBuilder?
The string data type is designed to be immutable. In other words, once it is created, it cannot be modified. When a string variable is assigned a new value, the compiler creates a new string object in memory. As you can guess, repeatedly assigning new values to variables hinders performance.

The StringBuilder was introduced to solve this issue. It doesn’t create a new string objects, instead, it constantly expands memory to house the newly modified string.
*/
using System;
using System.Text;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello ");
            sb.AppendLine("World!");
            sb.AppendLine("Welcome to CSharpSpeedrun.com");
            Console.WriteLine(sb);
        }
    }  
}
/*
Hello World!
Welcome to CSharp Speedrun.com
*/
```

##
*/

/*
  
*/
```

##
*/

/*
  
*/
```

##
*/

/*
  
*/
```

##
*/

/*
  
*/
```



<details id=1>
<summary><h2>Step 1</h2></summary>
 
</details>
