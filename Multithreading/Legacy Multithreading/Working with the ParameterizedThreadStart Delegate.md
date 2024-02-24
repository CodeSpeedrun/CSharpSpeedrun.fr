Working with the ParameterizedThreadStart Delegate

the ThreadStart delegate can point only to methods that return void and take no arguments

want to pass data to the method executing on the secondary
thread, you will need to use the ParameterizedThreadStart delegate type.

namespace AddWithThreads
{
class AddParams
{
public int a, b;
public AddParams(int numb1, int numb2)
{
a = numb1;
b = numb2;


void Add(object data)
{
if (data is AddParams ap)
{
Console.WriteLine("ID of thread in Add(): {0}",
Thread.CurrentThread.ManagedThreadId);
Console.WriteLine("{0} + {1} is {2}",



The code within Program.cs is straightforward. Simply use ParameterizedThreadStart rather than
ThreadStart, like so:
using System;
using System.Threading;
using AddWithThreads;
Console.WriteLine("***** Adding with Thread objects *****");
Console.WriteLine("ID of thread in Main(): {0}",
Thread.CurrentThread.ManagedThreadId);
// Make an AddParams object to pass to the secondary thread.
AddParams ap = new AddParams(10, 10);
Thread t = new Thread(new ParameterizedThreadStart(Add));
t.Start(ap);


