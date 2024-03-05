Data Access with ADO.NET

The .NET Core platform defines several namespaces that allow you to interact with relational database
systems. Collectively speaking, these namespaces are known as ADO.NET.

The .NET Core platform defines several namespaces that allow you to interact with relational database
systems. Collectively speaking, these namespaces are known as ADO.NET.


Entity Framework (EF)
Core, Microsoft’s object-relational mapping (ORM) framework. Since Entity Framework Core uses ADO.NET for
data access under the covers, a solid understanding of how ADO.NET works is vital when troubleshooting data
access. There are also scenarios that are not solved by EF Core (such as executing a SQL bulk copy), and you
will need to know ADO.NET to solve those issues.


ADO.NET vs. ADO
Understanding ADO.NET Data Providers
ADO.NET does not provide a single set of objects that communicate with multiple database management
systems (DBMSs). Rather, ADO.NET supports multiple data providers, each of which is optimized to interact
with a specific DBMS.


a data provider is a set of types defined in a given namespace that understand how to
communicate with a specific type of data source. Regardless of which data provider you use, each defines a
set of class types that provide core functionality.


The Core Objects of an ADO.NET Data Provider
Base Class Relevant Interfaces Meaning in Life
DbConnection IDbConnection Provides the ability to connect to and disconnect from the
data store. Connection objects also provide access to a related
transaction object.
DbCommand IDbCommand Represents a SQL query or a stored procedure. Command objects
also provide access to the provider’s data reader object.
DbDataReader IDataReader,
IDataRecord
Provides forward-only, read-only access to data using a serverside
cursor.
DbDataAdapter IDataAdapter,
IDbDataAdapter
Transfers DataSets between the caller and the data store.
Data adapters contain a connection and a set of four internal
command objects used to select, insert, update, and delete
information from the data store.
DbParameter IDataParameter,
IDbDataParameter
Represents a named parameter within a parameterized query.
DbTransaction IDbTransaction Encapsulates a database transaction.


hen you refer to a connection object under ADO.NET, you’re actually referring to a specific
DbConnection-derived type; there is no class literally named Connection. The same idea holds true for a
command object, data adapter object, and so forth. As a naming convention, the objects in a specific data provider
are prefixed with the name of the related DBMS (e.g., SqlConnection, SqlCommand, and SqlDataReader).

![alt text](image.png)


