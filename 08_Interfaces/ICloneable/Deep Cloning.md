# A More Elaborate Cloning Example

This example demonstrates object cloning in C#, which allows creating a duplicate of an object while preserving its state. We'll explore how to implement the `ICloneable` interface and handle cloning for objects with nested references.

## PointDescription Class

The `PointDescription` class describes a point with a pet name and a unique identifier (`PointID`). This class is responsible for holding metadata about a point.

```csharp
public class PointMetadata
{
    public string PetName { get; set; }
    public Guid PointID { get; set; }

    public PointMetadata()
    {
        PetName = "No-name";
        PointID = Guid.NewGuid();
    }
}
```

## Point Class

The `Point` class represents a point in a two-dimensional space. It implements the `ICloneable` interface to support cloning.

```csharp
public class CustomPoint : ICloneable
{
    public int XCoordinate { get; set; }
    public int YCoordinate { get; set; }
    public PointMetadata Metadata { get; set; } = new PointMetadata();

    public CustomPoint(int x, int y, string petName)
    {
        XCoordinate = x;
        YCoordinate = y;
        Metadata.PetName = petName;
    }

    public CustomPoint(int x, int y)
    {
        XCoordinate = x;
        YCoordinate = y;
    }

    public CustomPoint() { }

    public override string ToString() =>
        $"X = {XCoordinate}; Y = {YCoordinate}; Name = {Metadata.PetName};\nID = {Metadata.PointID}\n";

    public object Clone()
    {
        CustomPoint newPoint = (CustomPoint)this.MemberwiseClone();
        newPoint.Metadata = new PointMetadata
        {
            PetName = this.Metadata.PetName,
            PointID = this.Metadata.PointID
        };
        return newPoint;
    }
}
```

## Cloning Objects

We demonstrate cloning by creating two `CustomPoint` objects (`point1` and `point2`). We clone `point1` to create `clonedPoint`.

```csharp
Console.WriteLine("***** Fun with Object Cloning *****\n");

CustomPoint point1 = new CustomPoint(100, 100, "Jane");
CustomPoint point2 = new CustomPoint(200, 200, "John");

Console.WriteLine("Original points:");
Console.WriteLine("point1: {0}", point1);
Console.WriteLine("point2: {0}", point2);

CustomPoint clonedPoint = (CustomPoint)point1.Clone();
Console.WriteLine("\nCloned point1 and stored new CustomPoint in clonedPoint");

Console.WriteLine("Cloned point1:");
Console.WriteLine("clonedPoint: {0}", clonedPoint);

Console.ReadLine();
```

## Conclusion

Object cloning is a useful technique for creating copies of objects, especially when dealing with complex object graphs. By implementing the `ICloneable` interface and handling the cloning logic, developers can ensure that objects are duplicated accurately, including any nested references.
 