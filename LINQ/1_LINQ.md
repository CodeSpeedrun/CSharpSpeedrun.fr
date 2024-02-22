data can be found in numerous
locations, including XML files, relational databases, in-memory collections, and primitive arrays.


(LINQ) technology set, introduced initially in .NET 3.5, provides a
concise, symmetrical, and strongly typed manner to access a wide variety of data stores


you will find that implicitly
typed local variables, object initialization syntax, lambda expressions, extension methods, and anonymous
types will be quite useful


recommend you try your best to regard LINQ
queries as unique statements, which just “happen to look” like SQL.



(e.g., only the odd or even members in the container, only prime numbers, only
nonrepeating numbers greater than 50). Or perhaps you are making use of the reflection APIs and need
to obtain only metadata descriptions for each class deriving from a parent class within an array of Types.
Indeed, data is everywhere.



The Data You Want How to Obtain It
Relational data System.Data.dll, System.Data.SqlClient.dll, etc.
XML document data System.Xml.dll
Metadata tables The System.Reflection namespace
Collections of objects System.Array and the System.Collections/System.Collections.Generic
namespaces


a LINQ query expression (unlike a traditional SQL statement) is
strongly typed.
using System.Linq;

static void QueryOverStrings()
{
// Assume we have an array of strings.
string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System
Shock 2"};
// Build a query expression to find the items in the array
// that have an embedded space.
IEnumerable<string> subset =
from g in currentVideoGames
where g.Contains(" ")
orderby g
select g;




Once Again, Using Extension Methods
static void QueryOverStringsWithExtensionMethods()
{
// Assume we have an array of strings.
string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System
Shock 2"};
// Build a query expression to find the items in the array
// that have an embedded space.
IEnumerable<string> subset =
currentVideoGames.Where(g => g.Contains(" ")).OrderBy(g => g).Select(g => g);
// Print

This is using the extension
method syntax. This syntax uses lambda expressions within each method to define the operation. For
example, the lambda in the Where() method defines the condition (where a value contains a space). Just
as in the query expression syntax, the letter used to indicate the value being evaluated in the lambda is
arbitrary; I could have used v for video games.



