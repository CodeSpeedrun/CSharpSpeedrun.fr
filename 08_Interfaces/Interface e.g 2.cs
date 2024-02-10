using System;

namespace CSharpSpeedrun {
    public class Program {
        static void Main() {
            DrawUiElement(new TextBox());
        }

        static void DrawUiElement(IUIController uIController) {
            uIController.DrawElement();
        }
    }

    interface IUIController {
        void DrawElement();
    }

    public class Button : IUIController {
        public void DrawElement() {
            Console.WriteLine("Drawing Button");
        }
    }

    public class TextBox : IUIController {
        public void DrawElement() {
            Console.WriteLine("Drawing TextBox");
        }
    }
}
//Drawing TextBox