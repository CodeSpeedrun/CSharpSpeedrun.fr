```markdown
# C# Data Types and Shorthand: Understanding System Types and CLS Compliance

## Introduction
In C#, data types are essential for defining variables and their values. This markdown explores various data types, their range, and shorthand representations in the context of Common Language Specification (CLS) compliance.

### Boolean (bool)
- **CLS Compliant**: Yes
- **Range**: Boolean represents true or false, denoting truth or falsity.

### Signed Byte (sbyte)
- **CLS Compliant**: No
- **Range**: -128 to 127
- **Description**: Signed 8-bit number, allows representation of integer values in the range of -128 to 127.

### Unsigned Byte (byte)
- **CLS Compliant**: Yes
- **Range**: 0 to 255
- **Description**: Unsigned 8-bit number, allowing representation of integer values from 0 to 255.

### Signed Short (short)
- **CLS Compliant**: Yes
- **Range**: -32,768 to 32,767
- **Description**: Signed 16-bit number, enables representation of integer values in the range of -32,768 to 32,767.

### Unsigned Short (ushort)
- **CLS Compliant**: No
- **Range**: 0 to 65,535
- **Description**: Unsigned 16-bit number, capable of representing integer values from 0 to 65,535.

### Signed Integer (int)
- **CLS Compliant**: Yes
- **Range**: -2,147,483,648 to 2,147,483,647
- **Description**: Signed 32-bit integer, suitable for representing integer values within a wide range.

## Code Snippets and Explanation

### Checking Type of a Literal
```csharp
Console.WriteLine("13.GetType() = {0}", 13.GetType());
// Output: 13.GetType() = System.Int32
```
This snippet demonstrates how to determine the data type of a literal value, showcasing the `GetType()` method.

### Char Type Functionality
```csharp
Console.WriteLine("=> char type Functionality:");
char myChar = 'a';
Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}",
char.IsWhiteSpace("Hello There", 5));
Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
char.IsWhiteSpace("Hello There", 6));
Console.WriteLine("char.IsPunctuation('?'): {0}",
char.IsPunctuation('?'));
```
This section demonstrates various functionalities related to the `char` type, such as checking if a character is a digit, letter, whitespace, or punctuation.

### Data Type Parsing
```csharp
Console.WriteLine("=> Data type parsing:");
bool b = bool.Parse("True");
Console.WriteLine("Value of b: {0}", b);
double d = double.Parse("99.884");
Console.WriteLine("Value of d: {0}", d);
int i = int.Parse("8");
Console.WriteLine("Value of i: {0}", i);
char c = Char.Parse("w");
Console.WriteLine("Value of c: {0}", c);
```
Here, data type parsing is demonstrated using various methods like `bool.Parse`, `double.Parse`, `int.Parse`, and `Char.Parse`.

### Data Type Parsing with TryParse
```csharp
Console.WriteLine("=> Data type parsing with TryParse:");
if (bool.TryParse("True", out bool b))
{
Console.WriteLine("Value of b: {0}", b);
}
else
{
Console.WriteLine("Default value of b: {0}", b);
}
```
This snippet illustrates data type parsing using `TryParse` methods, providing a safer approach by avoiding exceptions.

### DateTime Constructor
```csharp
// This constructor takes (year, month, day).
DateTime dt = new DateTime(2015, 10, 17);
```
An example of creating a `DateTime` object using its constructor with parameters for year, month, and day.

 