Building Query Expressions Using the Enumerable Type and Lambda
string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System
Shock 2"};
// Build a query expression using extension methods
// granted to the Array via the Enumerable type.
var subset = currentVideoGames
.Where(game => game.Contains(" "))
.OrderBy(game => game).Select(game => game);

string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System
Shock 2"};
// Break it down!
var gamesWithSpaces = currentVideoGames.Where(game => game.Contains(" "));
var orderedGames = gamesWithSpaces.OrderBy(game => game);
var subset = orderedGames.Select(game => game);

