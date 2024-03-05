Working with Create, Update, and Delete Queries

//Car.cs
namespace AutoLot.Dal.Models
{
public class Car
{
public int Id { get; set; }
public string Color { get; set; }
public int MakeId { get; set; }
public string PetName { get; set; }
public byte[] TimeStamp {get;set;}
}
}
//CarViewModel.cs
namespace AutoLot.Dal.Models
{
public class CarViewModel : Car
{
public string Make { get; set; }
}
}


namespace AuoLot.Dal.DataOperations
{
public class InventoryDal
{
private readonly string _connectionString;
public InventoryDal() : this(
@"Data Source=.,5433;User Id=sa;Password=P@ssw0rd;Initial Catalog=AutoLot")
{
}
public InventoryDal(string connectionString)
=> _connectionString = connectionString;
}
}

private SqlConnection _sqlConnection = null;
private void OpenConnection()
{
_sqlConnection = new SqlConnection
{
ConnectionString = _connectionString
};
_sqlConnection.Open();
}


private void CloseConnection()
{
if (_sqlConnection?.State != ConnectionState.Closed)
{
_sqlConnection?.Close();
}
}


Add the IDisposable interface to the class definition, like this:
public class InventoryDal : IDisposable
{
...
}
Next, implement the disposable pattern, calling Dispose on the SqlConnection object.
bool _disposed = false;
protected virtual void Dispose(bool disposing)
{
if (_disposed)
{
return;
}
if (disposing)
{
_sqlConnection.Dispose();
}
_disposed = true;
}
public void Dispose()
{
Dispose(true);
GC.SuppressFinalize(this);
}


a data provider’s data reader
object allows for a selection of records using a read-only, forward-only mechanism using the Read()
method. In this example, the CommandBehavior property on the DataReader is set to automatically close the
connection when the reader is closed. The GetAllInventory() method returns a List<CarViewModel> to
represent all the data in the Inventory table.


public List<CarViewModel> GetAllInventory()
{
OpenConnection();
// This will hold the records.
List<CarViewModel> inventory = new List<CarViewModel>();
// Prep command object.
string sql =
@"SELECT i.Id, i.Color, i.PetName,m.Name as Make
FROM Inventory i
INNER JOIN Makes m on m.Id = i.MakeId";
using SqlCommand command =
new SqlCommand(sql, _sqlConnection)
{
CommandType = CommandType.Text
};
command.CommandType = CommandType.Text;
SqlDataReader dataReader =
command.ExecuteReader(CommandBehavior.CloseConnection);
while (dataReader.Read())
{
inventory.Add(new CarViewModel
{
Id = (int)dataReader["Id"],
Color = (string)dataReader["Color"],
Make = (string)dataReader["Make"],
PetName = (string)dataReader["PetName"]
});
}
dataReader.Close();
return inventory;
}
The next selection method gets a single CarViewModel based on the CarId.
public CarViewModel GetCar(int id)
{
OpenConnection();
CarViewModel car = null;
//This should use parameters for security reasons
string sql =
$@"SELECT i.Id, i.Color, i.PetName,m.Name as Make
FROM Inventory i
INNER JOIN Makes m on m.Id = i.MakeId
WHERE i.Id = {id}";
using SqlCommand command =
new SqlCommand(sql, _sqlConnection)
{
CommandType = CommandType.Text
};
SqlDataReader dataReader =
command.ExecuteReader(CommandBehavior.CloseConnection);


while (dataReader.Read())
{
car = new CarViewModel
{
Id = (int) dataReader["Id"],
Color = (string) dataReader["Color"],
Make = (string) dataReader["Make"],
PetName = (string) dataReader["PetName"]
};
}
dataReader.Close();
return car;
}


