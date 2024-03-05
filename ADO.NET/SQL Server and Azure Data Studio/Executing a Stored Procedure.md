Executing a Stored Procedure

public string LookUpPetName(int carId)
{
OpenConnection();
string carPetName;
// Establish name of stored proc.
using (SqlCommand command = new SqlCommand("GetPetName", _sqlConnection))
{
command.CommandType = CommandType.StoredProcedure;
// Input param.
SqlParameter param = new SqlParameter
{
ParameterName = "@carId",
SqlDbType = SqlDbType.Int,
Value = carId,
Direction = ParameterDirection.Input
};
command.Parameters.Add(param);
// Output param.
param = new SqlParameter
{
ParameterName = "@petName",
SqlDbType = SqlDbType.NVarChar,
Size = 50,
Direction = ParameterDirection.Output
};
command.Parameters.Add(param);
// Execute the stored proc.
command.ExecuteNonQuery();


// Return output param.
carPetName = (string)command.Parameters["@petName"].Value;
CloseConnection();
}
return carPetName;
}


