Programming with Timer Callbacks
the need to call a specific method during regular intervals of time.

such as checking for new email messages. For situations such
as these, you can use the System.Threading.Timer type in conjunction with a related delegate named
TimerCallback.

using System;
using System.Threading;
Console.WriteLine("***** Working with Timer type *****\n");
Console.ReadLine();
static void PrintTime(object state)
{
Console.WriteLine("Time is: {0}",
DateTime.Now.ToLongTimeString());
}


a single parameter of type System.Object and returns void. This
is not optional, given that the TimerCallback delegate can only call methods that match this signature.


// Create the delegate for the Timer type.
TimerCallback timeCB = new TimerCallback(PrintTime);

// Establish timer settings.
Timer t = new Timer(
timeCB, // The TimerCallback delegate object.
null, // Any info to pass into the called method (null for no info).
0, // Amount of time to wait before starting (in milliseconds).
1000); // Interval of time between calls (in milliseconds).


If you did want to send in some information for use by the delegate target, simply substitute the null
value of the second constructor parameter with the appropriate information, like so:
// Establish timer settings.
Timer t = new Timer(timeCB, "Hello From C# 9.0", 0, 1000);
You can then obtain the incoming data as follows:static void PrintTime(object state)
{
Console.WriteLine("Time is: {0}, Param is: {1}",
DateTime.Now.ToLongTimeString(), state.ToString());


