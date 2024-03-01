# Les requêtes LINQ parallèles (PLINQ)

Les requêtes LINQ parallèles (PLINQ) permettent de paralléliser efficacement le traitement de données dans C#. Elles sont particulièrement utiles pour manipuler de grandes quantités de données et tirer parti de plusieurs cœurs de processeur afin d'optimiser les performances.

## Membres de la classe ParallelEnumerable

| Méthode | Description |
|---------|-------------|
| AsParallel() | Indique que le reste de la requête doit être exécuté de manière parallèle, si possible. |
| WithCancellation() | Permet à PLINQ de surveiller périodiquement l'état du jeton d'annulation fourni et d'annuler l'exécution si nécessaire. |
| WithDegreeOfParallelism() | Spécifie le nombre maximal de processeurs que PLINQ doit utiliser pour paralléliser la requête. |
| ForAll() | Permet de traiter les résultats en parallèle sans les fusionner préalablement avec le thread consommateur, contrairement à ce qui se passe lors de l'énumération d'un résultat LINQ avec la boucle `foreach`. |

## Exemple d'utilisation de PLINQ

```csharp
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

Console.WriteLine("Appuyez sur une touche pour commencer le traitement");
Console.ReadKey();
Console.WriteLine("Traitement en cours...");

Task.Factory.StartNew(TraiterDonneesEntieres);
Console.ReadLine();

void TraiterDonneesEntieres()
{
    // Génération d'un grand tableau d'entiers.
    int[] donnees = Enumerable.Range(1, 20_000_000).ToArray();
    
    // Recherche des nombres qui sont des multiples de 4, renvoyés
    // dans l'ordre décroissant.
    int[] multiplesDeQuatre = (
        from num in donnees.AsParallel()
        where num % 4 == 0
        orderby num descending
        select num
    ).ToArray();

    Console.WriteLine($"Trouvé {multiplesDeQuatre.Count()} nombres correspondant à la requête !");
}
```

Dans cet exemple, nous utilisons PLINQ pour rechercher les multiples de quatre dans un tableau d'entiers généré. En utilisant `AsParallel()`, la requête LINQ est exécutée de manière parallèle, ce qui permet d'exploiter efficacement les capacités de traitement multi-cœurs du processeur. 

## Explication du code

- La méthode `TraiterDonneesEntieres` est utilisée pour effectuer le traitement des données.
- La méthode `Enumerable.Range` est utilisée pour générer un tableau d'entiers allant de 1 à 20 000 000.
- La requête LINQ utilise `AsParallel()` pour paralléliser le traitement.
- Seuls les entiers divisibles par 4 sont sélectionnés (`where num % 4 == 0`).
- Les résultats sont triés par ordre décroissant (`orderby num descending`).
- Les résultats sont ensuite convertis en tableau (`ToArray()`).
- Enfin, le nombre de résultats est affiché.

Ce modèle de programmation parallèle permet d'améliorer significativement les performances lors du traitement de grandes quantités de données, ce qui est crucial dans de nombreux scénarios d'application.