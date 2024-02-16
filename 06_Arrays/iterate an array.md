```csharp
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration et initialisation d'un tableau de chaînes de caractères
            string[] myFavFlowers = { "Rose", "Lily", "Tulip", "Orchid" };

            // Parcourir chaque élément du tableau avec une boucle foreach
            foreach (string element in myFavFlowers)
            {
                // Afficher chaque élément sur la console
                Console.WriteLine(element);
            }

            // Trier le tableau dans l'ordre alphabétique
            Array.Sort(myFavFlowers);
            
            // Inverser l'ordre des éléments du tableau
            Array.Reverse(myFavFlowers);
        }
    }
}
```

Ce code illustre la manière de parcourir un tableau (array) en utilisant une boucle foreach en C#. Voici une explication détaillée :

- **Déclaration et Initialisation du Tableau (`myFavFlowers`)** : Un tableau de chaînes de caractères est déclaré et initialisé avec quatre éléments : "Rose", "Lily", "Tulip", et "Orchid".

- **Boucle foreach** : La boucle foreach est utilisée pour itérer à travers chaque élément du tableau `myFavFlowers`. À chaque itération, la variable `element` prend la valeur de l'élément courant du tableau.

- **Affichage des Éléments** : À chaque itération de la boucle, le programme affiche l'élément courant sur la console à l'aide de `Console.WriteLine()`.

- **Tri du Tableau** : Après la boucle foreach, le tableau `myFavFlowers` est trié en ordre alphabétique à l'aide de `Array.Sort()`. Cela réarrange les éléments du tableau dans l'ordre alphabétique.

- **Inversion du Tableau** : Enfin, l'ordre des éléments du tableau est inversé à l'aide de `Array.Reverse()`. Cela signifie que le premier élément devient le dernier et vice versa, créant l'effet d'inversion.

**Exemple Additionnel** : Imaginons que nous voulions ajouter une nouvelle fleur à notre tableau `myFavFlowers` et ensuite afficher la première et la dernière fleur après le tri et l'inversion :

```csharp
myFavFlowers = new string[] { "Rose", "Lily", "Tulip", "Orchid", "Sunflower" };
Console.WriteLine($"Première fleur après tri et inversion : {myFavFlowers[0]}");
Console.WriteLine($"Dernière fleur après tri et inversion : {myFavFlowers[myFavFlowers.Length - 1]}");
```

Dans cet exemple, "Sunflower" est ajouté au tableau, puis la première et la dernière fleur sont affichées après le tri et l'inversion.