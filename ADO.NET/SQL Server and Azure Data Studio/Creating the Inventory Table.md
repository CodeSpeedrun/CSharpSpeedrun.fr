Creating the Inventory Table

With the database created, it is time to create the tables. First up is the Inventory table. Open a new query
and enter the following SQL:
USE [AutoLot]
GO
CREATE TABLE [dbo].[Inventory](
[Id] [int] IDENTITY(1,1) NOT NULL,
[MakeId] [int] NOT NULL,
[Color] [nvarchar](50) NOT NULL,
[PetName] [nvarchar](50) NOT NULL,
[TimeStamp] [timestamp] NULL,
CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED
(
[Id] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO

