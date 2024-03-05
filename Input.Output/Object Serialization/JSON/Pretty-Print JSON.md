Pretty-Print JSON

JsonSerializer can be instructed to write the JSON
indented (and human readable). Update your method to the following:
static void SaveAsJsonFormat<T>(T objGraph, string fileName)
{
var options = new JsonSerializerOptions
{
IncludeFields = true,
WriteIndented = true
};
File.WriteAllText(fileName, System.Text.Json.JsonSerializer.Serialize(objGraph, options));
}
Now examine the CarData.json file, and the output is much more readable.
{
"CanFly": true,
"CanSubmerge": false,
"TheRadio": {
"HasTweeters": true,
"HasSubWoofers": false,
"StationPresets": [
89.3,
105.1,
97.1
],
"RadioId": "XF-552RR6"
},
"IsHatchBack": false
}

