Creating the GetPetName() Stored Procedure

invoke stored procedures. As you might already
know, stored procedures are code routines stored within a database that do something. Like C# methods,
stored procedures can return data or just operate on data without returning anything.

USE [AutoLot]
GO
CREATE PROCEDURE [dbo].[GetPetName]
@carID int,
@petName nvarchar(50) output
AS
SELECT @petName = PetName from dbo.Inventory where Id = @carID
GO

