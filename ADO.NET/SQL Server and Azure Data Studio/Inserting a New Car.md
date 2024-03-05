Inserting a New Car

public void InsertAuto(string color, int makeId, string petName)
{
OpenConnection();
// Format and execute SQL statement.
string sql = $"Insert Into Inventory (MakeId, Color, PetName) Values ('{makeId}',
'{color}', '{petName}')";
// Execute using our connection.
using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
{
command.CommandType = CommandType.Text;
command.ExecuteNonQuery();
}
CloseConnection();
}


Create the Strongly Type InsertCar() Method
Add another InsertAuto() method that takes Car as a parameter to your InventoryDal class, as shown here:
public void InsertAuto(Car car)
{
OpenConnection();
// Format and execute SQL statement.
string sql = "Insert Into Inventory (MakeId, Color, PetName) Values " +
$"('{car.MakeId}', '{car.Color}', '{car.PetName}')";
// Execute using our connection.
using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
{
command.CommandType = CommandType.Text;
command.ExecuteNonQuery();
}
CloseConnection();
}