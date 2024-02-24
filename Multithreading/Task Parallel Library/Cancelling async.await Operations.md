Cancelling async/await Operations

private async Task ProcessFile(string currentFile,
string outputDirectory, CancellationToken token)
{
string filename = Path.GetFileName(currentFile);
using (Bitmap bitmap = new Bitmap(currentFile))
{
try
{
await Task.Run(() =>
{
Dispatcher?.Invoke(() =>
{
this.Title = $"Processing {filename}";
});
bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
bitmap.Save(Path.Combine(outputDirectory, filename));
}
,token);
}
catch (OperationCanceledException ex)
{
Console.WriteLine(ex);
throw;
}
}
}
This method uses another overload of the Task.Run command, taking in the CancellationToken as a
parameter. The Task.Run command is wrapped in a try/catch block (just like the calling code) in case the
user clicks the Cancel button.


