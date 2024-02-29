**Rôle de l'exécution immédiate**

Les méthodes suivantes entraîneront l'exécution immédiate d'une requête LINQ au moment exact où vous les appelez pour obtenir un instantané des données.

```csharp
static void ExécutionImmédiate()
{
    Console.WriteLine();
    Console.WriteLine("Exécution Immédiate");
    int[] nombres = { 15, 25, 35, 45, 5, 10, 20, 30 };
    // Obtient le premier élément dans l'ordre de la séquence
    int nombre = (from n in nombres select n).First();
    Console.WriteLine("Le premier élément est {0}", nombre);
    // Obtient le premier dans l'ordre de la requête
    nombre = (from n in nombres orderby n select n).First();
    Console.WriteLine("Le premier élément est {0}", nombre);
    // Obtient l'élément unique correspondant à la requête
    nombre = (from n in nombres where n > 30 select n).Single();
    Console.WriteLine("L'élément unique est {0}", nombre);
    try
    {
        // Lance une exception s'il y a plus d'un élément correspondant à la requête
        nombre = (from n in nombres where n > 10 select n).Single();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Une exception s'est produite : {0}", ex.Message);
    }
    // Obtient les données IMMÉDIATEMENT en tant qu'int[].
    int[] sousEnsembleTableau =
        (from n in nombres where n < 10 select n).ToArray<int>();
    // Obtient les données IMMÉDIATEMENT en tant que List<int>.
    List<int> sousEnsembleListe =
        (from n in nombres where n < 10 select n).ToList<int>();
}
```

L'utilité de l'exécution immédiate est évidente lorsque vous devez renvoyer les résultats d'une requête LINQ à un appelant externe.

### Explications

- **Premier élément dans l'ordre de la séquence** : Renvoie le premier élément de la séquence tel qu'il est stocké dans la mémoire.
- **Premier dans l'ordre de la requête** : Renvoie le premier élément après avoir appliqué un tri à la séquence selon la requête spécifiée.
- **Élément unique correspondant à la requête** : Renvoie l'unique élément de la séquence qui correspond à la condition spécifiée dans la requête.
- **Gestion des exceptions** : Si la requête spécifiée dans `Single()` renvoie zéro ou plusieurs éléments, cela générera une exception.
- **Conversion en tableau ou liste** : Les résultats de la requête peuvent être convertis immédiatement en tableau ou en liste pour une utilisation ultérieure.

L'exécution immédiate permet d'obtenir rapidement les résultats d'une requête LINQ et de les utiliser immédiatement dans le code suivant. Cela évite de retarder l'exécution de la requête jusqu'à ce que les résultats soient nécessaires, ce qui peut être crucial dans certaines situations, notamment lorsque des données en temps réel sont impliquées.