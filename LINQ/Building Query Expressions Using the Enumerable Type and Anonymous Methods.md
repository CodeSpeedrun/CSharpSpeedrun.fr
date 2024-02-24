Building Query Expressions Using the Enumerable Type
and Anonymous Methods

string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System
Shock 2"};
// Build the necessary Func<> delegates using anonymous methods.
Func<string, bool> searchFilter = delegate(string game) { return game.Contains(" "); };
Func<string, string> itemToProcess = delegate(string s) { return s; };
// Pass the delegates into the methods of Enumerable.
var subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcess).
Select(itemToProcess);
// Print out the results.
foreach (var game in subset)

