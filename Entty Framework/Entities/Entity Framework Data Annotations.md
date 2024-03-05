Entity Framework Data Annotations

Data annotations are C# attributes that are used to further shape your entities.


Data annotations override any conflicting conventions

Some Data Annotations Supported by the Entity Framework Core (*New Attributes in EF Core 5)
Data Annotation Meaning in Life
Table Defines the schema and table name for the entity.
Keyless* Indicates an entity does not have a key (e.g., representing a database view).
Column Defines the column name for the entity property.
BackingField* Specifies the C# backing field for a property.
Key Defines the primary key for the entity. Key fields are implicitly also [Required].
Index* Placed on a class to specify a single column or multicolumn index. Allows for
specifying the index is unique.
Owned Declares that the class will be owned by another entity class.
Required Declares the property as not nullable in the database.
ForeignKey Declares a property that is used as the foreign key for a navigation property.
InverseProperty Declares the navigation property on the other end of a relationship.
StringLength Specifies the max length for a string property.
TimeStamp Declares a type as a rowversion in SQL Server and adds concurrency checks to
database operations involving the entity.
ConcurrencyCheck Flags field to be used in concurrency checking when executing updates and deletes.
DatabaseGenerated Specifies if the field is database generated or not. Takes a DatabaseGeneratedOption
value of Computed, Identity, or None.
DataType Provides for a more specific definition of a field than the intrinsic data type.
NotMapped Excludes the property or class in regard to database fields and tables.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public abstract class BaseEntity
{
[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int Id { get; set; }
[Timestamp]
public byte[] TimeStamp { get; set; }
}
Here is the Car class and the data annotations that shape it in the database:
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
[Table("Inventory", Schema="dbo")]
[Index(nameof(MakeId), Name = "IX_Inventory_MakeId")]
public class Car : BaseEntity
{
[Required, StringLength(50)]
public string Color { get; set; }
[Required, StringLength(50)]
public string PetName { get; set; }
public int MakeId { get; set; }
[ForeignKey(nameof(MakeId))]
public Make MakeNavigation { get; set; }
[InverseProperty(nameof(Driver.Cars))]
public IEnumerable<Driver> Drivers { get; set; }
}


dotnet ef migrations add RemoveTimeStamp -o Migrations -c AutoLot.Samples.
ApplicationDbContext
dotnet ef database update RemoveTimeStamp -c AutoLot.Samples.ApplicationDbContext
Uncomment the TimeStamp property and data annotation and run these commands to add the property
to each table as a timestamp column:
dotnet ef migrations add ReplaceTimeStamp -o Migrations -c AutoLot.Samples.
ApplicationDbContext
dotnet ef database update ReplaceTimeStamp -c AutoLot.Samples.ApplicationDbContext
Now your database matches your model.


