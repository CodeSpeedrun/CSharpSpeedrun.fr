Local Functions (New 7.0)

static async Task MethodWithProblems(int firstParam, int secondParam)
{
Console.WriteLine("Enter");
await Task.Run(() =>
{
//Call long running method
Thread.Sleep(4_000);
Console.WriteLine("First Complete");
//Call another long running method that fails because
//the second parameter is out of range
Console.WriteLine("Something bad happened");

second long-running task fails because of invalid input data. You can (and
should) add checks to the beginning of the method, but since the entire method is asynchronous, there is no
guarantee when the checks will be executed.

static async Task MethodWithProblemsFixed(int firstParam, int secondParam)
{
Console.WriteLine("Enter");
if (secondParam < 0)
{
Console.WriteLine("Bad data");
return;
}
await actualImplementation();
async Task actualImplementation()
{
await Task.Run(() =>
{
//Call long running method
Thread.Sleep(4_000);
Console.WriteLine("First Complete");
//Call another long running method that fails because
//the second parameter is out of range


