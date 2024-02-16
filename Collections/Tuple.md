### Qu'est-ce qu'un Tuple ?
Un tuple est une structure de données qui stocke des données de différents types. Il est principalement utilisé pour retourner plusieurs valeurs à partir d'une méthode. Surtout, un Tuple peut transmettre plusieurs valeurs à une méthode via un seul paramètre.

```csharp
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main()
        {
            static void Main(string[] args)
            {
                Console.WriteLine(GetEmployeeDetails());
            }

            static Tuple<int, string, string> GetEmployeeDetails()
            {
                return Tuple.Create(152, "John", "Dow");
            }
        }
    }
}
  
using System;

namespace CSharpSpeedrun
{
    class Program
    {

        static void Main()
        {
            var player = Tuple.Create(190, "Marylyn", "Banners");
            DisplayPlayers(player);
        }

        static void DisplayPlayers(Tuple<int, string, string> player)
        {
            Console.WriteLine(player.Item1);
            Console.WriteLine(player.Item2);
            Console.WriteLine(player.Item3);
        }
    }
}
/*
  
*/
```