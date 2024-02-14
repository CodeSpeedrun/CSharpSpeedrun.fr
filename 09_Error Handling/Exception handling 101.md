### Handling Exceptions in C#

When developing applications, it's crucial to anticipate and handle various types of errors gracefully. In C#, exceptions provide a robust mechanism for dealing with runtime anomalies. Let's delve into the intricacies of structured exception handling in C#.

#### Introduction to Exceptions

Exceptions represent unexpected conditions or errors that occur during the execution of a program. They can arise due to various factors such as erroneous user input, system malfunctions, or logical errors in the code. Handling exceptions appropriately is essential for maintaining the stability and reliability of your application.

#### Types of Errors

1. **Bugs**: These are coding errors introduced by the programmer during development. They can include syntax errors, logic flaws, or incorrect implementations.

2. **User Errors**: User errors occur when end-users interact with the application in unintended ways. These errors are often the result of invalid input or misuse of features.

#### Exception Handling Constructs

C# provides several constructs for managing exceptions effectively:

##### 1. `try`, `catch`, `finally`, `throw`:

```csharp
try
{
    // Code that may throw exceptions
}
catch (ExceptionType ex)
{
    // Handle specific exception types
}
finally
{
    // Cleanup code that executes regardless of whether an exception occurred
}
```

- **`try`**: Encloses the code that might throw exceptions.
- **`catch`**: Catches and handles specific types of exceptions.
- **`finally`**: Executes cleanup code regardless of whether an exception occurred.
- **`throw`**: Explicitly raises an exception.

##### 2. `when` Clause:

```csharp
try
{
    // Code that may throw exceptions
}
catch (ExceptionType ex) when (condition)
{
    // Handle exception if condition is met
}
```

- Allows for additional conditions to be checked before entering the catch block.

#### Example: Handling Invalid Input

```csharp
public class InputValidator
{
    public void ValidateInput(string input)
    {
        try
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input), "Input cannot be null or empty.");
            }
            // Further validation logic
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            // Additional error handling or logging
        }
    }
}
```

In this example, the `InputValidator` class contains a method `ValidateInput` that checks for null or empty input. If the input is invalid, it throws an `ArgumentNullException`, which is caught and handled within the `try-catch` block.

#### Conclusion

Exception handling is an essential aspect of robust software development. By utilizing constructs like `try-catch-finally`, developers can gracefully manage unexpected errors and maintain the reliability of their applications. Understanding and implementing effective exception handling practices is crucial for building resilient software systems.



## Understanding Custom Exceptions in C#

In C#, exceptions play a vital role in managing errors and unexpected situations within your code. Every exception in C# is derived from the `System.Exception` base class, which in turn derives from `System.Object`.

### The Custom Exception Class

Let's begin by examining a custom exception class. In this example, we'll create a custom exception called `CustomException` which extends `Exception`. This class will provide constructors for different scenarios and override the `GetBaseException()` method:

```csharp
public class CustomException : Exception
{
    // Constructors
    public CustomException(string message, Exception innerException) : base(message, innerException) { }
    public CustomException(string message) : base(message) { }
    public CustomException() { }

    // Method
    public override Exception GetBaseException()
    {
        // Custom implementation
        return base.GetBaseException();
    }
}
```

### Throwing Custom Exceptions

Using custom exceptions allows for better organization and specificity when handling errors in your application. Below is an example of how you might use the `CustomException` class to handle a situation where a car's engine overheats:

```csharp
try
{
    if (currentSpeed >= maxSpeed)
    {
        currentSpeed = 0;
        carIsDead = true;
        throw new CustomException($"{carName} has overheated!");
    }
}
catch (CustomException ex)
{
    Console.WriteLine("\n*** Error! ***");
    Console.WriteLine("Message: {0}", ex.Message);
    Console.WriteLine("Source: {0}", ex.Source);
}
```

### Retrieving Additional Information

When handling exceptions, it's often helpful to retrieve additional information about the error. For instance, you might want to know the method where the exception occurred. In C#, this can be achieved using the `TargetSite` property:

```csharp
catch (CustomException ex)
{
    Console.WriteLine("\n*** Error! ***");
    Console.WriteLine("Method: {0}", ex.TargetSite);
    // Additional handling
}
```

