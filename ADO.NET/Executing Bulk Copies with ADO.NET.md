Executing Bulk Copies with ADO.NET

In cases where you need to load lots of records into the database, the methods shown so far would be rather
inefficient. SQL Server has a feature called bulk copy

namespace AutoLot.Dal.BulkImport
{
public interface IMyDataReader<T> : IDataReader
{
List<T> Records { get; set; }
}
}

public sealed class MyDataReader<T> : IMyDataReader<T>
{
public List<T> Records { get; set; }
public MyDataReader(List<T> records)
{
Records = records;
}
}

Key Methods of IDataReader for SqlBulkCopy
Method Meaning in Life
Read Gets the next record; returns true if there is another record or returns false if at the end
of the list
FieldCount Gets the total number of fields in the data source
GetValue Gets the value of a field based on the ordinal position
GetSchemaTable Gets the schema information for the target table


public class MyDataReader<T> : IMyDataReader<T>
{
...
private int _currentIndex = -1;
public bool Read()
{
if (_currentIndex + 1 >= Records.Count)
{
return false;
}
_currentIndex++;
return true;
}
}


public object GetValue(int i)
{
Car currentRecord = Records[_currentIndex] as Car;
return i switch
{
0 => currentRecord.Id,
1 => currentRecord.MakeId,
2 => currentRecord.Color,
3 => currentRecord.PetName,
4 => currentRecord.TimeStamp,
_ => string.Empty,
};
}


private readonly PropertyInfo[] _propertyInfos;
private readonly Dictionary<int, string> _nameDictionary;
public MyDataReader(List<T> records)
{
Records = records;
_propertyInfos = typeof(T).GetProperties();
_nameDictionary = new Dictionary<int,string>();
}
Next, update the constructor to take a SQLConnection as well as strings for the schema and table names
for the table the records are going to be inserted into and add class-level variables for the values.
private readonly SqlConnection _connection;
private readonly string _schema;
private readonly string _tableName;
public MyDataReader(List<T> records, SqlConnection connection, string schema, string
tableName)
{
Records = records;
_propertyInfos = typeof(T).GetProperties();
_nameDictionary = new Dictionary<int, string>();
_connection = connection;
_schema = schema;
_tableName = tableName;
}


Implement the GetSchemaTable() method next. This retrieves the SQL Server information regarding
the target table.
public DataTable GetSchemaTable()
{
using var schemaCommand = new SqlCommand($"SELECT * FROM {_schema}.{_tableName}", _
connection);
using var reader = schemaCommand.ExecuteReader(CommandBehavior.SchemaOnly);
return reader.GetSchemaTable();
}
Update the constructor to use the SchemaTable to construct the dictionary that contains the fields of the
target table in database order.
public MyDataReader(List<T> records, SqlConnection connection, string schema, string tableName)
{
...
DataTable schemaTable = GetSchemaTable();
for (int x = 0; x<schemaTable?.Rows.Count;x++)
{
DataRow col = schemaTable.Rows[x];
var columnName = col.Field<string>("ColumnName");
_nameDictionary.Add(x,columnName);
}
}
Now, the following methods can be implemented generically, using the reflected information:
public int FieldCount => _propertyInfos.Length;
public object GetValue(int i)
=> _propertyInfos
.First(x=>x.Name.Equals(_nameDictionary[i],StringComparison.OrdinalIgnoreCase))
.GetValue(Records[_currentIndex]);
The remainder of the methods that must be present (but not implemented) are listed here for reference:
public string GetName(int i) => throw new NotImplementedException();
public int GetOrdinal(string name) => throw new NotImplementedException();
public string GetDataTypeName(int i) => throw new NotImplementedException();
public Type GetFieldType(int i) => throw new NotImplementedException();
public int GetValues(object[] values) => throw new NotImplementedException();
public bool GetBoolean(int i) => throw new NotImplementedException();
public byte GetByte(int i) => throw new NotImplementedException();
public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
=> throw new NotImplementedException();
public char GetChar(int i) => throw new NotImplementedException();
public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
=> throw new NotImplementedException();
public Guid GetGuid(int i) => throw new NotImplementedException();
public short GetInt16(int i) => throw new NotImplementedException();
public int GetInt32(int i) => throw new NotImplementedException();
public long GetInt64(int i) => throw new NotImplementedException();


Add the code to handle opening and closing connections (like the code in the InventoryDal class), as
follows:
private const string ConnectionString =
@"Data Source=.,5433;User Id=sa;Password=P@ssw0rd;Initial Catalog=AutoLot";
private static SqlConnection _sqlConnection = null;
private static void OpenConnection()
{
_sqlConnection = new SqlConnection
{
ConnectionString = ConnectionString
};
_sqlConnection.Open();
}
private static void CloseConnection()
{
if (_sqlConnection?.State != ConnectionState.Closed)
{
_sqlConnection?.Close();
}
}

public static void ExecuteBulkImport<T>(IEnumerable<T> records, string tableName)
{
OpenConnection();
using SqlConnection conn = _sqlConnection;
SqlBulkCopy bc = new SqlBulkCopy(conn)
{
DestinationTableName = tableName
};
var dataReader = new MyDataReader<T>(records.ToList(),_sqlConnection,
"dbo",tableName); try
{
bc.WriteToServer(dataReader);
}
catch (Exception ex)
{
//Should do something here
}
finally
{
CloseConnection();
}
}


void DoBulkCopy()
{
Console.WriteLine(" ************** Do Bulk Copy ************** ");
var cars = new List<Car>
{
new Car() {Color = "Blue", MakeId = 1, PetName = "MyCar1"},
new Car() {Color = "Red", MakeId = 2, PetName = "MyCar2"},
new Car() {Color = "White", MakeId = 3, PetName = "MyCar3"},
new Car() {Color = "Yellow", MakeId = 4, PetName = "MyCar4"}
};
ProcessBulkImport.ExecuteBulkImport(cars, "Inventory");
InventoryDal dal = new InventoryDal();


List<CarViewModel> list = dal.GetAllInventory();
Console.WriteLine(" ************** All Cars ************** ");
Console.WriteLine("CarId\tMake\tColor\tPet Name");
foreach (var itm in list)
{
Console.WriteLine(
$"{itm.Id}\t{itm.Make}\t{itm.Color}\t{itm.PetName}");
}
Console.WriteLine();
}


