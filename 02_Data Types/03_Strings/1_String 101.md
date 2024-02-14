# System.String Member Functions

## Introduction
In C#, `System.String` is a fundamental data type representing text as a sequence of characters. Here are some essential member functions and operations related to string manipulation.

## String Member Functions and Their Meaning in Life

- `Length`: Returns the length of the string.
- `Compare()`: Compares two strings.
- `Contains()`: Determines if a string contains a specific substring.
- `Equals()`: Tests if two strings contain identical character data.
- `Format()`: Formats a string using other primitives.
- `Insert()`: Inserts a string within another string.
- `PadLeft()` / `PadRight()`: Pads a string with characters.
- `Remove()` / `Replace()`: Modifies a string by removing or replacing characters.
- `Split()`: Splits a string into substrings based on a delimiter.
- `Trim()`: Removes specified characters from the beginning and end of a string.
- `ToUpper()` / `ToLower()`: Converts a string to uppercase or lowercase.

## Examples and Explanation

### String Concatenation
```csharp
string s1 = "Programming the ";
string s2 = "PsychoDrill (PTP)";
string s3 = s1 + s2;
```

### String Formatting
```csharp
int age = 4;
string name = "Soren";

// Using string.Format()
string greeting = string.Format("Hello {0} you are {1} years old.", name, age);
Console.WriteLine(greeting);

// Using string interpolation
string greeting2 = $"Hello {name} you are {age} years old.";
Console.WriteLine(greeting2);

// Using ToUpper() method
string greeting = string.Format("Hello {0} you are {1} years old.", name.ToUpper(), age);
string greeting2 = $"Hello {name.ToUpper()} you are {age} years old.";
```

### Escaping Characters
```csharp
Console.WriteLine(@"C:\MyApp\bin\Debug");
```

### String Comparison
```csharp
Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));

if (firstString.ToUpper() == secondString.ToUpper())
{
    //Do something
}
```
 
```csharp
// Comparing strings with different comparison rules to demonstrate the effect of changing the default rules.
Console.WriteLine("Default rules: str1={0}, str2={1}, str1.Equals(str2): {2}", str1, str2, str1.Equals(str2));
Console.WriteLine("Ignore case: str1.Equals(str2, StringComparison.OrdinalIgnoreCase): {0}", str1.Equals(str2, StringComparison.OrdinalIgnoreCase));
Console.WriteLine("Ignore case, Invariant Culture: str1.Equals(str2, StringComparison.InvariantCultureIgnoreCase): {0}", str1.Equals(str2, StringComparison.InvariantCultureIgnoreCase));
Console.WriteLine();
Console.WriteLine("Default rules: str1={0}, str2={1}, str1.IndexOf(\"E\"): {2}", str1, str2, str1.IndexOf("E"));
Console.WriteLine("Ignore case: str1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase): {0}", str1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
Console.WriteLine("Ignore case, Invariant Culture: str1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {0}", str1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
Console.WriteLine();

// After initializing a string object, its character data cannot be changed.
// Unlike StringBuilder, which allows modifying or formatting segments of a string.
StringBuilder stringBuilder = new StringBuilder("**** Amazing Games ****");
stringBuilder.Append("\n");
stringBuilder.AppendLine("Half Life");
```

### String Comparison Rules

When comparing strings in C#, it's essential to understand the various comparison rules available. This ensures that the comparison behaves as expected in different scenarios, especially when dealing with internationalization and case sensitivity.

#### Default Rules

By default, string comparisons in C# are case-sensitive and culture-sensitive. This means that differences in casing or culture-specific characters will affect the comparison results.

#### Ignoring Case

To perform a case-insensitive comparison, you can use the `StringComparison.OrdinalIgnoreCase` option. This treats uppercase and lowercase characters as equivalent.

#### Invariant Culture Comparison

Comparing strings using the invariant culture ensures that cultural differences are ignored. This is useful when you need consistent comparison behavior across different cultures. The `StringComparison.InvariantCultureIgnoreCase` option combines case insensitivity with culture insensitivity.

### String Modification

In C#, the `System.String` class is immutable, meaning once a string object is created with its initial value, the character data cannot be changed. However, the `StringBuilder` class provides methods for modifying or formatting segments of a string efficiently.

### StringBuilder Example

In the provided code snippet, a `StringBuilder` object named `stringBuilder` is initialized with an initial string value. The `Append` method is then used to add a string and the `AppendLine` method to append a string followed by a newline character. This demonstrates how `StringBuilder` allows dynamic modification of string content.
