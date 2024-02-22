Returning LINQ Results via Immediate Execution
static string[] GetStringSubsetAsArray()
{
string[] colors = {"Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple"};
var theRedColors = from c in colors where c.Contains("Red") select c;
// Map results into an array.
return theRedColors.ToArray();
}
With this, the caller can be blissfully unaware that their result came from a LINQ query and simply work
with the array of strings as expected. Here’s an example:
foreach (string item in GetStringSubsetAsArray())
{

    