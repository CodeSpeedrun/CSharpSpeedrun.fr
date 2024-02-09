/* as-keyword
The as keyword converts a class instance to an interface type that it implements. We check for null values to ensure the cast was successful.

*/ 
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

using System;
using System.Collections.Generic;

namespace CSharpSpeedrun
{
    public class Program
    {
        static void Main()
        {
            IMarkingSystem ms = getMarkingSystem();
            Console.WriteLine(ms.calculatePassingMark());
        }

        public static IMarkingSystem getMarkingSystem()
        {
            return new MarkingSystem2019();
        }
    }

    public class MarkingSystem2022 : IMarkingSystem
    {
        public float calculatePassingMark()
        {
            return 40;
        }
    }
    public class MarkingSystem2019 : IMarkingSystem
    {
        public float calculatePassingMark()
        {
            return 35;
        }

        public float calculateGPA()
        {
            return 3;
        }
    }
    public interface IMarkingSystem
    {
        float calculatePassingMark();
    }
}
//35

using System;

namespace CSharpSpeedrun
{
    public class Program
    {
        static void Main()
        {
            DrawUiElement(new TextBox());
        }

        static void DrawUiElement(IUIController uIController)
        {
            uIController.DrawElement();
        }
    }

    interface IUIController
    {
        void DrawElement();
    }

    public class Button : IUIController
    {
        public void DrawElement()
        {
            Console.WriteLine("Drawing Button");
        }
    }

    public class TextBox : IUIController
    {
        public void DrawElement()
        {
            Console.WriteLine("Drawing TextBox");
        }
    }
}
//Drawing TextBox