# Overriding `ToString()` Method in C#

In C#, the `ToString()` method is commonly overridden to provide a textual representation of an object's current state. This is particularly useful for debugging purposes, logging, or any situation where a human-readable representation of an object is needed.

## Why Override `ToString()`?

When you create custom classes or structures in C#, the default `ToString()` method inherited from the `Object` class may not provide meaningful information about the object's state. By overriding `ToString()`, you can tailor the output to suit your specific needs.

## Example Implementation

Consider a class representing a person with properties like `FirstName`, `LastName`, and `Age`. Here's how you can override the `ToString()` method to return a formatted string representing the person's details:

```csharp
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    // Override ToString() to provide a customized string representation
    public override string ToString() => $"[First Name: {FirstName}; Last Name: {LastName}; Age: {Age}]";
}
```

In this example:
- `Person` class encapsulates properties representing a person's details.
- The `ToString()` method is overridden within the `Person` class to return a formatted string containing the person's first name, last name, and age.

## Usage

After overriding `ToString()`, you can easily obtain a meaningful string representation of a `Person` object by calling `ToString()` on an instance of the class:

```csharp
Person person = new Person
{
    FirstName = "John",
    LastName = "Doe",
    Age = 30
};

Console.WriteLine(person.ToString()); // Output: [First Name: John; Last Name: Doe; Age: 30]
```

## Additional Considerations

- **Formatting**: The format of the string returned by `ToString()` can be tailored to suit different requirements. You can include additional properties, customize the formatting, or provide additional context as needed.
- **Localization**: Consider localization requirements when formatting strings in `ToString()`, especially if your application needs to support multiple languages or cultures.
- **Consistency**: Ensure consistency in the formatting of `ToString()` across your codebase for improved maintainability and readability.
- **Immutable Types**: For immutable types, `ToString()` can provide a snapshot of the object's state at the time of creation.

By overriding `ToString()` method judiciously, you can enhance the usability and debuggability of your custom classes in C#.
 