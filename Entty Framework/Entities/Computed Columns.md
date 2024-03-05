Computed Columns

modelBuilder.Entity<Car>(entity =>
{
entity.Property(p => p.FullName)
.HasComputedColumnSql("[PetName] + ' (' + [Color] + ')'");
});
New in EF Core 5, the computed values can be persisted, so the value is calculated only on row creation
or update. While SQL Server supports this, not all data stores do, so check the documentation of your
database provider.
modelBuilder.Entity<Car>(entity =>
{
entity.Property(p => p.FullName)
.HasComputedColumnSql("[PetName] + ' (' + [Color] + ')'", stored:true);
});


One-to-Many Relationships
To use the Fluent API to define one-to-many relationships, pick one of the entities to update. Both sides of
the navigation chain are set in one block of code.
modelBuilder.Entity<Car>(entity =>
{
...
entity.HasOne(d => d.MakeNavigation)
.WithMany(p => p.Cars)
.HasForeignKey(d => d.MakeId)
.OnDelete(DeleteBehavior.ClientSetNull)
.HasConstraintName("FK_Inventory_Makes_MakeId");
});
If you select the principal entity as the base for the navigation property configuration, the code looks
like this:
modelBuilder.Entity<Make>(entity =>
{
...
entity.HasMany(e=>e.Cars)
.WithOne(c=>c.MakeNavigation)
.HasForeignKey(c=>c.MakeId)


.OnDelete(DeleteBehavior.ClientSetNull)
.HasConstraintName("FK_Inventory_Makes_MakeId");
});
One-to-One Relationships
One-to-one relationships are configured the same way, except that the WithOne() Fluent API method is used
instead of WithMany(). A unique index is added to the dependent entity. Here is the code for the relationship
between the Car and Radio entities using the dependent entity (Radio):
modelBuilder.Entity<Radio>(entity =>
{
entity.HasIndex(e => e.CarId, "IX_Radios_CarId")
.IsUnique();
entity.HasOne(d => d.CarNavigation)
.WithOne(p => p.RadioNavigation)
.HasForeignKey<Radio>(d => d.CarId);
});


modelBuilder.Entity<Radio>(entity =>
{
entity.HasIndex(e => e.CarId, "IX_Radios_CarId")
.IsUnique();
});
modelBuilder.Entity<Car>(entity =>
{
entity.HasOne(d => d.RadioNavigation)
.WithOne(p => p.CarNavigation)
.HasForeignKey<Radio>(d => d.CarId);
});


Many-to-Many Relationships
Many-to-many relationships are much more customizable with the Fluent API. The foreign key field names,
index names, and cascade behavior can all be set in the statements that define the relationship. Here is the
many-to-many relationship example from earlier replicated using the Fluent API (the keys and columns
names are changed to make them more readable):
modelBuilder.Entity<Car>()
.HasMany(p => p.Drivers)
.WithMany(p => p.Cars)
.UsingEntity<Dictionary<string, object>>(
"CarDriver",
j => j

.HasOne<Driver>()
.WithMany()
.HasForeignKey("DriverId")
.HasConstraintName("FK_CarDriver_Drivers_DriverId")
.OnDelete(DeleteBehavior.Cascade),
j => j
.HasOne<Car>()
.WithMany()
.HasForeignKey("CarId")
.HasConstraintName("FK_CarDriver_Cars_CarId")
.OnDelete(DeleteBehavior.ClientCascade));

