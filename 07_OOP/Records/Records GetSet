**Default Behavior with `get` and `set`:**

- **Automatic `Clone` and `with` Methods:** When you declare both `get` and `set` accessors for a property in a record, the compiler automatically generates these methods:
    - `Clone()`: Creates a deep copy of the record instance.
    - `with { ... }`: Enables creation of a new record instance with modified property values based on the original one.
- **Non-Destructive Access and Modification:** The generated accessors ensure non-destructive behavior, meaning accessing or modifying a property doesn't alter the original record instance. It creates a new instance or modified copy as needed.

**Key Considerations:**

- **Immutability and `readonly`:** For truly immutable records, use the `readonly` keyword in the record declaration. This prevents the compiler from generating `set` accessors, enforcing immutability. If you accidentally add `set` accessors to a `readonly` record, the compiler will raise an error.
- **Calculated Properties:** You can define properties with only a `get` accessor to compute values based on other properties or external data. These properties behave like read-only fields and cannot be modified using `set`.
- **Custom Behavior:** If you need to implement specific logic for property access or modification, you can override the automatically generated methods (`Clone()` and the synthesized `get` and `set` accessors). However, it's essential to carefully consider the implications of overriding these methods in terms of record semantics and behavior.

**Example:**

```csharp
public record Person(string Name, int Age)
{
    public string Nickname { get; set; } // Both get and set for optional nickname

    private string CalculateFullName() => $"{Name} (Age: {Age})";

    public string FullName => CalculateFullName(); // Calculated property with only get
}
```

**In summary:**

- Declaring `get` and `set` in a record property enables reading and writing values, providing accessors for modifying the record's state.
- However, for immutable records, use `readonly` to prevent unintended modification and maintain data integrity.
- Be mindful of the generated methods and override them cautiously if necessary.

 