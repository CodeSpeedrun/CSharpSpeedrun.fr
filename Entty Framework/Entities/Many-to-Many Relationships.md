Many-to-Many Relationships


namespace AutoLot.Samples.Models
{
public class Car : BaseEntity
{
public string Color { get; set; }
public string PetName { get; set; }
public int MakeId { get; set; }
public Make MakeNavigation { get; set; }
public Radio RadioNavigation { get; set; }
public IEnumerable<Driver> Drivers { get; set; } = new List<Driver>();
}
}
namespace AutoLot.Samples.Models
{
public class Driver : BaseEntity
{
public string FirstName { get; set; }
public string LastName { get; set; }
public IEnumerable<Car> Cars { get; set; } = new List<Car>();
}
}


public class Driver
{
...
public IEnumerable<CarDriver> CarDrivers { get; set; }
}

public class Car
{
...
public IEnumerable<CarDriver> CarDrivers { get; set; }
}
public class CarDriver
{
public int CarId {get;set;}
public Car CarNavigation {get;set;}
public int DriverId {get;set;}
public Driver DriverNavigation {get;set;}
}
Add DbSet<Driver> to ApplicationDbContext.
public virtual DbSet<Car> Cars { get; set; }
public virtual DbSet<Make> Makes { get; set; }
public virtual DbSet<Radio> Radios { get; set; }
public virtual DbSet<Driver> Drivers { get; set; }
Create the migration and update the database using the following commands:
dotnet ef migrations add Many2Many -o Migrations -c AutoLot.Samples.ApplicationDbContext
dotnet ef database update many2Many -c AutoLot.Samples.ApplicationDbContext
When the database is updated using EF Core migrations, the Cars table is unchanged, and the Drivers
and CarDriver tables are created.
CREATE TABLE [dbo].[Drivers](
[Id] [INT] IDENTITY(1,1) NOT NULL,
[FirstName] [NVARCHAR](MAX) NULL,
[LastName] [NVARCHAR](MAX) NULL,
[TimeStamp] [VARBINARY](MAX) NULL,
CONSTRAINT [PK_Drivers] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS
= ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
CREATE TABLE [dbo].[CarDriver](
[CarsId] [int] NOT NULL,
[DriversId] [int] NOT NULL,
CONSTRAINT [PK_CarDriver] PRIMARY KEY CLUSTERED
(
[CarsId] ASC,
[DriversId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS
= ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CarDriver] WITH CHECK ADD CONSTRAINT [FK_CarDriver_Cars_CarsId] FOREIGN
KEY([CarsId])
REFERENCES [dbo].[Cars] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarDriver] CHECK CONSTRAINT [FK_CarDriver_Cars_CarsId]
GO
ALTER TABLE [dbo].[CarDriver] WITH CHECK ADD CONSTRAINT [FK_CarDriver_Drivers_DriversId]
FOREIGN KEY([DriversId])
REFERENCES [dbo].[Drivers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarDriver] CHECK CONSTRAINT [FK_CarDriver_Drivers_DriversId]
GO


