/* What is abstraction?
Data abstraction is the process of showing only the crucial data to the user. For example, we can use the brakes of a car or bike without knowing how it works internally.
Some of the ways to achieve abstraction are:

Abstract class and abstract method. An abstract class describes something abstract, something that is more of a concept than a tangible thing. It cannot instantiate objects, but other classes can inherit its members and create objects. Addtionally, an abstract class contains both abstract and regular methods.
Note the abstract method does not contain any body, the content is provided by the child class. A class inheriting an asbtract class is binded by contract to implement all the abstract methods.
It can only be placed inside an abstract class.

Interfaces
*/
 using System;
namespace CSharpSpeedrun
{
    abstract class Clock
    {
        public abstract void AlarmSound();
 
        public void ShutDown()
        {
            Console.WriteLine("Shut down initiated.");
        }
    }
    
    class AlarmClock : Clock //child class 
    {
        public override void AlarmSound()
        {
            Console.WriteLine("Rise and shine!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock myAlarmClock = new AlarmClock();
            myAlarmClock.AlarmSound();
            myAlarmClock.ShutDown();  
        }
    }
}
//Rise and shine!
//Shut down initiated.