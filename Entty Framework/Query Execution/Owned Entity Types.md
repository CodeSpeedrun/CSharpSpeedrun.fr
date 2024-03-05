Owned Entity Types


When types marked with the [Owned] attribute (or
configured with the Fluent API) are added as a property of an entity, EF Core will add all the properties from
the [Owned] entity class to the owning entity. This increases the possibility of C# code reuse.

[Owned]
public class Person
{
[Required, StringLength(50)]
public string FirstName { get; set; } = "New";
[Required, StringLength(50)]
public string LastName { get; set; } = "Customer";
}
This is used by the Customer class:
[Table("Customers", Schema = "Dbo")]
public partial class Customer : BaseEntity
{
public Person PersonalInformation { get; set; } = new Person();
[JsonIgnore]
[InverseProperty(nameof(CreditRisk.CustomerNavigation))]
public IEnumerable<CreditRisk> CreditRisks { get; set; } = new List<CreditRisk>();
[JsonIgnore]
[InverseProperty(nameof(Order.CustomerNavigation))]
public IEnumerable<Order> Orders { get; set; } = new List<Order>();
}
By default, the two Person properties are mapped to columns named PersonalInformation_
FirstName and PersonalInformation_LastName. To change this, add the following Fluent API code to the
OnConfiguring() method:
modelBuilder.Entity<Customer>(entity =>
{
entity.OwnsOne(o => o.PersonalInformation,
pd =>
{


pd.Property<string>(nameof(Person.FirstName))
.HasColumnName(nameof(Person.FirstName))
.HasColumnType("nvarchar(50)");
pd.Property<string>(nameof(Person.LastName))
.HasColumnName(nameof(Person.LastName))
.HasColumnType("nvarchar(50)");
});
});
The resulting table is created like this (note that the nullability of the FirstName and LastName columns
doesn’t match the data annotations on the Person owned entity):
CREATE TABLE [dbo].[Customers](
[Id] [int] IDENTITY(1,1) NOT NULL,
[FirstName] [nvarchar](50) NULL,
[LastName] [nvarchar](50) NULL,
[TimeStamp] [timestamp] NULL,
[FullName] AS (([LastName]+', ')+[FirstName]),
CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS
= ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


The other option is to
add a Fluent API statement to make the navigation property required.
modelBuilder.Entity<Customer>(entity =>
{
entity.OwnsOne(o => o.PersonalInformation,
pd =>
{
pd.Property<string>(nameof(Person.FirstName))
.HasColumnName(nameof(Person.FirstName))
.HasColumnType("nvarchar(50)");
pd.Property<string>(nameof(Person.LastName))
.HasColumnName(nameof(Person.LastName))
.HasColumnType("nvarchar(50)");
});
entity.Navigation(c => c.PersonalInformation).IsRequired(true);
});

