The ADO.NET Data Provider Factory Model

DbCommand: The abstract base class for all command classes
• DbConnection: The abstract base class for all connection classes
• DbDataAdapter: The abstract base class for all data adapter classes
• DbDataReader: The abstract base class for all data reader classes
• DbParameter: The abstract base class for all parameter classes
• DbTransaction: The abstract base class for all transaction classes

namespace DataProviderFactory
{
//OleDb is Windows only and is not supported in .NET Core
enum DataProviderEnum
{
SqlServer,

#if PC
OleDb,
#endif
Odbc
}
}
Add a new JSON file named appsettings.json to the project and update its contents to the following
(update the connection strings based on your specific environment):
{
"ProviderName": "SqlServer",
//"ProviderName": "OleDb",
//"ProviderName": "Odbc",
"SqlServer": {
// for localdb use @"Data Source=(localdb)\mssqllocaldb;Integrated Security=true;
Initial Catalog=AutoLot"
"ConnectionString": "Data Source=.,5433;User Id=sa;Password=P@ssw0rd;Initial
Catalog=AutoLot"
},
"Odbc": {
// for localdb use @"Driver={ODBC Driver 17 for SQL Server};Server=(localdb)\mssqllocald
b;Database=AutoLot;Trusted_Connection=Yes";
"ConnectionString": "Driver={ODBC Driver 17 for SQL Server};Server=localhost,5433;
Database=AutoLot;UId=sa;Pwd=P@ssw0rd;"
},
"OleDb": {
// if localdb use @"Provider=SQLNCLI11;Data Source=(localdb)\mssqllocaldb;Initial
Catalog=AutoLot;Integrated Security=SSPI"),
"ConnectionString": "Provider=SQLNCLI11;Data Source=.,5433;User Id=sa;Password=P@ssw0rd;
Initial Catalog=AutoLot;"
}
}
Inform MSBuild to copy the JSON file to the output directory on every build. Update the project file by
adding the following:
<ItemGroup>
<None Update="appsettings.json">
<CopyToOutputDirectory>Always</CopyToOutputDirectory>
</None>
</ItemGroup>

using System;
using System.Data.Common;
using System.Data.Odbc;
#if PC
using System.Data.OleDb;
#endif
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
Clear all code from the Program.cs file, and add the following:
using System;
using System.Data.Common;
using System.Data.Odbc;
#if PC
using System.Data.OleDb;
#endif
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using DataProviderFactory;
Console.WriteLine("***** Fun with Data Provider Factories *****\n");
var (provider, connectionString) = GetProviderFromConfiguration();
DbProviderFactory factory = GetDbProviderFactory(provider);
// Now get the connection object.
using (DbConnection connection = factory.CreateConnection())
{
if (connection == null)
{
Console.WriteLine($"Unable to create the connection object");
return;
}
Console.WriteLine($"Your connection object is a: {connection.GetType().Name}");
connection.ConnectionString = connectionString;
connection.Open();
// Make command object.
DbCommand command = factory.CreateCommand();
if (command == null)
{
Console.WriteLine($"Unable to create the command object");
return;
}

Console.WriteLine($"Your command object is a: {command.GetType().Name}");
command.Connection = connection;
command.CommandText =
"Select i.Id, m.Name From Inventory i inner join Makes m on m.Id = i.MakeId ";
// Print out data with data reader.
using (DbDataReader dataReader = command.ExecuteReader())
{
Console.WriteLine($"Your data reader object is a: {dataReader.GetType().Name}");
Console.WriteLine("\n***** Current Inventory *****");
while (dataReader.Read())
{
Console.WriteLine($"-> Car #{dataReader["Id"]} is a {dataReader["Name"]}.");
}
}
}
Console.ReadLine();


static DbProviderFactory GetDbProviderFactory(DataProviderEnum provider)
=> provider switch
{
DataProviderEnum.SqlServer => SqlClientFactory.Instance,
DataProviderEnum.Odbc => OdbcFactory.Instance,
#if PC
DataProviderEnum.OleDb => OleDbFactory.Instance,
#endif
_ => null
};
static (DataProviderEnum Provider, string ConnectionString)
GetProviderFromConfiguration()
{
IConfiguration config = new ConfigurationBuilder()
.SetBasePath(Directory.GetCurrentDirectory())
.AddJsonFile("appsettings.json", true, true)
.Build();
var providerName = config["ProviderName"];
if (Enum.TryParse<DataProviderEnum>
(providerName, out DataProviderEnum provider))
{
return (provider,config[$"{providerName}:ConnectionString"]);
};
throw new Exception("Invalid data provider value supplied.");
}


A Potential Drawback with the Data Provider Factory Model
Although this is a powerful model, you must make sure that the code base uses only types and methods
common to all providers through the members of the abstract base classes. Therefore, when authoring your
code base, you are limited to the members exposed by DbConnection, DbCommand, and the other types of the
System.Data.Common namespace.
Given this, you might find that this generalized approach prevents you from directly accessing some of
the bells and whistles of a particular DBMS. If you must be able to invoke specific members of the underlying
provider (e.g., SqlConnection), you can do so using an explicit cast, as in this example:
if (connection is SqlConnection sqlConnection)
{
// Print out which version of SQL Server is used.
WriteLine(sqlConnection.ServerVersion);
}
When doing this, however, your code base becomes a bit harder to maintain (and less flexible) because
you must add a number of runtime checks. Nevertheless, if you need to build ADO.NET data access libraries
in the most flexible way possible, the data provider factory model provides a great mechanism for doing so.


