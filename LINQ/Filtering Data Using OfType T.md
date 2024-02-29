### Filtrer les données en utilisant OfType<T>()

La méthode `OfType<T>()` est une méthode de filtrage utile en C#. Elle permet d'extraire des éléments d'une collection qui sont du type spécifié. Cette méthode est particulièrement utile lorsque vous avez une collection contenant différents types d'objets et que vous souhaitez uniquement extraire ceux d'un type particulier.

```csharp
static void FiltrerParType()
{
    // Créer une liste d'objets de différents types.
    ArrayList maCollection = new ArrayList();
    maCollection.AddRange(new object[] { 710, 100, 8, false, new Voiture(), "données de chaîne" });

    // Utiliser OfType<int>() pour extraire les entiers de la liste.
    var entiers = maCollection.OfType<int>();

    // Afficher les entiers.
    foreach (int entier in entiers)
    {
        Console.WriteLine(entier);
    }
}
```

Dans cet exemple, une collection `maCollection` est créée et remplie avec différents types d'objets, y compris des entiers, un booléen, une instance de la classe `Voiture` et une chaîne de caractères. Ensuite, la méthode `OfType<int>()` est utilisée pour filtrer et extraire uniquement les entiers de la collection. Enfin, les entiers extraits sont affichés à l'aide d'une boucle foreach.

#### Explication du code

- La méthode `AddRange()` est utilisée pour ajouter plusieurs éléments à la collection `maCollection`.
- La méthode `OfType<int>()` est utilisée pour filtrer et extraire uniquement les entiers de la collection. Cette méthode renvoie un `IEnumerable<int>`, contenant uniquement les éléments de type `int`.
- La boucle foreach est utilisée pour parcourir chaque entier extrait et l'afficher à la console.

#### Utilisation de OfType<T>()

La méthode `OfType<T>()` peut être utilisée dans de nombreuses situations différentes. Voici quelques exemples supplémentaires :

##### Filtrer les objets d'une liste de base de données

Supposons que vous ayez une liste d'objets provenant d'une base de données et que certains de ces objets soient de types différents. Vous pouvez utiliser `OfType<T>()` pour extraire uniquement les objets d'un type spécifique avant de les manipuler ou de les afficher.

```csharp
// Supposons que 'listeObjets' contienne des objets de différents types provenant d'une base de données.
var clients = listeObjets.OfType<Client>();
```

##### Filtrer les contrôles dans une interface utilisateur

Dans une application GUI, vous pourriez avoir une collection de contrôles qui inclut des boutons, des zones de texte et d'autres types de contrôles. Vous pouvez utiliser `OfType<T>()` pour extraire uniquement les contrôles d'un type spécifique pour effectuer des opérations spécifiques.

```csharp
// Supposons que 'controls' contienne des contrôles de différentes types dans une fenêtre.
var boutons = controls.OfType<Bouton>();
```

#### Conclusion

La méthode `OfType<T>()` est un outil puissant pour filtrer et extraire des éléments d'une collection en fonction de leur type. Elle est largement utilisée dans le développement C# pour simplifier le traitement des données et améliorer la lisibilité du code. En comprenant son utilisation et ses applications, les développeurs peuvent écrire un code plus efficace et plus maintenable.