
The Role of the IDbCommand Interface

Next up is the IDbCommand interface, which will be implemented by a data provider’s command object. Like
other data access object models, command objects allow programmatic manipulation of SQL statements,
stored procedures, and parameterized queries. Command objects also provide access to the data provider’s
data reader type through the overloaded ExecuteReader() method

public interface IDbCommand : IDisposable
{
string CommandText { get; set; }
int CommandTimeout { get; set; }
CommandType CommandType { get; set; }
IDbConnection Connection { get; set; }
IDbTransaction Transaction { get; set; }
IDataParameterCollection Parameters { get; }
UpdateRowSource UpdatedRowSource { get; set; }
void Prepare();
void Cancel();
IDbDataParameter CreateParameter();
int ExecuteNonQuery();
IDataReader ExecuteReader();
IDataReader ExecuteReader(CommandBehavior behavior);
object ExecuteScalar();
void Dispose();
}

