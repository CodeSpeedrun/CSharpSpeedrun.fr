Entity Conventions

There are many conventions that EF Core uses to define an entity and how it relates to the data store.

Some of the EF Core Conventions
Convention Meaning in Life
Included
tables
All classes with a DbSet property and all classes that can be reached (through navigation
properties) by a DbSet class are created in the database.
Included
columns
All public properties with a getter and setter (including automatic properties) are mapped
to columns.
Table name Maps to the name of the DbSet property name in the derived DbContext. If no DbSet exists,
the class name is used.
Schema Tables are created in the data store’s default schema (dbo on SQL Server).
Column name Column names are mapped to the property names of the class.
Column data
type
Data types are selected based on the .NET Core data type and translated by the
database provider (SQL Server). DateTime maps to datetime2(7), and string maps to
nvarchar(max). Strings as part of a primary key map to nvarchar(450).
Column
nullability
Non-nullable data types are created as Not Null persistence columns. EF Core honors C# 8
nullability.
Primary key Properties named Id or <EntityTypeName>Id will be configured as the primary key. Keys
of type short, int, long, or Guid have values controlled by the data store. Numerical values
are created as Identity columns (SQL Server).
Relationships Relationships between tables are created when there are navigation properties between
two entity classes.
Foreign key Properties named <OtherClassName>Id are foreign keys for navigation properties of type
<OtherClassName>.


