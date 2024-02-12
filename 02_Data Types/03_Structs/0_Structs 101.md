```markdown
# Structure (Value Type)

In C#, structures (also known as value types) are lightweight alternatives to classes. They are used to encapsulate small groups of related variables. Structures are particularly useful when you want to work with simple data types efficiently.

## Definition

```csharp
struct Coordinate
{
    // Fields of the structure.
    public int X;
    public int Y;
    
    // Increment both X and Y coordinates by 1.
    public void Move()
    {
        X++;
        Y++;
    }
}
```

## Characteristics

- **Lightweight:** Structures consume less memory than classes as they are stored on the stack rather than on the heap.
- **Encapsulation:** Like classes, structures can encapsulate data and behavior.
- **Value Type:** Structures are passed by value, meaning they are copied when passed as arguments to methods.

## Usage

Structures are commonly used for representing simple data types such as points, rectangles, and other small data aggregates. Here's an example of how a structure representing a 2D point can be used:

```csharp
Coordinate point = new Coordinate();
point.X = 5;
point.Y = 10;
point.Move(); // Moves the point to (6, 11)
```

## Private Data

If you need to include private data in your structure, you can achieve this by using properties:

```csharp
struct Coordinate
{
    private int x;
    private int y;

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    // Increment both X and Y coordinates by 1.
    public void Move()
    {
        X++;
        Y++;
    }
}
```

## Ref Modifier

The `ref` modifier can be used with structures to ensure they are stack allocated. This prevents them from being assigned as properties of another class.

```csharp
public class Container
{
    public ref Coordinate Coordinate { get; }
    
    public Container(ref Coordinate coordinate)
    {
        Coordinate = ref coordinate;
    }
}
```

In this example, the `Coordinate` property of the `Container` class is a reference to a `Coordinate` structure, ensuring it's stack-allocated and cannot be assigned as a property of another class.
```
