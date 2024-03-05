Creating the Samples Types and Top-Level Statements

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace SimpleSerialize
{
public class Radio
{
public bool HasTweeters;
public bool HasSubWoofers;
public List<double> StationPresets;
public string RadioId = "XF-552RR6";
public override string ToString()
{
var presets = string.Join(",", StationPresets.Select(i => i.ToString()).ToList());
return $"HasTweeters:{HasTweeters} HasSubWoofers:{HasSubWoofers} Station
Presets:{presets}";
}
}
}
Next, add a class named Car.cs, and update the code to match this listing:
using System;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;
namespace SimpleSerialize
{
public class Car
{
public Radio TheRadio = new Radio();
public bool IsHatchBack;
public override string ToString()
=> $"IsHatchback:{IsHatchBack} Radio:{TheRadio.ToString()}";
}
}
Next, add another class named JamesBondCar.cs and use the following code for this class:
using System;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;
namespace SimpleSerialize
{
public class JamesBondCar : Car
{
public bool CanFly;
public bool CanSubmerge;
public override string ToString()
=> $"CanFly:{CanFly}, CanSubmerge:{CanSubmerge} {base.ToString()}";
}
}


using System;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;
namespace SimpleSerialize
{
public class Person
{
// A public field.
public bool IsAlive = true;
// A private field.
private int PersonAge = 21;
// Public property/private data.
private string _fName = string.Empty;
public string FirstName
{
get { return _fName; }
set { _fName = value; }
}
public override string ToString() =>
$"IsAlive:{IsAlive} FirstName:{FirstName} Age:{PersonAge} ";
}
}
Finally, update the Program.cs class to the following starter code:
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;
using SimpleSerialize;
Console.WriteLine("***** Fun with Object Serialization *****\n");
// Make a JamesBondCar and set state.
JamesBondCar jbc = new()
{
CanFly = true,
CanSubmerge = false,
TheRadio = new()
{
StationPresets = new() {89.3, 105.1, 97.1},
HasTweeters = true
}
};

Person p = new()
{
FirstName = "James",
IsAlive = true
};

