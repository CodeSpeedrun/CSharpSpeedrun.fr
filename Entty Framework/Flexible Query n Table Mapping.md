Flexible Query/Table Mapping

These objects can
be tables, views, or functions.

EF Core will then query from the view
and send updates to the table.
modelBuilder.Entity<CarViewModel>()
.ToTable("Inventory")
.ToView("InventoryWithMakesView");


