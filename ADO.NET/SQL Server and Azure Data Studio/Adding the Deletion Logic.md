Adding the Deletion Logic

public void DeleteCar(int id)
{
OpenConnection();
// Get ID of car to delete, then do so.
string sql = $"Delete from Inventory where Id = '{id}'";
using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
{
try
{
command.CommandType = CommandType.Text;
command.ExecuteNonQuery();
}
catch (SqlException ex)
{
Exception error = new Exception("Sorry! That car is on order!", ex);
throw error;
}
}
CloseConnection();
}


