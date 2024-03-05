One-to-Many Relationships

To create a one-to-many relationship, the entity class on the one side (the principal) adds a collection
property of the entity class that is on the many side (the dependent). The dependent entity should also have
properties for the foreign key back to the principal.


using System.Collections.Generic;
namespace AutoLot.Samples.Models
{
public class Make : BaseEntity
{
public string Name { get; set; }
public IEnumerable<Car> Cars { get; set; } = new List<Car>();
}
}
using System.Collections.Generic;
namespace AutoLot.Samples.Models
{
public class Car : BaseEntity
{
public string Color { get; set; }
public string PetName { get; set; }
public int MakeId { get; set; }
public Make MakeNavigation { get; set; }
}
}


In the Car/Make example, the Car entity is the dependent entity (the many of the one-to-many), and the
Make entity is the principal entity (the one of the one-to-many).
Add the DbSet<Make> instance to ApplicationDbContext, as shown here:
public DbSet<Car> Cars { get; set; }
public DbSet<Make> Makes { get; set; }
Create the migration and update the database using the following commands:
dotnet ef migrations add One2Many -o Migrations -c AutoLot.Samples.ApplicationDbContext
dotnet ef database update One2Many -c AutoLot.Samples.ApplicationDbContext


When the database is updated using EF Core migrations, the following tables are created:
CREATE TABLE [dbo].[Makes](
[Id] [int] IDENTITY(1,1) NOT NULL,
[Name] [nvarchar](max) NULL,
[TimeStamp] [varbinary](max) NULL,
CONSTRAINT [PK_Makes] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS
= ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
CREATE TABLE [dbo].[Cars](
[Id] [int] IDENTITY(1,1) NOT NULL,
[Color] [nvarchar](max) NULL,
[PetName] [nvarchar](max) NULL,
[TimeStamp] [varbinary](max) NULL,
[MakeId] [int] NOT NULL,
CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS
= ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cars] WITH CHECK ADD CONSTRAINT [FK_Cars_Makes_MakeId] FOREIGN
KEY([MakeId])
REFERENCES [dbo].[Makes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Makes_MakeId]
GO
Note the foreign key and check constraints created on the dependent (Cars) table.