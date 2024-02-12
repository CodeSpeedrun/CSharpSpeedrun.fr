record types are a special type of class. Records are reference types that provide synthesized methods to provide value semantics for equality. By default, record types are immutable by default. While you could essentially create an immutable class but using a combination of init-only setters and read-only properties, record types remove that extra work.

public string Make { get; set; }

once you create an instance of this class, you can change any of the properties
at run time. If each instance needs to be immutable, you can change the property definitions to the following:
public string Make { get; init; }
public string Model { get; init; }

record CarRecord
{
public string Make { get; init; }
public string Model { get; init; }
public string Color { get; init; }
public CarRecord () {}
public CarRecord (string make, string model, string color)
{
Make = make;
Model = model;
Color = color;
}


Recall that record types are a specialized type of class, and classes are
reference types.

