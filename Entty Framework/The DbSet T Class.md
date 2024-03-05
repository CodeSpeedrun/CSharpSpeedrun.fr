The DbSet<T> Class

The DbSet<T> class is a
specialized collection property used to interact with the database provider to get, add, update, or delete
records in the database.

Common Members and Extension Methods of DbSet<T>
Member of DbSet<T> Meaning in Life
Add/AddRange Begins tracking the entity/entities in the Added state. Item(s) will be added when
SaveChanges is called. Async versions are available as well.
AsAsyncEnumerable Returns the collection as IAsyncEnumerable<T>.
AsQueryable Returns the collection as IQueryable<T>.
Find Searches for the entity in the ChangeTracker by primary key. If not found in
the change tracker, the data store is queried for the object. An async version is
available as well.
Update/UpdateRange Begins tracking the entity/entities in the Modified state. Item(s) will be updated
when SaveChanges is called. Async versions are available as well.
Remove/RemoveRange Begins tracking the entity/entities in the Deleted state. Item(s) will be removed
when SaveChanges is called. Async versions are available as well.
Attach/AttachRange Begins tracking the entity/entities. Entities with numeric primary keys defined as
an identity and value equaling zero are tracked as Added. All others are tracked as
Unchanged. Async versions are available as well.
FromSqlRaw/
FromSqlInterpolated
Creates a LINQ query based on a raw or interpolated string representing a SQL
query. Can be combined with additional LINQ statements for server-side execution.
AsQueryable() Returns an IQueryable<T> instance from DbSet<T>.


