Table-per-Hierarchy Mapping (TPH)

using System.Collections.Generic;
namespace AutoLot.Samples.Models
{
public abstract class BaseEntity
{
public int Id { get; set; }
public byte[] TimeStamp { get; set; }
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
}
}

dotnet tool install --global dotnet-ef --version 5.0.1
dotnet ef migrations add TPH -o Migrations -c AutoLot.Samples.ApplicationDbContext
dotnet ef database update TPH -c AutoLot.Samples.ApplicationDbContext


CREATE TABLE [dbo].[Cars](
[Id] [int] IDENTITY(1,1) NOT NULL,
[MakeId] [int] NOT NULL,
[Color] [nvarchar](max) NULL,
[PetName] [nvarchar](max) NULL,
[TimeStamp] [varbinary](max) NULL,
CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS
= ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
The previous example relied on EF Core conventions (covered soon) to create the table and column
properties.