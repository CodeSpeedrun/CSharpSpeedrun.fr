Connections, Commands,
and DataReaders

using System;
using Microsoft.Data.SqlClient;
Console.WriteLine("***** Fun with Data Readers *****\n");
// Create and open a connection.
using (SqlConnection connection = new SqlConnection())
{
connection.ConnectionString =
@" Data Source=.,5433;User Id=sa;Password=P@ssw0rd;Initial Catalog=AutoLot";
connection.Open();
// Create a SQL command object.
string sql =
@"Select i.id, m.Name as Make, i.Color, i.Petname
FROM Inventory i
INNER JOIN Makes m on m.Id = i.MakeId";
SqlCommand myCommand = new SqlCommand(sql, connection);
// Obtain a data reader a la ExecuteReader().
using (SqlDataReader myDataReader = myCommand.ExecuteReader())
{
// Loop over the results.
while (myDataReader.Read())
{
Console.WriteLine($"-> Make: {myDataReader["Make"]}, PetName: {myDataReader
["PetName"]}, Color: {myDataReader["Color"]}.");
}
}
}
Console.ReadLine();


