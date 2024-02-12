using a technique termed constructor chaining. This
design pattern is helpful when you have a class that defines multiple constructors.

each constructor is ensuring that
the intensity level is never greater than 10. While this is all well and good, you do have redundant code
statements in two constructors.

class Motorcycle
{
public int driverIntensity;
public string driverName;
// Constructor chaining.
public Motorcycle() {}
public Motorcycle(int intensity)
: this(intensity, "") {}
public Motorcycle(string name)
: this(0, name) {}
// This is the 'master' constructor that does all the real work.
public Motorcycle(int intensity, string name)
{
if (intensity > 10)
{
intensity = 10;
}
driverIntensity = intensity;
driverName = name;
}


class Motorcycle
{
public int driverIntensity;
public string driverName;
// Constructor chaining.
public Motorcycle()
{
Console.WriteLine("In default ctor");
}
public Motorcycle(int intensity)
: this(intensity, "")
{
Console.WriteLine("In ctor taking an int");
}
public Motorcycle(string name)
: this(0, name)
{
Console.WriteLine("In ctor taking a string");
}
// This is the 'master' constructor that does all the real work.
public Motorcycle(int intensity, string name)
{
Console.WriteLine("In master ctor ");
if (intensity > 10)
{
intensity = 10;
}
driverIntensity = intensity;
driverName = name;
}