Query Execution

Data retrieval queries are created with LINQ queries written against the DbSet<T> properties.

For example, to get all yellow Car records from the database, execute the following query:
var cars = Context.Cars.Where(x=>x.Color == "Yellow");
With deferred execution, that database is not actually queried until the results are iterated over. To have
the query execute immediately, use ToList().
var cars = Context.Cars.Where(x=>x.Color == "Yellow").ToList();
Since queries aren’t executed until triggered, they can be built up over multiple lines of code. The
following code sample executes the same as the previous example:
var query = Context.Cars.AsQueryable();
query = query.Where(x=>x.Color == "Yellow");
var cars = query.ToList();

