Returning the Result of a LINQ Query
It is possible to define a field within a class (or structure) whose value is the result of a LINQ query. To do
so, however, you cannot use implicit typing (as the var keyword cannot be used for fields), and the target of
the LINQ query cannot be instance-level data; therefore, it must be static. Given these limitations, you will
seldom need to author code like the following:
class LINQBasedFieldsAreClunky
{
private static string[] currentVideoGames =
{"Morrowind", "Uncharted 2",
"Fallout 3", "Daxter", "System Shock 2"};
// Can't use implicit typing here! Must know type of subset!
private IEnumerable<string> subset =
from g in currentVideoGames
where g.Contains(" ")
orderby g
select g;
public void PrintGames()
{
foreach (var item in subset)

Console.WriteLine("***** LINQ Return Values *****\n");
IEnumerable<string> subset = GetStringSubset();
foreach (string item in subset)
{
Console.WriteLine(item);
}
static IEnumerable<string> GetStringSubset()
{
string[] colors = {"Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple"};
// Note subset is an IEnumerable<string>-compatible object.
IEnumerable<string> theRedColors = from c in colors where c.Contains("Red") select c;
return theRedColors;
}


