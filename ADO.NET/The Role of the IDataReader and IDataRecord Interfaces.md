The Role of the IDataReader and IDataRecord Interfaces

The next key interface to be aware of is IDataReader, which represents the common behaviors supported
by a given data reader object. When you obtain an IDataReader-compatible type from an ADO.NET data
provider, you can iterate over the result set in a forward-only, read-only manner.
public interface IDataReader : IDisposable, IDataRecord
{
//Plus members from IDataRecord
int Depth { get; }
bool IsClosed { get; }
int RecordsAffected { get; }
void Close();
DataTable GetSchemaTable();
bool NextResult();
bool Read();
Dispose();
}

Finally, IDataReader extends IDataRecord, which defines many members that allow you to extract a
strongly typed value from the stream, rather than casting the generic System.Object retrieved from the data
reader’s overloaded indexer method. Here is the IDataRecord interface definition:
public interface IDataRecord
{
int FieldCount { get; }
object this[ int i ] { get; }
object this[ string name ] { get; }
bool GetBoolean(int i);
byte GetByte(int i);
long GetBytes(int i, long fieldOffset, byte[] buffer,
int bufferoffset, int length);
char GetChar(int i);
long GetChars(int i, long fieldoffset, char[] buffer,
int bufferoffset, int length);
IDataReader GetData(int i);
string GetDataTypeName(int i);
DateTime GetDateTime(int i);
Decimal GetDecimal(int i);
double GetDouble(int i);
Type GetFieldType(int i);
float GetFloat(int i);
Guid GetGuid(int i);
short GetInt16(int i);
int GetInt32(int i);
long GetInt64(int i);
string GetName(int i);
int GetOrdinal(string name);
string GetString(int i);
object GetValue(int i);
int GetValues(object[] values);
bool IsDBNull(int i);
}
■■Note You can use the IDataReader.IsDBNull() method to discover programmatically whether a specified
field is set to null before attempting to obtain a value from the data reader (to avoid triggering a runtime
exception). Also recall that C# supports nullable data types (see Chapter 4), which are ideal for interacting with
data columns that could be null in the database table.

