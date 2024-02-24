The Task Class

private void cmdProcess_Click(object sender, EventArgs e)
{
// Start a new "task" to process the files.
Task.Factory.StartNew(() => ProcessFiles());
//Can also be written this way
//Task.Factory.StartNew(ProcessFiles);

The Factory property of Task returns a TaskFactory object. When you call its StartNew() method,
you pass in an Action<T> delegate (here, hidden away with a fitting lambda expression) that points to the
method to invoke in an asynchronous manner.

