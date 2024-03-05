Table-per-Type Mapping (TPT)

Since TPH is the default, EF Core must be instructed to map each class to a table. This
can be done with data annotations or the Fluent API. Add the following code to ApplicationDbContext:
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
modelBuilder.Entity<BaseEntity>().ToTable("BaseEntities");
modelBuilder.Entity<Car>().ToTable("Cars");
OnModelCreatingPartial(modelBuilder);
}
partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

To “reset” the database and the project, delete the Migrations folder and the database. To force delete the
database using the CLI, enter the following:
dotnet ef database drop -f -c AutoLot.Samples.ApplicationDbContext
Now create and apply the migration for the TPT pattern.
dotnet ef migrations add TPT -o Migrations -c AutoLot.Samples.ApplicationDbContext
dotnet ef database update TPT -c AutoLot.Samples.ApplicationDbContext
EF Core will create the following tables when updating the database. The indexes also show that the
tables have a one-to-one mapping.
CREATE TABLE [dbo].[BaseEntities](
[Id] [int] IDENTITY(1,1) NOT NULL,
[TimeStamp] [varbinary](max) NULL,
CONSTRAINT [PK_BaseEntities] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS
= ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
CREATE TABLE [dbo].[Inventory](
[Id] [int] NOT NULL,
[MakeId] [int] NOT NULL,
[Color] [nvarchar](max) NULL,
[PetName] [nvarchar](max) NULL,
CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS
= ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Inventory] WITH CHECK ADD CONSTRAINT [FK_Inventory_BaseEntities_Id]
FOREIGN KEY([Id])
REFERENCES [dbo].[BaseEntities] ([Id])
GO
ALTER TABLE [dbo].[Inventory] CHECK CONSTRAINT [FK_Inventory_BaseEntities_Id]
GO


