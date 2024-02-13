# Shadowing in C#

In C#, shadowing refers to the concept of defining a member in a derived class that has the same name as a member in the base class, thus "shadowing" the base class's member. This allows the derived class to have its own implementation of the member, effectively hiding the implementation of the base class. Shadowing is the logical opposite of method overriding.

When dealing with inheritance, especially in scenarios where you're subclassing from classes you did not create yourself (e.g., third-party libraries), shadowing can be useful.

## Example Scenario

Suppose you have a base class called `Shape`, which defines a method called `Draw()`.

```csharp
class Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}
```

Now, let's say you want to create a subclass called `ThreeDShape`, which extends `Shape` but provides its own implementation of the `Draw()` method.

```csharp
class ThreeDShape : Shape
{
    public new void Draw()
    {
        Console.WriteLine("Drawing a 3D shape");
    }
}
```

In this example, `ThreeDShape` shadows the `Draw()` method of its base class, `Shape`, with its own implementation. 

## Usage

Shadowing is particularly useful when you want to extend the functionality of a base class but cannot modify the base class directly, such as when working with third-party libraries or frameworks.

## Additional Notes

- Shadowing can be applied not only to methods but also to other member types inherited from a base class, including fields, constants, static members, and properties.
- You can access the shadowed method of the base class by casting an instance of the derived class to the base class type.

```csharp
ThreeDShape threeDShape = new ThreeDShape();
threeDShape.Draw();  // Calls the Draw() method of ThreeDShape
((Shape)threeDShape).Draw();  // Calls the Draw() method of Shape
```

## Conclusion

Shadowing allows for extending and customizing the behavior of classes in an inheritance hierarchy, providing flexibility and modularity in software design. However, it should be used judiciously to avoid confusion and maintain code readability.