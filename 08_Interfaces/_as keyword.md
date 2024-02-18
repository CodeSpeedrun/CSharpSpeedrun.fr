## as-keyword
The as keyword converts a class instance to an interface type that it implements. We check for null values 
to ensure the cast was successful.

```csharp
using System;
namespace CSharpSpeedrun
{
    interface IRobot
    {
        void BootUpSound();
    }

    class IndustrialRobot : IRobot
    {
        void IRobot.BootUpSound()
        {
            Console.WriteLine("I am ready to rock and roll!");
        }
        public void SendNotification()
        {
            Console.WriteLine("Email sent");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            IndustrialRobot starIndustrialRobot = new IndustrialRobot();

            IRobot starIndustrialRobot_2 = starIndustrialRobot as IRobot;
            if (starIndustrialRobot_2 != null)
            {
                starIndustrialRobot_2.BootUpSound();
            }
        }
    }
}
//I am ready to rock and roll!
```