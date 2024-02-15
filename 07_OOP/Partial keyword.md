### What is the partial keyword?

Using the partial keyword, we can break up the implementaton of classes, methods or even interfaces into several .cs files.

```csharp 
using System;

namespace CSharpSpeedrun
{
    public partial class Enemy
    {
        public void DisplayHP() {
            Console.WriteLine("100 hp");
        }
        partial void GenerateEmployeeId();
    }
    public partial class Enemy
    {
        public void DisplayWeapons()
        {
            Console.WriteLine("Giant spoon");
        }
         partial void GenerateEmployeeId(){}
    }
    class Program
    {
        static void Main(string[] args)
        {
            var enemy = new Enemy(); 
            enemy.DisplayHP();
            enemy.DisplayWeapons();
        }
    }
}
/*
  
*/
```