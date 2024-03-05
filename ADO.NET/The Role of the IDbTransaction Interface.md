The Role of the IDbTransaction Interface

The overloaded BeginTransaction() method defined by IDbConnection provides access to the provider’s
transaction object. You can use the members defined by IDbTransaction to interact programmatically with a
transactional session and the underlying data store.
public interface IDbTransaction : IDisposable
{
IDbConnection Connection { get; }
IsolationLevel IsolationLevel { get; }
void Commit();
void Rollback();
void Dispose();
}

