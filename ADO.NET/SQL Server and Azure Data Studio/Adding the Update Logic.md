Adding the Update Logic

public void UpdateCarPetName(int id, string newPetName)
{
OpenConnection();
// Get ID of car to modify the pet name.
string sql = $"Update Inventory Set PetName = '{newPetName}' Where Id = '{id}'";
using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
{
command.ExecuteNonQuery();
}
CloseConnection();
}


