Key Members of an ADO.NET Transaction Object

All of the transactions we will use implement the IDbTransaction interface. Recall from the beginning of this
chapter that IDbTransaction defines a handful of members as follows:
public interface IDbTransaction : IDisposable
{
IDbConnection Connection { get; }
IsolationLevel IsolationLevel { get; }
void Commit();
void Rollback();
}


