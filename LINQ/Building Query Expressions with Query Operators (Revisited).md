Building Query Expressions with Query Operators (Revisited)

string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System
Shock 2"};
var subset = from game in currentVideoGames
where game.Contains(" ") orderby game select game;

obvious benefit of using C# query operators to build query expressions is that the Func<> delegates
and calls on the Enumerable type are out of sight and out of mind, as it is the job of the C# compiler to
perform this translation. To be sure, building LINQ expressions using various query operators (from, in,
where, or orderby) is the most common and straightforward approach.

