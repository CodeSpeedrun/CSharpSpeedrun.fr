# Le rôle de la classe Parallel

La classe `Parallel` dans l'espace de noms `System.Threading.Tasks` joue un rôle crucial dans le domaine de la programmation parallèle en C#. Elle fournit des méthodes pour itérer sur une collection de données de manière parallèle, principalement à travers deux méthodes statiques principales : `Parallel.For()` et `Parallel.ForEach()`.

L'avantage de l'utilisation de la classe `Parallel` réside dans sa capacité à gérer automatiquement la concurrence en utilisant le pool de threads disponible dans le système.

Elle utilise les délégués `System.Func<T>` et `System.Action<T>` pour spécifier la méthode cible qui sera appelée pour traiter les données.

- `Func<T>` représente une méthode qui peut avoir une valeur de retour donnée et un nombre variable d'arguments.
- `Action<T>` est similaire à `Func<T>`, car elle vous permet de pointer vers une méthode prenant un certain nombre de paramètres. Cependant, `Action<T>` spécifie une méthode qui ne peut retourner que `void`.

```csharp
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

class Programme
{
    static void Main()
    {
        List<double> nombres = new List<double> { 3.14, 2.718, 1.618, 4.669, 6.626 };

        // Utilisation de Parallel.ForEach pour traiter chaque élément de la liste en parallèle
        Parallel.ForEach(nombres, (nombre) =>
        {
            Console.WriteLine($"Traitement de {nombre} sur le thread {Task.CurrentId}");
            // Effectuer le traitement sur l'élément nombre
        });
    }
}
```

Dans cet exemple, nous utilisons `Parallel.ForEach` pour parcourir chaque élément de la liste `nombres` en parallèle. La lambda expression `(nombre) => { ... }` spécifie le traitement à effectuer sur chaque élément. La méthode `Console.WriteLine` est utilisée ici pour illustrer le thread sur lequel le traitement est effectué.

```csharp
using System;
using System.Threading.Tasks;

class Programme
{
    static void Main()
    {
        // Utilisation de Parallel.For pour effectuer une boucle en parallèle
        Parallel.For(0, 5, (i) =>
        {
            Console.WriteLine($"Traitement de l'itération {i} sur le thread {Task.CurrentId}");
            // Effectuer le traitement pour l'itération i
        });
    }
}
```

Dans cet exemple, `Parallel.For` est utilisé pour effectuer une boucle en parallèle. La première valeur spécifie le début de la plage, la deuxième valeur spécifie la fin de la plage (exclusivement). La lambda expression `(i) => { ... }` spécifie le traitement à effectuer pour chaque itération.

Ces méthodes offrent un moyen efficace d'exploiter les ressources de calcul disponibles sur un système pour améliorer les performances des opérations de traitement de données en parallèle en C#.