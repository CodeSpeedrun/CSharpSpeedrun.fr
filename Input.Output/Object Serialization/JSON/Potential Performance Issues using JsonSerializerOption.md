Potential Performance Issues using JsonSerializerOption

When using JsonSerializerOption, it is best to create a single instance and reuse it throughout your
application. With that in mind, update your top-level statements and JSON methods to the following:
JsonSerializerOptions options = new()
{
PropertyNameCaseInsensitive = true,
PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
IncludeFields = true,
WriteIndented = true,
NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.
WriteAsString
};
SaveAsJsonFormat(options, jbc, "CarData.json");
Console.WriteLine("=> Saved car in JSON format!");
SaveAsJsonFormat(options, p, "PersonData.json");
Console.WriteLine("=> Saved person in JSON format!");
static void SaveAsJsonFormat<T>(JsonSerializerOptions options, T objGraph, string fileName)
=> File.WriteAllText(fileName, System.Text.Json.JsonSerializer.Serialize(objGraph,
options));

Web Defaults for JsonSerializer
When building web applications, you can use a specialized constructor to set the following properties:
PropertyNameCaseInsensitive = true,
PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
NumberHandling = JsonNumberHandling.AllowReadingFromString
You can still set additional properties through object initialization, like this:
JsonSerializerOptions options = new(JsonSerializerDefaults.Web)
{
WriteIndented = true
};


