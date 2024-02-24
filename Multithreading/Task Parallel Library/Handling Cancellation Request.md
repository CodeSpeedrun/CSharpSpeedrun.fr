Handling Cancellation Request

public partial class MainWindow :Window
{
// New Window-level variable.
private CancellationTokenSource _cancelToken = new CancellationTokenSource();
...
}

// Use ParallelOptions instance to store the CancellationToken.
ParallelOptions parOpts = new ParallelOptions();
parOpts.CancellationToken = _cancelToken.Token;
parOpts.MaxDegreeOfParallelism = System.Environment.ProcessorCount;
// Load up all *.jpg files, and make a new folder for the modified data.
string[] files = Directory.GetFiles(@".\TestPictures", "*.jpg", SearchOption.
AllDirectories);
string outputDirectory = @".\ModifiedPictures";
Directory.CreateDirectory(outputDirectory);
try
{
// Process the image data in a parallel manner!
Parallel.ForEach(files, parOpts, currentFile =>
{
parOpts
.CancellationToken.ThrowIfCancellationRequested();
string filename = Path.GetFileName(currentFile);
Dispatcher?.Invoke(() =>
{
this.Title =
$"Processing {filename} on thread {Thread.CurrentThread.ManagedThreadId}";
});
using (Bitmap bitmap = new Bitmap(currentFile))
{
bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
bitmap.Save(Path.Combine(outputDirectory, filename));
}
});
Dispatcher?.Invoke(()=>this.Title = "Done!");
}
catch (OperationCanceledException ex)
{
Dispatcher?.Invoke(()=>this.Title = ex.Message);


