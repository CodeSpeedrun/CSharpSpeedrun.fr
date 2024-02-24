Building Query Expressions Using the Enumerable Type and Raw
string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System
Shock 2"};
// Build the necessary Func<> delegates.
Func<string, bool> searchFilter =
new Func<string, bool>(Filter);
Func<string, string> itemToProcess =
new Func<string,string>(ProcessItem);
// Pass the delegates into the methods of Enumerable.
var subset =
currentVideoGames
.Where(searchFilter)
.OrderBy(itemToProcess)
.Select(itemToProcess);
// Print out the results.
foreach (var game in subset)

Keep the following points in mind regarding how
LINQ query expressions are represented under the covers:
• Query expressions are created using various C# query operators.
• Query operators are simply shorthand notations for invoking extension methods
defined by the System.Linq.Enumerable type.
• Many methods of Enumerable require delegates (Func<> in particular) as parameters.
• Any method requiring a delegate parameter can instead be passed a lambda
expression.
Lambda expressions are simply anonymous methods in disguise (which greatly
improve readability).
• Anonymous methods are shorthand notations for allocating a raw delegate and
manually building a delegate target method.


