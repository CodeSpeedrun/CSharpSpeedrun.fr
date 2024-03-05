Working with Command Objects

The SqlCommand type (which derives from
DbCommand) is an OO representation of a SQL query, table name, or stored procedure. You specify the type of
command using the CommandType property, which can take any value from the CommandType enum, as shown
here:
public enum CommandType
{
StoredProcedure,
TableDirect,
Text // Default value.
}

When you create a command object, you can establish the SQL query as a constructor parameter or
directly by using the CommandText property. Also, when you create a command object, you need to specify
the connection you want to use. Again, you can do so as a constructor parameter or by using the Connection
property. Consider this code snippet:
// Create command object via ctor args.
string sql =
@"Select i.id, m.Name as Make, i.Color, i.Petname
FROM Inventory i
INNER JOIN Makes m on m.Id = i.MakeId";
SqlCommand myCommand = new SqlCommand(sql, connection);


// Create another command object via properties.
SqlCommand testCommand = new SqlCommand();
testCommand.Connection = connection;
testCommand.CommandText = sql;


Members of the DbCommand Type
Member Meaning in Life
CommandTimeout Gets or sets the time to wait while executing the command before terminating the
attempt and generating an error. The default is 30 seconds.
Connection Gets or sets the DbConnection used by this instance of the DbCommand.
Parameters Gets the collection of DbParameter objects used for a parameterized query.
Cancel() Cancels the execution of a command.
ExecuteReader() Executes a SQL query and returns the data provider’s DbDataReader object, which
provides forward-only, read-only access for the result of the query.
ExecuteNonQuery() Executes a SQL nonquery (e.g., an insert, update, delete, or create table).
ExecuteScalar() A lightweight version of the ExecuteReader() method that was designed
specifically for singleton queries (e.g., obtaining a record count).
Prepare() Creates a prepared (or compiled) version of the command on the data source. As
you might know, a prepared query executes slightly faster and is useful when you
need to execute the same query multiple times (typically with different parameters
each time).


