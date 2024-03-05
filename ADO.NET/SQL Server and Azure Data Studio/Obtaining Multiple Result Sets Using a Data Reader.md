Obtaining Multiple Result Sets Using a Data Reader

sql += ";Select * from Customers;";

do
{
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
Console.WriteLine();
} while (myDataReader.NextResult());


