Saving Changes
To trigger DbContext and ChangeTracker to persist any changes in the tracked entities, call the
SaveChanges() (or SaveChangesAsync()) method on the derived DbContext.
static void SampleSaveChanges()
{
//The factory is not meant to be used like this, but it’s demo code :-)
var context = new ApplicationDbContextFactory().CreateDbContext(null);
//make some changes
context.SaveChanges();
}


Transaction and Save Point Support
Conduct your operations as usual and then commit or roll back the transaction. Here is a code
snippet that demonstrates this:
using var trans = context.Database.BeginTransaction();
try
{
//Create, change, delete stuff
context.SaveChanges();
trans.Commit();
}
catch (Exception ex)
{
trans.Rollback();
}



Save
points can also be managed programmatically by calling CreateSavePoint() and RollbackToSavepoint()
on the transaction, like this:
using var trans = context.Database.BeginTransaction();
try
{
//Create, change, delete stuff
trans.CreateSavepoint("check point 1");
context.SaveChanges();
trans.Commit();
}
catch (Exception ex)
{
trans. RollbackToSavepoint("check point 1");
}



