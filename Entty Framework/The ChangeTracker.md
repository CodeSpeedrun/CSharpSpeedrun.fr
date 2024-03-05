The ChangeTracker

The ChangeTracker instance tracks the state for objects loaded into DbSet<T> within a DbContext instance.

Entity State Enumeration Values
Value Meaning in Life
Added The entity is being tracked but does not yet exist in the database.
Deleted The entity is being tracked and is marked for deletion from the database.
Detached The entity is not being tracked by the change tracker.
Modified The entry is being tracked and has been changed.
Unchanged The entity is being tracked, exists in the database, and has not been modified


If you need to check the state of an object, use the following code:
EntityState state = context.Entry(entity).State;
You can also programmatically change the state of an object using the same mechanism. To change the
state to Deleted (for example), use the following code:
context.Entry(entity).State = EntityState.Deleted;

