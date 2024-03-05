Serializing Collections of Objects

Serializing a collection of objects into JSON is done the same as a single object. Add the following local
function to the end of the top-level statements:
static void SaveListOfCarsAsJson(JsonSerializerOptions options, string fileName)
{
//Now persist a List<T> of JamesBondCars.
List<JamesBondCar> myCars = new()
{

new JamesBondCar { CanFly = true, CanSubmerge = true },
new JamesBondCar { CanFly = true, CanSubmerge = false },
new JamesBondCar { CanFly = false, CanSubmerge = true },
new JamesBondCar { CanFly = false, CanSubmerge = false },
};
File.WriteAllText(fileName, System.Text.Json.JsonSerializer.Serialize(myCars, options));
Console.WriteLine("=> Saved list of cars!");
}
To wrap it all up, add the following line to exercise the new function:
SaveListOfCarsAsJson(options, "CarCollection.json");


Deserializing Objects and Collections of Objects
Just like XML deserialization, JSON deserialization is the opposite of serialization. The following function
will deserialize JSON in the type specified using the generic version of the method:
static T ReadAsJsonFormat<T>(JsonSerializerOptions options, string fileName) =>
System.Text.Json.JsonSerializer.Deserialize<T>(File.ReadAllText(fileName), options);
Add the following code to the top-level statements to reconstitute your XML back into objects (or list of
objects):
JamesBondCar savedJsonCar = ReadAsJsonFormat<JamesBondCar>(options, "CarData.json");
Console.WriteLine("Read Car: {0}", savedJsonCar.ToString());
List<JamesBondCar> savedJsonCars = ReadAsJsonFormat<List<JamesBondCar>>(options,
"CarCollection.json");
Console.WriteLine("Read Car: {0}", savedJsonCar.ToString());


