Accessors and Mutators

Employee emp = new Employee();
// Error! Cannot directly access private members
// from an object!
emp._empName = "Marv";

class Employee
{
// Field data.
private string _empName;
...
// Accessor (get method).
public string GetName() => _empName;
// Mutator (set method).
public void SetName(string name)
{
// Do a check on incoming value
// before making assignment.
if (name.Length > 15)
{
Console.WriteLine("Error! Name length exceeds 15 characters!");
}
else
{
_empName = name;
}