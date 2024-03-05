Tracking vs. NoTracking Queries

When data is read from the database into a DbSet<T> instance, the entities (by default) are tracked by the
change tracker.


To load data into a DbSet<T> instance without adding the data to the ChangeTracker, add
AsNoTracking() into the LINQ statement. This signals EF Core to retrieve the data without adding it into
the ChangeTracker. For example, to load a Car record without adding it into the ChangeTracker, execute the
following:
public virtual Car? FindAsNoTracking(int id)
=> Table.AsNoTracking().FirstOrDefault(x => x.Id == id);

public virtual Car? FindAsNoTracking(int id)
=> Table.AsNoTrackingWithIdentityResolution().FirstOrDefault(x => x.Id == id);

