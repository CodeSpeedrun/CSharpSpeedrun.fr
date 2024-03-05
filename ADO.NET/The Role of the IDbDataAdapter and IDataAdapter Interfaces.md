The Role of the IDbDataAdapter and IDataAdapter Interfaces

You use data adapters to push and pull DataSets to and from a given data store. The IDbDataAdapter
interface defines the following set of properties that you can use to maintain the SQL statements for the
related select, insert, update, and delete operations:
public interface IDbDataAdapter : IDataAdapter
{
//Plus members of IDataAdapter
IDbCommand SelectCommand { get; set; }
IDbCommand InsertCommand { get; set; }
IDbCommand UpdateCommand { get; set; }
IDbCommand DeleteCommand { get; set; }
}
In addition to these four properties, an ADO.NET data adapter picks up the behavior defined in the
base interface, IDataAdapter. This interface defines the key function of a data adapter type: the ability to
transfer DataSets between the caller and underlying data store using the Fill() and Update() methods. The
IDataAdapter interface also allows you to map database column names to more user-friendly display names
with the TableMappings property.
public interface IDataAdapter
{
MissingMappingAction MissingMappingAction { get; set; }
MissingSchemaAction MissingSchemaAction { get; set; }
ITableMappingCollection TableMappings { get; }
DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType);
int Fill(DataSet dataSet);
IDataParameter[] GetFillParameters();
int Update(DataSet dataSet);
}

