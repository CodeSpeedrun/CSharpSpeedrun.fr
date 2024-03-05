The Types of the System.Data Namespace

This namespace
contains types that are shared among all ADO.NET data providers, regardless of the underlying
data store. In addition to a number of database-centric exceptions

Core Members of the System.Data Namespace
Type Meaning in Life
Constraint Represents a constraint for a given DataColumn object
DataColumn Represents a single column within a DataTable object
DataRelation Represents a parent-child relationship between two DataTable objects
DataRow Represents a single row within a DataTable object
DataSet Represents an in-memory cache of data consisting of any number of interrelated
DataTable objects
DataTable Represents a tabular block of in-memory data
DataTableReader Allows you to treat a DataTable as a fire-hose cursor (forward-only, read-only data
access)
DataView Represents a customized view of a DataTable for sorting, filtering, searching, editing,
and navigation
IDataAdapter Defines the core behavior of a data adapter object
IDataParameter Defines the core behavior of a parameter object
IDataReader Defines the core behavior of a data reader object
IDbCommand Defines the core behavior of a command object
IDbDataAdapter Extends IDataAdapter to provide additional functionality of a data adapter object
IDbTransaction Defines the core behavior of a transaction object


