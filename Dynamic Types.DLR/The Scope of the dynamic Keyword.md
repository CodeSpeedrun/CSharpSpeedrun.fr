The Scope of the dynamic Keyword

The var keyword can never be used as a return value, a parameter, or a member of a class/
structure. This is not the case with the dynamic keyword, however. Consider the following class definition:
namespace DynamicKeyword
{
class VeryDynamicClass
{
// A dynamic field.
private static dynamic _myDynamicField;
// A dynamic property.
public dynamic DynamicProperty { get; set; }
// A dynamic return type and a dynamic parameter type.
public dynamic DynamicMethod(dynamic dynamicParam)
{
// A dynamic local variable.
dynamic dynamicLocalVar = "Local variable";
int myInt = 10;
if (dynamicParam is int)
{
return dynamicLocalVar;
}
else
{
return myInt;


