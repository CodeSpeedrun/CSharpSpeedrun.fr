Query Types

Query types are DbSet<T> collections that are used to represent views, a SQL statement, or tables without a
primary key.

modelBuilder.Entity<CustomerOrderViewModel>().HasNoKey().ToView("CustomerOrderView", "dbo");
Query types can also be mapped to a SQL query, as shown here:
modelBuilder.Entity<CustomerOrderViewModel>().HasNoKey().ToSqlQuery(
@"SELECT c.FirstName, c.LastName, i.Color, i.PetName, m.Name AS Make
FROM dbo.Orders o
INNER JOIN dbo.Customers c ON o.CustomerId = c.Id
INNER JOIN dbo.Inventory i ON o.CarId = i.Id
INNER JOIN dbo.Makes m ON m.Id = i.MakeId");
The final mechanisms that query types can be used with are the FromSqlRaw() and
FromSqlInterpolated() methods. Here is an example of the same query but using FromSqlRaw():
public IEnumerable<CustomerOrderViewModel> GetOrders()
{
return CustomerOrderViewModels.FromSqlRaw(
@"SELECT c.FirstName, c.LastName, i.Color, i.PetName, m.Name AS Make
FROM dbo.Orders o
INNER JOIN dbo.Customers c ON o.CustomerId = c.Id
INNER JOIN dbo.Inventory i ON o.CarId = i.Id
INNER JOIN dbo.Makes m ON m.Id = i.MakeId");
}