### Understanding Stack Traces

The `StackTrace` property provides a snapshot of the call stack at the time the exception was thrown. This information can be invaluable for debugging purposes:

```csharp
catch (CustomException ex)
{
    Console.WriteLine("\n*** Error! ***");
    Console.WriteLine("StackTrace: {0}", ex.StackTrace);
    // Additional handling
}
```

### Providing Help Links

In scenarios where you want to guide users to additional resources for troubleshooting, the `HelpLink` property comes in handy:

```csharp
catch (CustomException ex)
{
    Console.WriteLine("\n*** Error! ***");
    Console.WriteLine("Message: {0}", ex.Message);
    Console.WriteLine("HelpLink: {0}", ex.HelpLink);
    // Additional handling
}
```

### Conclusion

Custom exceptions enhance the robustness and clarity of your code by allowing you to define specific error conditions and handle them appropriately. By leveraging properties like `TargetSite`, `StackTrace`, and `HelpLink`, you can provide detailed information to aid in debugging and problem resolution.


### Handling Exceptions in C#

In C#, exception handling is a crucial aspect of writing robust and reliable code. Exceptions allow developers to handle unexpected situations gracefully, providing mechanisms to capture errors, diagnose issues, and handle them appropriately. This markdown document provides an overview of exception handling in C# with code examples and explanations.

#### The `Data` Property of `System.Exception`

The `Data` property of the `System.Exception` class allows you to associate additional information with an exception. This information can be useful for providing context about the error.

```csharp
throw new Exception($"{VehicleName} has encountered an issue!")
{
    HelpLink = "http://www.VehiclesRUs.com",
    Data = {
        {"TimeStamp", $"The vehicle encountered a problem at {DateTime.Now}"},
        {"Cause", "Potential mechanical failure"}
    }
};
```

In this example, an exception is thrown with a custom message indicating the name of the vehicle and additional data stored in the `Data` property, such as a timestamp and a possible cause of the error.

#### Custom Exception Classes

Custom exception classes allow developers to create specialized exceptions tailored to specific scenarios. This enhances code readability and maintainability.

```csharp
public class VehicleMalfunctionException : Exception
{
    public VehicleMalfunctionException(string message, string cause, DateTime time)
        : base(message)
    {
        CauseOfMalfunction = cause;
        ErrorTimeStamp = time;
    }

    public string CauseOfMalfunction { get; }
    public DateTime ErrorTimeStamp { get; }
}
```

Here, a custom exception class `VehicleMalfunctionException` is defined, inheriting from the `Exception` base class. It includes additional properties such as `CauseOfMalfunction` and `ErrorTimeStamp` to provide more context about the error.

#### Throwing a Custom Exception

```csharp
throw new VehicleMalfunctionException("Potential engine failure",
    DateTime.Now, $"{VehicleName} has encountered an issue!")
{
    HelpLink = "http://www.VehiclesRUs.com",
};
```

This code snippet demonstrates how to throw a custom exception (`VehicleMalfunctionException`) with specific details about the error, including the cause, timestamp, and a custom message.

#### Exception Handling

```csharp
try
{
    // Code that may throw an exception
}
catch (VehicleMalfunctionException ex)
{
    // Handle specific custom exception
    Console.WriteLine($"Error: {ex.Message}");
    Console.WriteLine($"Cause: {ex.CauseOfMalfunction}");
    Console.WriteLine($"Timestamp: {ex.ErrorTimeStamp}");
}
catch (Exception ex)
{
    // Handle other types of exceptions
    Console.WriteLine($"Unhandled error: {ex.Message}");
}
finally
{
    // Code that always executes, regardless of whether an exception occurred
}
```

In a `try` block, code that may potentially throw an exception is enclosed. `catch` blocks allow handling specific types of exceptions, including custom ones like `VehicleMalfunctionException`. The `finally` block executes cleanup code, regardless of whether an exception occurred.

#### Conclusion

Exception handling is an essential aspect of writing reliable and maintainable code in C#. By understanding how to handle exceptions effectively, developers can create more robust applications that gracefully handle errors and provide meaningful feedback to users. Custom exception classes and the `Data` property of `System.Exception` further enhance the ability to capture and manage errors in a structured manner.