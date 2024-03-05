Abstracting Data Providers Using Interfaces

the exact names of the implementing types will differ among data
providers, you can program against these types in a similar manner—that is the beauty of interface-based
polymorphism. For example, if you define a method that takes an IDbConnection parameter, you can pass in
any ADO.NET connection object

public static void OpenConnection(IDbConnection cn)
{
// Open the incoming connection for the caller.
connection.Open();
}

Interfaces are not strictly required; you can achieve the same level of abstraction using abstract base
classes (such as DbConnection) as parameters or return values. However, using interfaces instead of base
classes is the generally accepted best practice.


Add the following NuGet packages to the project (the OleDb package is only valid on
Windows):
Microsoft.Data.SqlClient
System.Data.Common
System.Data.Odbc
System.Data.OleDb

namespace MyConnectionFactory
{
//OleDb is Windows only and is not supported in .NET Core
enum DataProviderEnum
{
SqlServer,
#if PC
OleDb,
#endif
Odbc,
None
}
}


If you are using a Windows OS on your development machine, update the project file to define the
conditional compiler symbol PC.
<PropertyGroup>
<DefineConstants>PC</DefineConstants>
</PropertyGroup>


using System;
using System.Data;
using System.Data.Odbc;
#if PC
using System.Data.OleDb;
#endif
using Microsoft.Data.SqlClient;
using MyConnectionFactory;
Console.WriteLine("**** Very Simple Connection Factory *****\n");
Setup(DataProviderEnum.SqlServer);
#if PC
Setup(DataProviderEnum.OleDb); //Not supported on macOS
#endif
Setup(DataProviderEnum.Odbc);
Setup(DataProviderEnum.None);
Console.ReadLine();
void Setup(DataProviderEnum provider)
{
// Get a specific connection.
IDbConnection myConnection = GetConnection(provider);
Console.WriteLine($"Your connection is a {myConnection?.GetType().Name ??
"unrecognized type"}");
// Open, use and close connection...
}
// This method returns a specific connection object
// based on the value of a DataProvider enum.
IDbConnection GetConnection(DataProviderEnum dataProvider)
=> dataProvider switch
{
DataProviderEnum.SqlServer => new SqlConnection(),
#if PC
//Not supported on macOS
DataProviderEnum.OleDb => new OleDbConnection(),
#endif
DataProviderEnum.Odbc => new OdbcConnection(),
_ => null,
};


The benefit of working with the general interfaces of System.Data (or, for that matter, the abstract base
classes of System.Data.Common) is that you have a much better chance of building a flexible code base that
can evolve over time. For example, today you might be building an application that targets Microsoft SQL
Server; however, it is possible your company could switch to a different database. If you build a solution
that hard-codes the Microsoft SQL Server–specific types of System.Data.SqlClient, you will need to edit,
recompile, and redeploy the code for the new database provider.


