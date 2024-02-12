However, it is not uncommon for
a class to have dozens of fields to contend with. Clearly, it would be undesirable to author 20 initialization
statements to set 20 points of data!
Thankfully, C# supports the use

C# supports the use of constructors, which allow the state of an object to be established at
the time of creation.

class Car
{
// The 'state' of the Car.
public string petName;
public int currSpeed;
// A custom default constructor.
public Car()
{
petName = "Chuck";
currSpeed = 10;
}
...
}

what makes one constructor different from another (in the eyes of the C# compiler)
is the number of and/or type of constructor arguments.

Constructors (as well as field and property initializers, covered later) can use out parameters



class Motorcycle
{
// Single constructor using optional args.
public Motorcycle(int intensity = 0, string name = "")
{

static void MakeSomeBikes()
{
// driverName = "", driverIntensity = 0
Motorcycle m1 = new Motorcycle();
Console.WriteLine("Name= {0}, Intensity= {1}",
m1.driverName, m1.driverIntensity);
// driverName = "Tiny", driverIntensity = 0
Motorcycle m2 = new Motorcycle(name:"Tiny");
Console.WriteLine("Name= {0}, Intensity= {1}",
m2.driverName, m2.driverIntensity);
// driverName = "", driverIntensity = 7
Motorcycle m3 = new Motorcycle(7);
Console.WriteLine("Name= {0}, Intensity= {1}",
m3.driverName, m3.driverIntensity);
}

