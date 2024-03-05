Serializing Objects Using the JsonSerializer

static void SaveAsJsonFormat<T>(T objGraph, string fileName)
{
File.WriteAllText(fileName,System.Text.Json.JsonSerializer.Serialize(objGraph));
}
Add the following code to your top-level statements:
SaveAsJsonFormat(jbc, "CarData.json");
Console.WriteLine("=> Saved car in JSON format!");
SaveAsJsonFormat(p, "PersonData.json");
Console.WriteLine("=> Saved person in JSON format!");



Including Fields

To include public fields into the generated JSON, you have two options. The other method is to use the
JsonSerializerOptions class to instruct the JsonSerializer to include all fields. The second is to update
your classes by adding the [JsonInclude] attribute to each public field that should be included in the JSON
output.

static void SaveAsJsonFormat<T>(T objGraph, string fileName)
{
var options = new JsonSerializerOptions
{
IncludeFields = true,
};
File.WriteAllText(fileName, System.Text.Json.JsonSerializer.Serialize(objGraph, options));
}


//Radio.cs
public class Radio
{
[JsonInclude]
public bool HasTweeters;
[JsonInclude]
public bool HasSubWoofers;
[JsonInclude]
public List<double> StationPresets;
[JsonInclude]
public string RadioId = "XF-552RR6";
...
}
//Car.cs
public class Car
{
[JsonInclude]
public Radio TheRadio = new Radio();
[JsonInclude]
public bool IsHatchBack;
...
}

//JamesBondCar.cs
public class JamesBondCar : Car
{
[XmlAttribute]
[JsonInclude]
public bool CanFly;
[XmlAttribute]
[JsonInclude]
public bool CanSubmerge;
...
}
//Person.cs
public class Person
{
// A public field.
[JsonInclude]
public bool IsAlive = true;
...
}

