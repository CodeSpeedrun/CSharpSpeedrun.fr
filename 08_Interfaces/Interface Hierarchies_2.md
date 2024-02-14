# Interface Hierarchies with Default Implementations
When dealing with interface hierarchies in C#, it's common to encounter scenarios where interfaces include default implementations. This allows downstream interfaces to either inherit the implementation from the base interface or provide their own default implementation. Let's explore this concept in depth.

## Interface Definitions
```csharp
public interface IRenderable
{
    void Render();
    int TimeToRender() => 5;
}

public interface IEnhancedRender : IRenderable
{
    void RenderInBoundingBox(int top, int left, int bottom, int right);
    void RenderUpsideDown();
    new int TimeToRender() => 15;
}
```

In the above code snippet, we have two interfaces:

- **IRenderable**: This interface defines a method `Render()` and a default implementation of `TimeToRender()`, which returns 5.
- **IEnhancedRender**: This interface extends `IRenderable` and adds two more methods: `RenderInBoundingBox()` and `RenderUpsideDown()`. It also overrides the default implementation of `TimeToRender()` to return 15.

## Class Implementation
```csharp
public class ImageRenderer : IEnhancedRender
{
    // Implementing methods from IEnhancedRender
    public void RenderInBoundingBox(int top, int left, int bottom, int right)
    {
        // Implementation for rendering in a specified bounding box
    }

    public void RenderUpsideDown()
    {
        // Implementation for rendering upside down
    }

    // Overriding the default implementation of TimeToRender()
    public int TimeToRender() => 12;
}
```

Here, we have a class `ImageRenderer` that implements the `IEnhancedRender` interface. It provides implementations for the methods `RenderInBoundingBox()` and `RenderUpsideDown()`, as well as overrides the default implementation of `TimeToRender()`.

## Example Usage
```csharp
class Program
{
    static void Main(string[] args)
    {
        ImageRenderer myRenderer = new ImageRenderer();

        // Demonstrating method calls
        Console.WriteLine("***** Calling Implemented TimeToRender *****");
        Console.WriteLine($"Time to render: {myRenderer.TimeToRender()}");

        // Demonstrating polymorphism
        IRenderable renderable = myRenderer;
        Console.WriteLine($"Time to render (as IRenderable): {renderable.TimeToRender()}");

        IEnhancedRender enhancedRender = myRenderer;
        Console.WriteLine($"Time to render (as IEnhancedRender): {enhancedRender.TimeToRender()}");
    }
}
```

In this example, we create an instance of `ImageRenderer` and showcase how to call its methods. We also demonstrate polymorphism by treating the instance as both `IRenderable` and `IEnhancedRender`, showing how the overridden method behaves in each context.

By utilizing interface hierarchies with default implementations, C# provides a flexible way to structure code and promote code reuse while allowing for customization at different levels of abstraction.