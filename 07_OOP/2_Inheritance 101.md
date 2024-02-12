the language’s ability to allow you to build new class
definitions based on existing class definitions. In essence, inheritance allows you to extend the behavior of
a base (or parent) class by inheriting core functionality into the derived subclass (also called a child class).

The “is-a”
relationship is termed inheritance.

“A Hexagon is-a Shape that is-an Object.”

Under the .NET/.NET Core platforms, System.Object is always the topmost parent in any class
hierarchy, which defines some general functionality for all types

the containment/delegation model also
known as the “has-a” relationship or aggregation. This form of reuse is not used to establish parent-child
relationships. Rather, the “has-a” relationship allows one class to define a member variable of another class
and expose its functionality (if required) to the object user indirectly.

For example, assume you are again modeling an automobile. You might want to express the idea that
a car “has-a” radio. It would be illogical to attempt to derive the Car class from a Radio or vice versa (a Car
“is-a” Radio?

class Car
{
// Car 'has-a' Radio.
private Radio myRadio = new Radio();
public void TurnOnRadio(bool onOff)
{
// Delegate call to inner object.
myRadio.Power(onOff);
}
