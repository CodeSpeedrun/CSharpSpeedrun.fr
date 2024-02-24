Obtaining Counts Using Enumerable

When you are projecting new batches of data, you may need to discover exactly how many items have been
returned into the sequence. Any time you need to determine the number of items returned from a LINQ
query expression, simply use the Count()

static void GetCountFromQuery()
{
string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System
Shock 2"};
// Get count from the query.
int numb = (from g in currentVideoGames where g.Length > 6 select g).Count();
// Print

