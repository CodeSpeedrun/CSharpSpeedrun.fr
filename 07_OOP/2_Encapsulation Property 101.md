Although you can encapsulate a piece of field data using traditional get and set methods, .NET Core
languages prefer to enforce data encapsulation state data using properties.

// The 'int' represents the type of data this property encapsulates.
public int Id // Note lack of parentheses.
{
get { return _empId; }
set { _empID = value; }
}

a token named value, which is used to represent the incoming
value used to assign the property by the caller. This token is not a true C# keyword but is what is known as
a contextual keyword. When the token value is within the set scope of the property, it always represents the
value being assigned by the caller, and it will always be the same underlying data type as the property itself.

// New field and property.
private int _empAge;
public int Age
{
get { return _empAge; }
set { _empAge = value; }
}

Properties As Expression-Bodied Members  
As mentioned previously, property get and set accessors can also be written as expression-bodied
members. The rules and syntax are the same: single-line methods can be written using the new syntax. So,
the Age property could be written like this:
public int Age
{
get => empAge;
set => empAge = value;
}

read-only property. To do so, simply omit the set block.

if the goal is to prevent the modification of the number from outside the class, then declare
the get method as public but the set method as private, like this:
public string SocialSecurityNumber


// A static property.
public static double InterestRate
{
get { return _currInterestRate; }
set { _currInterestRate = value; }
}


properties to encapsulate your data, it is common to find that the set scopes
have code to enforce business rules of your program. However, in some cases, you may not need any
implementation logic beyond simply getting and setting the value.

class Car
{
private string carName = "";
public string PetName
{
get { return carName; }
set { carName = value; }
}

class Car
{
// Automatic properties! No need to define backing fields.
public string PetName { get; set; }

// The hidden int backing field is set to zero!
public int NumberOfCars { get; set; }
// The hidden Car backing field is set to null!
public Car MyAuto { get; set; }


// The hidden backing field is set to 1.
public int NumberOfCars { get; set; } = 1;
// The hidden backing field is set to a new Car object.
public Car MyAuto { get; set; } = new Car();

init-Only Setters (New 9.0)
A new feature added in C# 9.0 is init-only setters. These setters enable a property to have its value set
during initialization, but after construction is complete on the object, the property becomes read-only.
These types of properties are call immutable. Add a new class file named ReadOnlyPointAfterCreation.

class PointReadOnlyAfterCreation
{
public int X { get; init; }
//The next two lines will not compile
secondReadonlyPoint.X = 10;
secondReadonlyPoint.Y = 10;


public const double PI = 3.14;
Closely related to constant data is the notion of read-only field data (which should not be confused with a readonly
property).
However, unlike a constant, the value assigned to a read-only field can be determined at
runtime and, therefore, can legally be assigned within the scope of a constructor but nowhere else.
class MyMathClass
{
// Read-only fields can be assigned in ctors,
// but nowhere else.
public readonly double PI;
public MyMathClass ()
{
PI = 3.14;
}

Static Read-Only Fields
Unlike a constant field, read-only fields are not implicitly static. Thus, if you want to expose PI from the class
level, you must explicitly use the static keyword.

However, if the value of a static read-only field is not known until runtime, you must use a static
constructor as described earlier in this chapter.
class MyMathClass
{
public static readonly double PI;

