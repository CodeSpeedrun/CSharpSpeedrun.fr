Creating the Inventory to Makes Relationship

Open a new query, enter the following SQL, and click Run (or press F5):
USE [AutoLot]
GO
CREATE NONCLUSTERED INDEX [IX_Inventory_MakeId] ON [dbo].[Inventory]
(
[MakeId] ASC
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Inventory] WITH CHECK ADD CONSTRAINT [FK_Make_Inventory] FOREIGN
KEY([MakeId])
REFERENCES [dbo].[Makes] ([Id])
GO
ALTER TABLE [dbo].[Inventory] CHECK CONSTRAINT [FK_Make_Inventory]
GO

