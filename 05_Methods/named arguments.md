### Comment déclarer des arguments nommés?

En C#, un langage fortement typé, lors de la création de méthodes avec plusieurs paramètres, l'ordre des arguments et des paramètres doit être respecté. Cependant, en passant des arguments avec la syntaxe clé : valeur, nous pouvons contourner cette règle. Désormais, l'ordre des arguments est sans importance.

```csharp
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main()
        {
            int nombreDeCoeurs = 5; 
            string armeActuelle = "Cuillère géante";

            ObtenirStatutDuHéros(arme: armeActuelle, coeurs: nombreDeCoeurs);
        }

        static void ObtenirStatutDuHéros(int coeurs, string arme)
        {
            if (coeurs < 10)
            {
                Console.WriteLine("Achetez des trousses de santé !");
            }
            else
            {
                Console.WriteLine("Prêt pour l'aventure !");
            }
            Console.WriteLine("Arme actuelle : " + arme);
        }
    }
}
//Achetez des trousses de santé !
//Arme actuelle : Cuillère géante
```

Dans cet exemple, nous démontrons comment utiliser des arguments nommés en C#. Au lieu de passer les arguments dans l'ordre défini par la méthode, nous pouvons spécifier les noms des paramètres correspondants, suivis de deux-points, puis de la valeur de l'argument. Cela permet une meilleure lisibilité du code et rend les appels de méthode plus explicites.

#### Points à retenir:
- Les arguments nommés offrent une flexibilité dans l'ordre des paramètres lors de l'appel de méthodes.
- Ils rendent le code plus lisible et explicite.
- Utile lorsqu'une méthode a de nombreux paramètres, certains étant facultatifs.

#### Exemple supplémentaire:

```csharp
using System;

namespace NamedArgumentsExample
{
    class Program
    {
        static void Main()
        {
            DisplayInformation(name: "Alice", age: 30, city: "Paris");
        }

        static void DisplayInformation(string name, int age, string city)
        {
            Console.WriteLine($"Nom : {name}");
            Console.WriteLine($"Âge : {age}");
            Console.WriteLine($"Ville : {city}");
        }
    }
}
```

Dans cet exemple, nous utilisons des arguments nommés pour appeler la méthode `DisplayInformation`. Cela nous permet de spécifier les valeurs des paramètres dans n'importe quel ordre, en utilisant les noms des paramètres correspondants.