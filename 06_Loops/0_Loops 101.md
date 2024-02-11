# Loops in C#

Loops are fundamental constructs in programming languages that allow the repetition of a block of code until a certain condition is met. In C#, there are several types of loops, each serving a different purpose.

## 1. for Loop

The `for` loop in C# is a control flow statement for iterating a specific number of times. It consists of three parts: initialization, condition, and increment/decrement.

```csharp
for(int index = 0; index < 4; index++)
{
    Console.WriteLine("Number is: {0} ", index);
}
```

### Example:
```csharp
for(int i = 0; i <= 10; i += 2)
{
    Console.WriteLine(i);
}
```

## 2. foreach Loop

The `foreach` loop in C# is used to iterate over elements of collections or arrays. It simplifies the code and makes it more readable compared to traditional `for` loops.

```csharp
string[] carBrands = {"Ford", "BMW", "Yugo", "Honda"};
foreach (string brand in carBrands)
{
    Console.WriteLine(brand);
}
```

### Example:
```csharp
List<int> numbers = new List<int>{1, 2, 3, 4, 5};
foreach (int num in numbers)
{
    Console.WriteLine(num * num);
}
```

## 3. while Loop

The `while` loop in C# repeatedly executes a target statement as long as a given condition is true. It evaluates the condition before executing the loop body.

```csharp
int count = 0;
while (count < 5)
{
    Console.WriteLine("Count: {0}", count);
    count++;
}
```

### Example:
```csharp
int userInput;
while (!int.TryParse(Console.ReadLine(), out userInput))
{
    Console.WriteLine("Invalid input. Please enter an integer.");
}
```

## 4. do/while Loop

The `do/while` loop in C# is similar to the `while` loop, but it ensures that the code block is executed at least once, regardless of whether the condition is initially true or false.

```csharp
int number = 5;
do
{
    Console.WriteLine("Number: {0}", number);
    number--;
} while (number > 0);
```

### Example:
```csharp
string answer;
do
{
    Console.WriteLine("Do you want to continue? (yes/no)");
    answer = Console.ReadLine().ToLower();
} while (answer != "yes" && answer != "no");
```

The difference between the `do/while` loop and the `while` loop is that `do/while` loops are guaranteed to execute the corresponding block of code at least once. In contrast, it is possible that a simple `while` loop may never execute if the terminating condition is false from the onset.