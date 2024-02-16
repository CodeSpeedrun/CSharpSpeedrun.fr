### Gestion des exceptions
Les exceptions peuvent être difficiles à comprendre. En C#, nous avons la possibilité de capturer une exception et d'afficher des messages compréhensibles à l'utilisateur. 

L'instruction try teste le code pour détecter les erreurs et l'instruction catch contient le code à exécuter si une erreur se produit.

Nous pouvons utiliser les propriétés de la classe Exception pour produire des informations utiles lorsque le compilateur génère une erreur.

```csharp
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] mesNombresChanceux = { 14, 17, 54, 8 };
                Console.WriteLine(mesNombresChanceux[7]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Une exception s'est produite :");
                Console.WriteLine($"Message : {e.Message}");
                Console.WriteLine($"Source : {e.Source}");
                Console.WriteLine($"Méthode : {e.TargetSite}");
            }
        }
    }
}
/*
Index était en dehors des limites du tableau.
Main
Void Main()
*/
```
 