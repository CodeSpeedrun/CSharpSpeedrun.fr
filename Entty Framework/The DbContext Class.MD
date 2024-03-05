The DbContext Class

DbContext is the ringleader component of EF Core and provides access to the database through the
Database property. DbContext manages the ChangeTracker instance, exposes the virtual OnModelCreating
method for access to the Fluent API, holds all of the DbSet<T> properties, and supplies the SaveChanges
method to persist data to the data store. It is not used directly, but through a custom class that inherits
DbContext. It is in this class that the DbSet<T> properties are placed.


Common Members of DbContext
Member of DbContext Meaning in Life
Database Provides access to database-related information and functionality, including
execution of SQL statements.
Model The metadata about the shape of entities, the relationships between them, and
how they map to the database. Note: This property is usually not interacted with
directly.
ChangeTracker Provides access to information and operations for entity instances this
DbContext is tracking.
DbSet<T> Not truly a member of DbContext, but properties added to the custom derived
DbContext class. The properties are of type DbSet<T> and are used to query and
save instances of application entities. LINQ queries against DbSet<T> properties
are translated into SQL queries.
Entry Provides access to change tracking information and operations for the entity,
such as explicitly loading related entities or changing the EntityState. Can also
be called on an untracked entity to change the state to tracked.
Set<TEntity> Creates an instance of the DbSet<T> property that can be used to query and
persist data.


namespace AutoLot.Samples
{
public class ApplicationDbContext : DbContext
{
public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
: base(options)
{
}
}
}
This is the class that is used to access the database and work with entities, the change tracker, and all
components of EF Core.


Configuring the DbContext
The DbContext instance is configured using an instance of the DbContextOptions class. The
DbContextOptions instance is created using DbContextOptionsBuilder, as the DbContextOptions class is
not meant to be directly constructed in your code

The Design-Time DbContext Factory
The design-time DbContext factory is a class that implements the IDesignTimeDbContextFactory<T>
interface, where T is the derived DbContext class. The interface has one


using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace AutoLot.Samples
{
public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDb
Context>
{

public ApplicationDbContext CreateDbContext(string[] args)
{
var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
var connectionString = @"server=.,5433;Database=AutoLotSamples;User Id=sa;Password=
P@ssw0rd;";
optionsBuilder.UseSqlServer(connectionString);
Console.WriteLine(connectionString);
return new ApplicationDbContext(optionsBuilder.Options);
}
}
}


OnModelCreating
The base DbContext class exposes the OnModelCreating method that is used to shape your entities using
the Fluent API. This will be covered in depth later in this chapter, but for now, add the following code to the
ApplicationDbContext class:
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
// Fluent API calls go here
OnModelCreatingPartial(modelBuilder);
}
partial void OnModelCreatingPartial(ModelBuilder modelBuilder);






