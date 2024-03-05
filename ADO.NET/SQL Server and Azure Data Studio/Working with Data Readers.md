Working with Data Readers

The DbDataReader type (which
implements IDataReader) is the simplest and fastest way to obtain information from a data store. Recall that
data readers represent a read-only, forward-only stream of data returned one record at a time. Given this,
data readers are useful only when submitting SQL selection statements to the underlying data store.

// Obtain a data reader via ExecuteReader().
using(SqlDataReader myDataReader = myCommand.ExecuteReader())
{
// Loop over the results.
while (myDataReader.Read())
{
WriteLine($"-> Make: { myDataReader["Make"]}, PetName: { myDataReader["PetName"]},
Color: { myDataReader["Color"]}.");
}
}
ReadLine();

while (myDataReader.Read())
{
for (int i = 0; i < myDataReader.FieldCount; i++)
{
Console.Write(i != myDataReader.FieldCount - 1
? $"{myDataReader.GetName(i)} = {myDataReader.GetValue(i)}, "
: $"{myDataReader.GetName(i)} = {myDataReader.GetValue(i)} ");
}
Console.WriteLine();
}


