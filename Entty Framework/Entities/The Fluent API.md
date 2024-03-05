The Fluent API

The methods are exposed by the
ModelBuilder instance available in the DbContext OnModelCreating() method.



Class and Property Mapping

modelBuilder.Entity<Car>(entity =>
{
entity.ToTable("Inventory","dbo");
entity.HasKey(e=>e.Id);
entity.HasIndex(e => e.MakeId, "IX_Inventory_MakeId");
entity.Property(e => e.Color)
.IsRequired()
.HasMaxLength(50);
entity.Property(e => e.PetName)
.IsRequired()
.HasMaxLength(50);
entity.Property(e => e.TimeStamp)
.IsRowVersion()
.IsConcurrencyToken();
});



Default Values
The Fluent API provides methods to set default values for columns. The default value can be a value type or a
SQL string. For example, to set the default Color for a new Car to Black, use the following:
modelBuilder.Entity<Car>(entity =>
{
...
entity.Property(e => e.Color)
.HasColumnName("CarColor")
.IsRequired()
.HasMaxLength(50)
.HasDefaultValue("Black");
});

modelBuilder.Entity<Car>(entity =>
{
...
entity.Property(e => e.DateBuilt)
.HasDefaultValueSql("getdate()");
});


//ApplicationDbContext
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
modelBuilder.Entity<Car>(entity =>
{
...
entity.Property(e => e.IsDrivable).HasDefaultValue(true);
});


public class Car
{
...
private bool? _isDrivable;
public bool IsDrivable
{
get => _isDrivable ?? true;
set => _isDrivable = value;
}
The Fluent API is used to inform EF Core of the backing field.
modelBuilder.Entity<Car>(entity =>
{
entity.Property(p => p.IsDrivable)
.HasField("_isDrivable")
.HasDefaultValue(true);
});


EF Core translates the field to the following SQL definition:
CREATE TABLE [dbo].[Inventory](
...
[IsDrivable] [BIT] NOT NULL,
...
GO


ALTER TABLE [dbo].[Inventory] ADD DEFAULT (CONVERT([BIT],(1))) FOR [IsDrivable]
GO



