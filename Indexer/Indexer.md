### Qu'est-ce qu'un indexeur?

Un indexeur est une fonctionnalité de C# qui permet à une classe d'être indexée et accédée de manière similaire à un tableau. Tout comme une propriété, un indexeur est défini à l'aide du mot-clé `this` suivi de crochets `[]`.

Dans l'exemple ci-dessous, nous avons une classe `Team` qui utilise un indexeur pour permettre l'accès aux éléments comme s'il s'agissait d'un tableau.

```csharp
using System;

namespace CSharpSpeedrun
{
    class Team
    {
        private string[] tempArray = new string[4];

        // Indexeur
        public string this[int number]
        {
            get { return tempArray[number]; }
            set { tempArray[number] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Team teams = new Team();
            teams[0] = "Chicago Bulls";
            teams[1] = "New York Scavengers";
            teams[2] = "Mumbai Rockstars";
            teams[3] = "Los Angeles Lakers";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(teams[i]);
            }
        }
    }
}
```

Dans cet exemple :

- La classe `Team` contient un tableau `tempArray` de chaînes de caractères qui servira de stockage pour nos données.
- L'indexeur est défini dans la classe `Team` avec la signature `public string this[int number]`. Cela signifie que la classe `Team` peut être indexée avec un entier, et renvoie ou modifie la chaîne de caractères correspondante dans le tableau `tempArray`.
- Dans la méthode `Main`, nous créons une instance de la classe `Team` et affectons des valeurs à ses éléments en utilisant l'indexeur.
- Ensuite, nous parcourons la classe `Team` à l'aide d'une boucle `for` et imprimons chaque élément à la console.

L'utilisation d'indexeurs peut rendre le code plus lisible et plus expressif, en permettant l'accès à des éléments d'une classe d'une manière familière pour les développeurs habitués aux tableaux.