### How to declare property in C#?
It is common practice to name the property after the private field but written in CamelCase. The code snippet below illustrates how `get { return username; }` returns and `set { username = value; }` assigns data to the private field. Notice the value keyword represents the data to be assigned.

```csharp
using System;
namespace CSharpSpeedrun
{
    class Player
    {
        private string username; // field
        public string UserName   // property
        {
            get { return username; }
            set { username = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player starPlayer = new Player();
            starPlayer.UserName = "Tom";
            Console.WriteLine(starPlayer.UserName);
        }
    }
}
//Tom
```