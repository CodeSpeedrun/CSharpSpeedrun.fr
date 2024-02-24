Await in catch and finally Blocks

static async Task<string> MethodWithTryCatch()
{
try
{
//Do some work
return "Hello";
}
catch (Exception ex)
{
await LogTheErrors();
throw;
}
finally
{
await DoMagicCleanUp();
}
}