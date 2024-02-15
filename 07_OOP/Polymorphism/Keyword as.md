## "as" keyword 
- CSharp provides the "as" keyword to quickly determine at runtime whether a given type is compatible with another. 
- When you use the "as" keyword, you are able to determine compatibility by checking against a null return value.
```csharp
// Use "as" to test compatibility.
object[] items = new object[4]; // Renamed variable 'things' to 'items'
items[0] = new CustomShape(); // Renamed class 'Hexagon' to 'CustomShape'
items[1] = false;
items[2] = new DepartmentHead(); // Renamed class 'Manager' to 'DepartmentHead'
items[3] = "Last item";
foreach (object obj in items) // Renamed variable 'item' to 'obj'
{
    CustomShape shape = obj as CustomShape; // Renamed class 'Hexagon' to 'CustomShape'
    if (shape == null)
    {
        Console.WriteLine("Item is not a custom shape"); // Updated message
    }
    else
    {
        shape.Draw(); // Invoking Draw method on CustomShape
    }
}
```

### C# Type Compatibility with "as" Keyword

In C#, the `as` keyword allows for dynamic type checking at runtime to determine if a given object is compatible with a specific type. If the object is compatible, the `as` keyword performs a cast to that type; otherwise, it returns `null`. This is particularly useful when dealing with collections of mixed types where you want to selectively operate on objects of a specific type.

#### Syntax
```csharp
object result = obj as TargetType;
```

- `obj`: The object to check compatibility against.
- `TargetType`: The type to check compatibility with.

#### Example Usage

```csharp
CustomShape shape = obj as CustomShape;
```

In this example:
- `obj` is the object being checked.
- `CustomShape` is the target type being checked for compatibility.
- If `obj` is compatible with `CustomShape`, `shape` will reference that object; otherwise, `shape` will be `null`.

#### Use Cases
- Checking compatibility before casting to avoid runtime errors.
- Working with heterogeneous collections of objects.

#### Caveats
- The `as` keyword only works with reference types and nullable types; it cannot be used with value types.
- It is generally less performant than direct casting (`(CustomShape)obj`) but safer when compatibility is uncertain.

 