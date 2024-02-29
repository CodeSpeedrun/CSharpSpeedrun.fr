# Opérations d'agrégation LINQ

Les opérations d'agrégation LINQ permettent d'effectuer des calculs sur des ensembles de données. L'une de ces opérations est la méthode Count(), qui permet de compter le nombre d'éléments dans une séquence. D'autres opérations incluent l'obtention d'une moyenne, d'un maximum, d'un minimum ou d'une somme de valeurs à l'aide des méthodes Max(), Min(), Average() ou Sum() de la classe Enumerable.

```csharp
double[] ventesMensuelles = { 1200.5, 1500.75, 1800.25, 1300.0, 1400.50 };
// Exemples d'agrégation variés.
Console.WriteLine("Ventes maximales : {0}",
(from vente in ventesMensuelles select vente).Max());
```

Dans cet exemple, une collection de ventes mensuelles est déclarée sous forme de tableau de doubles. Ensuite, la méthode Max() est utilisée pour trouver le montant de vente maximal parmi ces ventes.

## Opérations d'agrégation courantes

Les opérations d'agrégation les plus couramment utilisées en LINQ incluent :

### Count()
La méthode Count() permet de compter le nombre d'éléments dans une séquence.

Exemple :

```csharp
var count = collection.Count();
```

### Max()
La méthode Max() renvoie le plus grand élément d'une séquence.

Exemple :

```csharp
var max = collection.Max();
```

### Min()
La méthode Min() renvoie le plus petit élément d'une séquence.

Exemple :

```csharp
var min = collection.Min();
```

### Average()
La méthode Average() calcule la moyenne des éléments d'une séquence.

Exemple :

```csharp
var average = collection.Average();
```

### Sum()
La méthode Sum() calcule la somme des éléments d'une séquence.

Exemple :

```csharp
var sum = collection.Sum();
```

## Utilisation des expressions LINQ

Les expressions LINQ offrent une syntaxe expressive pour interroger et manipuler des collections de données en C#. Elles peuvent être utilisées avec différents types de collections, y compris les tableaux, les listes, les ensembles, etc.

## Conclusion

Les opérations d'agrégation en LINQ sont essentielles pour effectuer des calculs statistiques et analyser des ensembles de données dans les applications C#. En utilisant ces opérations avec des expressions LINQ, les développeurs peuvent écrire un code plus clair et plus concis pour traiter des données de manière efficace.