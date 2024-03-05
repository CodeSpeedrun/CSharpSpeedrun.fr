The Role of the IDbDataParameter and IDataParameter Interfaces

Notice that the Parameters property of IDbCommand returns a strongly typed collection that implements
IDataParameterCollection. This interface provides access to a set of IDbDataParameter-compliant class
types (e.g., parameter objects).
public interface IDbDataParameter : IDataParameter
{
//Plus members in the IDataParameter interface
byte Precision { get; set; }
byte Scale { get; set; }
int Size { get; set; }
}
IDbDataParameter extends the IDataParameter interface to obtain the following additional behaviors:
public interface IDataParameter
{
DbType DbType { get; set; }
ParameterDirection Direction { get; set; }
bool IsNullable { get; }
string ParameterName { get; set; }
string SourceColumn { get; set; }
DataRowVersion SourceVersion { get; set; }
object Value { get; set; }
}

