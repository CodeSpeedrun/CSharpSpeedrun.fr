The Role of the IDbConnection Interface

The IDbConnection type is implemented by a data provider’s connection object. This interface defines a
set of members used to configure a connection to a specific data store. It also allows you to obtain the data
provider’s transaction object. Here is the formal definition of IDbConnection:
public interface IDbConnection : IDisposable
{
string ConnectionString { get; set; }
int ConnectionTimeout { get; }
string Database { get; }
ConnectionState State { get; }
IDbTransaction BeginTransaction();
IDbTransaction BeginTransaction(IsolationLevel il);
void ChangeDatabase(string databaseName);
void Close();
IDbCommand CreateCommand();
void Open();
void Dispose();
}


