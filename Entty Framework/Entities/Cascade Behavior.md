Cascade Behavior

Most data stores (like SQL Server) have rules controlling the behavior when a row is deleted. If the related
(dependent) records should also be deleted, this is referred to as cascade delete.


Dependent records are deleted.
• Dependent foreign keys are set to null.
• The dependent entity remains unchanged.


