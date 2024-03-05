Working with Parameterized Command Objects

With parameterized queries, SQL parameters are objects, rather than simple blobs of text.
Treating SQL queries in a more object-oriented manner helps reduce the number of typos (given strongly
typed properties); plus, parameterized queries typically execute much faster than a literal SQL string
because they are parsed exactly once (rather than each time the SQL string is assigned to the CommandText
property). Parameterized queries also help protect against SQL injection attacks (a well-known data access
security issue).


Key Members of the DbParameter Type
Property Meaning in Life
DbType Gets or sets the native data type of the parameter, represented as a CLR data type
Direction Gets or sets whether the parameter is input-only, output-only, bidirectional, or a return
value parameter
IsNullable Gets or sets whether the parameter accepts null values
ParameterName Gets or sets the name of the DbParameter
Size Gets or sets the maximum parameter size of the data in bytes; this is useful only for
textual data
Value Gets or sets the value of the parameter


SqlParameter param = new SqlParameter
{
ParameterName = "@carId",
Value = id,
SqlDbType = SqlDbType.Int,
Direction = ParameterDirection.Input
};


string sql =
@"SELECT i.Id, i.Color, i.PetName,m.Name as Make
FROM Inventory i
INNER JOIN Makes m on m.Id = i.MakeId
WHERE i.Id = @CarId";
The final update is to add the new parameter to the Parameters collection of the command object.
command.Parameters.Add(param);



SqlParameter param = new SqlParameter
{
ParameterName = "@carId",
Value = id,
SqlDbType = SqlDbType.Int,
Direction = ParameterDirection.Input
};
Next, update the SQL string to use the parameter name ("@carId").
string sql = "Delete from Inventory where Id = @carId";
The final update is to add the new parameter to the Parameters collection of the command object.
command.Parameters.Add(param);


SqlParameter paramId = new SqlParameter
{
ParameterName = "@carId",
Value = id,
SqlDbType = SqlDbType.Int,
Direction = ParameterDirection.Input
};
SqlParameter paramName = new SqlParameter
{
ParameterName = "@petName",
Value = newPetName,
SqlDbType = SqlDbType.NVarChar,
Size = 50,
Direction = ParameterDirection.Input
};
Next, update the SQL string to use the parameters.
string sql = $"Update Inventory Set PetName = @petName Where Id = @carId";


The final update is to add the new parameters to the Parameters collection of the command object.
command.Parameters.Add(paramId);
command.Parameters.Add(paramName);


public void InsertAuto(Car car)
{
OpenConnection();
// Note the "placeholders" in the SQL query.
string sql = "Insert Into Inventory" +
"(MakeId, Color, PetName) Values" +
"(@MakeId, @Color, @PetName)";
// This command will have internal parameters.
using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
{
// Fill params collection.
SqlParameter parameter = new SqlParameter
{
ParameterName = "@MakeId",
Value = car.MakeId,
SqlDbType = SqlDbType.Int,
Direction = ParameterDirection.Input
};
command.Parameters.Add(parameter);
parameter = new SqlParameter
{
ParameterName = "@Color",
Value = car.Color,
SqlDbType = SqlDbType. NVarChar,
Size = 50,
Direction = ParameterDirection.Input
};
command.Parameters.Add(parameter);
parameter = new SqlParameter
{
ParameterName = "@PetName",
Value = car.PetName,
SqlDbType = SqlDbType. NVarChar,
Size = 50,
Direction = ParameterDirection.Input
};
command.Parameters.Add(parameter);

command.ExecuteNonQuery();
CloseConnection();
}
}


