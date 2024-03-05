Working with Connection Objects

NET Core connection objects are
provided with a formatted connection string; this string contains a number of name-value pairs, separated
by semicolons.


Members of the DbConnection Type
Member Meaning in Life
BeginTransaction() You use this method to begin a database transaction.
ChangeDatabase() You use this method to change the database on an open connection.
ConnectionTimeout This read-only property returns the amount of time to wait while establishing
a connection before terminating and generating an error (the default value is
provider dependent). If you would like to change the default, specify a Connect
Timeout segment in the connection string (e.g., Connect Timeout=30).
Database This read-only property gets the name of the database maintained by the
connection object.
DataSource This read-only property gets the location of the database maintained by the
connection object.
GetSchema() This method returns a DataTable object that contains schema information from
the data source.
State This read-only property gets the current state of the connection, which is
represented by the ConnectionState enumeration.


using(SqlConnection connection = new SqlConnection())
{
connection.ConnectionString =
@" Data Source=.,5433;User Id=sa;Password=P@ssw0rd;Initial Catalog=AutoLot;Connect
Timeout=30";
connection.Open();
}
The following code outputs details about the SqlConnection that it passed into it:
static void ShowConnectionStatus(SqlConnection connection)
{
// Show various stats about current connection object.
Console.WriteLine("***** Info about your connection *****");
Console.WriteLine($@"Database location:
{connection.DataSource}");
Console.WriteLine($"Database name: {connection.Database}");
Console.WriteLine($@"Timeout:
{connection.ConnectionTimeout}");
Console.WriteLine($"Connection state:
{connection.State}\n");
}


