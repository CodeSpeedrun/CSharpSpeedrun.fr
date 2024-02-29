# Sorting Expressions

L'expression de tri par défaut est ascendante ; ainsi, le tri par une chaîne de caractères serait alphabétique, le tri par des données numériques serait du plus bas au plus haut, et ainsi de suite.

```csharp
static void TrierNomsProduits(InfoProduit[] produits)
{
    // Obtenir les noms des produits, triés par ordre alphabétique.
    var sous-ensemble = from prod in produits orderby prod.Nom select prod;
}
```

## Except() Extension Method

La méthode d'extension `Except()` retournera un ensemble de résultats LINQ qui contient la différence entre deux conteneurs, qui, dans ce cas, est la valeur Yugo.

```csharp
var differenceVoiture =
    (from voiture in mesVoitures select voiture)
    .Except(from voiture2 in tesVoitures select voiture2);

Console.WriteLine("Voici ce que vous n'avez pas, mais que j'ai :");
foreach (string item in differenceVoiture)
{
    Console.WriteLine(item);
}
```

## Intersect() Method

La méthode `Intersect()` retournera un ensemble de résultats qui contient les éléments de données communs dans un ensemble de conteneurs. Par exemple, la méthode suivante renvoie la séquence Aztec et BMW :

```csharp
static void AfficherIntersection()
{
    List<string> mesVoitures = new List<string> { "BYD", "Aztec", "BMW" };
    List<string> tesVoitures = new List<string> { "BMW", "Toyota", "Aztec" };

    // Obtenir les membres communs.
    var intersectionVoiture =
        (from voiture in mesVoitures select voiture)
        .Intersect(from voiture2 in tesVoitures select voiture2);
}
```

## Union() Method

La méthode `Union()` retournera un ensemble de résultats qui contient tous les éléments distincts de deux conteneurs.

```csharp
var unionVoiture =
    (from voiture in mesVoitures select voiture)
    .Union(from voiture2 in tesVoitures select voiture2);
```

## Concat() Method

La méthode `Concat()` retournera un ensemble de résultats qui contient la concaténation de deux conteneurs.

```csharp
var concatVoiture =
    (from voiture in mesVoitures select voiture)
    .Concat(from voiture2 in tesVoitures select voiture2);
```

Chaque méthode de cet exemple utilise des opérations LINQ pour manipuler des ensembles de données dans le langage C#. Ces opérations sont puissantes et permettent des manipulations flexibles et expressives des données. La connaissance de ces méthodes est essentielle pour travailler efficacement avec LINQ dans le cadre du développement logiciel en C#.