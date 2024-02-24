The Role of ConfigureAwait

Console.WriteLine(" Fun With Async ===>");
//Console.WriteLine(DoWork());
string message = await DoWorkAsync();
Console.WriteLine(message);
string message1 = await DoWorkAsync().ConfigureAwait(false);
Console.WriteLine(message1);

Guidance from the .NET Core team suggests that when developing application code (WinForms, WPF,
etc.) to leave the default behavior in place. If you are writing nonapplication code (e.g., library code), then
use ConfigureAwait(false). The one exception for this is ASP.NET Core (covered in part 9). ASP.NET Core
does not create a custom SynchronizationContext; therefore, ConfigureAwait(false) does not provide the
benefit when using other frameworks.


