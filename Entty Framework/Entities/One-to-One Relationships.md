One-to-One Relationships

In one-to-one relationships, both entities have a reference navigation property to the other entity. While
one-to-many relationships clearly denote the principal and dependent entity, when building one-to-one
relationships, EF Core must be informed which side is the principal either by having a clearly defined foreign
key to the principal entity or by indicating the principal using the Fluent API

amespace AutoLot.Samples.Models
{
public class Car : BaseEntity
{


public string Color { get; set; }
public string PetName { get; set; }
public int MakeId { get; set; }
public Make MakeNavigation { get; set; }
public Radio RadioNavigation { get; set; }
}
}
namespace AutoLot.Samples.Models
{
public class Radio : BaseEntity
{
public bool HasTweeters { get; set; }
public bool HasSubWoofers { get; set; }
public string RadioId { get; set; }
public int CarId { get; set; }
public Car CarNavigation { get; set; }
}
}

public virtual DbSet<Car> Cars { get; set; }
public virtual DbSet<Make> Makes { get; set; }
public virtual DbSet<Radio> Radios { get; set; }
Create the migration and update the database using the following commands:
dotnet ef migrations add One2One -o Migrations -c AutoLot.Samples.ApplicationDbContext
dotnet ef database update One2One -c AutoLot.Samples.ApplicationDbContext
When the database is updated using EF Core migrations, the Cars table is unchanged, and the following
Radios table is created:
CREATE TABLE [dbo].[Radios](
[Id] [int] IDENTITY(1,1) NOT NULL,
[HasTweeters] [bit] NOT NULL,
[HasSubWoofers] [bit] NOT NULL,
[RadioId] [nvarchar](max) NULL,
[TimeStamp] [varbinary](max) NULL,
[CarId] [int] NOT NULL,
CONSTRAINT [PK_Radios] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS
= ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


ALTER TABLE [dbo].[Radios] WITH CHECK ADD CONSTRAINT [FK_Radios_Cars_CarId] FOREIGN
KEY([CarId])
REFERENCES [dbo].[Cars] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Radios] CHECK CONSTRAINT [FK_Radios_Cars_CarId]
GO


