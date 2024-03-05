Enumerating Files with the DirectoryInfo Type

static void DisplayImageFiles()
{
DirectoryInfo dir = new
DirectoryInfo(@"C:\Windows\Web\Wallpaper");
// Get all files with a *.jpg extension.
FileInfo[] imageFiles =
dir.GetFiles("*.jpg", SearchOption.AllDirectories);
// How many were found?
Console.WriteLine("Found {0} *.jpg files\n", imageFiles.Length);
// Now print out info for each file.
foreach (FileInfo f in imageFiles)
{
Console.WriteLine("***************************");
Console.WriteLine("File name: {0}", f.Name);
Console.WriteLine("File size: {0}", f.Length);
Console.WriteLine("Creation: {0}", f.CreationTime);
Console.WriteLine("Attributes: {0}", f.Attributes);


static void ModifyAppDirectory()
{
DirectoryInfo dir = new DirectoryInfo(".");
// Create \MyFolder off initial directory.
dir.CreateSubdirectory("MyFolder");
// Capture returned DirectoryInfo object.
DirectoryInfo myDataFolder = dir.CreateSubdirectory(
$@"MyFolder2{Path.DirectorySeparatorChar}Data");
// Prints path to ..\MyFolder2\Data.
Console.WriteLine("New Folder is: {0}", myDataFolder);


