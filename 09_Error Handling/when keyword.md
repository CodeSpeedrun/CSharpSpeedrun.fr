# Exceptions and the `when` Keyword in C#

Exceptions are a crucial aspect of programming in C#, allowing developers to handle unexpected errors or exceptional conditions in their code gracefully. The `when` keyword is a feature introduced in C# 6.0 that provides a flexible way to filter exceptions, allowing for more granular control over exception handling.

## Exception Handling Basics

In C#, exceptions are objects that represent errors that occur during the execution of a program. When an exceptional condition arises, the runtime system creates an exception object and throws it. The execution of the program then shifts to the nearest enclosing `catch` block that can handle the type of exception thrown.

### Syntax of a `try-catch` Block

```csharp
try
{
    // Code that may throw an exception
}
catch (ExceptionType1 ex)
{
    // Handle ExceptionType1
}
catch (ExceptionType2 ex)
{
    // Handle ExceptionType2
}
finally
{
    // Optional cleanup code
}
```

## Introducing the `when` Keyword

The `when` keyword extends the `catch` clause in a `try-catch` block, allowing for additional conditions to be checked before executing the catch block's code. This provides more control over when a catch block should be executed.

### Syntax of a `catch` Clause with `when`

```csharp
try
{
    // Code that may throw an exception
}
catch (ExceptionType ex) when (Condition)
{
    // Handle ExceptionType if Condition is true
}
```

## Example Usage

Consider a scenario where we have a custom exception `CarIsDeadException`, which represents a situation where a car has encountered a critical failure. We want to handle this exception differently based on the day of the week when it occurred.

### Custom Exception Class

```csharp
public class CarIsDeadException : Exception
{
    public DateTime ErrorTimeStamp { get; }
    
    public CarIsDeadException(DateTime timeStamp, string message) 
        : base(message)
    {
        ErrorTimeStamp = timeStamp;
    }
}
```

### Exception Handling with `when` Clause

```csharp
try
{
    // Code that may throw CarIsDeadException
}
catch (CarIsDeadException ex) when (ex.ErrorTimeStamp.DayOfWeek != DayOfWeek.Monday)
{
    // Handle CarIsDeadException if not occurred on Monday
    Console.WriteLine("Catching car is dead!");
    Console.WriteLine(ex.Message);
}
```

In this example, the `catch` block will only execute if the `ErrorTimeStamp` property of the `CarIsDeadException` object indicates a day of the week other than Monday. This allows for more nuanced handling of exceptions based on additional criteria.

## Benefits of Using `when` Keyword

- **Fine-grained Control**: Developers can specify additional conditions for exception handling, providing more precise control over how exceptions are handled.
  
- **Readability**: Using `when` clauses can improve the readability of code by expressing exception handling logic more directly inline with the catch block.

- **Reduced Code Duplication**: Instead of duplicating code within multiple catch blocks, `when` clauses allow developers to consolidate common exception handling logic while still providing conditional variations.

## Conclusion

The `when` keyword in C# enhances the flexibility and expressiveness of exception handling, enabling developers to write more robust and maintainable code. By incorporating additional conditions into catch blocks, developers can tailor exception handling logic to specific scenarios, improving the overall reliability and readability of their applications.