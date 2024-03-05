Transactions and Execution Strategies

var strategy = context.Database.CreateExecutionStrategy();
strategy.Execute(() =>
{
using var trans = context.Database.BeginTransaction();
try

{
actionToExecute();
trans.Commit();
}
catch (Exception ex)
{
trans.Rollback();
}
});




Saving/Saved Changes Events

public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
: base(options)
{
SavingChanges += (sender, args) =>
{
Console.WriteLine($"Saving changes for {((DbContext)sender).Database.
GetConnectionString()}");
};
SavedChanges += (sender, args) =>
{
Console.WriteLine($"Saved {args.EntitiesSavedCount} entities");
};
SaveChangesFailed += (sender, args) =>
{
Console.WriteLine($"An exception occurred! {args.Exception.Message} entities");
};
}


