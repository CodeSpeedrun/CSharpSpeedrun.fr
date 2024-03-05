PascalCase or camelCase JSON

Pascal casing is a format that uses the first character capitalized and every significant part of a name
capitalized as well.

most of the JavaScript frameworks prefer to use camel casing. This can
be problematic when using .NET and C# to interact with other systems, for example by passing JSON back
and forth between RESTful services.

Fortunately, the JsonSerializer is customizable to handle most situations, including casing
differences. If no naming policy is specified, the JsonSerializer will use Pascal casing when serializing
and deserializing JSON. To change the serialization process to use camel casing, update the options to the
following:
static void SaveAsJsonFormat<T>(T objGraph, string fileName)
{
JsonSerializerOptions options = new()
{
PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
IncludeFields = true,
WriteIndented = true,
};
File.WriteAllText(fileName, System.Text.Json.JsonSerializer.Serialize(objGraph, options));
}
Now, when you execute the calling code, the JSON produced is all camel cased.
{
"canFly": true,
"canSubmerge": false,
"theRadio": {
"hasTweeters": true,
"hasSubWoofers": false,
"stationPresets": [
89.3,
105.1,
97.1
],
"radioId": "XF-552RR6"
},
"isHatchBack": false
}


When reading JSON, C# will by default be case sensitive. The casing matched the setting of the
PropertyNamingPolicy used during Deserialization. If nothing is set, the default (Pascal casing) is used.
By setting the PropertyNamingPolicy to camel case, then all incoming JSON is expected to be in camel case.
If the casing does not match, the deserialization process (covered soon) fails.
There is a third option when deserializing JSON, and that is casing indifference. By setting the
PropertyNameCaseInsensitive option to true, then C# will deserialize canSubmerge as well as CanSubmerge.
Here is the code to set the option:
JsonSerializerOptions options = new()
{
PropertyNameCaseInsensitive = true,
IncludeFields = true
};


