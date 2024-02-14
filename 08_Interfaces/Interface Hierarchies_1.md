# Designing Interface Hierarchies

Interface hierarchies are essential for software development, allowing you to extend the functionality of existing interfaces without disrupting the existing codebase.

## `IDrawable` Interface

```csharp
public interface IDrawable
{
    void Draw();
}
```

The `IDrawable` interface declares a `Draw()` method, defining the basic behavior for any drawable object.

## `IAdvancedDraw` Interface

```csharp
public interface IAdvancedDraw : IDrawable
{
    void DrawInCustomBox(int top, int left, int bottom, int right);
    void DrawFlipped();
}
```

The `IAdvancedDraw` interface extends `IDrawable` and introduces additional methods: `DrawInCustomBox()` and `DrawFlipped()`, providing more advanced drawing capabilities.

## `CustomImageRenderer` Class

```csharp
public class CustomImageRenderer : IAdvancedDraw
{
    public void Draw()
    {
        Console.WriteLine("Basic drawing...");
    }

    public void DrawInCustomBox(int top, int left, int bottom, int right)
    {
        Console.WriteLine("Drawing within a custom box...");
    }

    public void DrawFlipped()
    {
        Console.WriteLine("Drawing flipped...");
    }
}
```

The `CustomImageRenderer` class implements the `IAdvancedDraw` interface, offering concrete implementations for each method, catering to custom rendering needs.

## Example Usage

```csharp
// Create an instance of CustomImageRenderer
CustomImageRenderer renderer = new CustomImageRenderer();

// Call the basic drawing method
renderer.Draw();

// Call the method to draw within a custom box
renderer.DrawInCustomBox(30, 30, 300, 350);

// Call the method to draw flipped
renderer.DrawFlipped();
```

Here, we demonstrate the usage of the `CustomImageRenderer` class by invoking its drawing methods. These methods leverage the functionalities defined in the `IAdvancedDraw` interface.

## Explicit Interface Implementation

```csharp
// Explicitly access IAdvancedDraw methods
if (renderer is IAdvancedDraw advancedRenderer)
{
    advancedRenderer.DrawFlipped();
}
```

This code illustrates how to access the methods defined in the `IAdvancedDraw` interface explicitly from an instance of `CustomImageRenderer`.

## Conclusion

Interface hierarchies play a crucial role in software design, enabling the creation of modular and extensible systems. The example showcased here demonstrates how interface hierarchies can be utilized to develop flexible rendering solutions, catering to diverse application requirements.