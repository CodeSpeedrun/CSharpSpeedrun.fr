Connection Resiliency

. The method used with SqlServerOptions is
EnableRetryOnFailure() and is demonstrated here:
public ApplicationDbContext CreateDbContext(string[] args)
{
var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
var connectionString = @"server=.,5433;Database=AutoLot50;User Id=sa;Password=P@ssw0rd;";
optionsBuilder.UseSqlServer(connectionString, options => options.EnableRetryOnFailure());
return new ApplicationDbContext(optionsBuilder.Options);
}


try
{
Context.SaveChanges();
}
catch (RetryLimitExceededException ex)
{
//A retry limit error occurred
//Should handle intelligently
Console.WriteLine($"Retry limit exceeded! {ex.Message}");
}

