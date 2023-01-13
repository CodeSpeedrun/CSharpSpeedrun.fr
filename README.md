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
