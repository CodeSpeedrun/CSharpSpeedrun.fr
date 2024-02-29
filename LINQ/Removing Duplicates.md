# Suppression des Doublons

Lorsque vous appelez la méthode d'extension `Concat()`, il est possible de se retrouver avec des entrées redondantes dans le résultat obtenu, ce qui peut être utile dans certains cas. Cependant, dans d'autres cas, vous voudrez peut-être supprimer les entrées en double dans vos données. Pour ce faire, il vous suffit d'appeler la méthode d'extension `Distinct()`, comme illustré ci-dessous :

```csharp
static void AfficherConcatSansDoublons()
{
    List<string> marquesVoitures1 =
    new List<String> { "Toyota", "Honda", "BMW" };
    List<string> marquesVoitures2 =
    new List<String> { "BMW", "Ford", "Honda" };
    var voituresConcat =
    (from v in marquesVoitures1 select v)
    .Concat(from v2 in marquesVoitures2 select v2);
    // Affiche :
    // Toyota Honda BMW Ford.
    foreach (string v in voituresConcat.Distinct())
}
```

## Explication

Dans cet exemple, nous avons deux listes de chaînes de caractères représentant des marques de voitures : `marquesVoitures1` et `marquesVoitures2`. Nous voulons concaténer ces deux listes ensemble. Cependant, si nous faisons simplement cela en utilisant la méthode `Concat()`, nous pourrions obtenir des doublons, car certaines marques sont présentes dans les deux listes.

Pour éviter cela, nous utilisons la méthode `Distinct()` après la concaténation. Cette méthode supprime les doublons de la liste résultante, assurant ainsi que chaque élément est unique.

## Exemple supplémentaire

```csharp
static void Main(string[] args)
{
    List<int> nombres1 = new List<int> { 1, 2, 3, 4, 5 };
    List<int> nombres2 = new List<int> { 4, 5, 6, 7, 8 };

    var nombresConcatenes = nombres1.Concat(nombres2);

    // Affichera : 1 2 3 4 5 4 5 6 7 8
    foreach (var nombre in nombresConcatenes)
    {
        Console.Write(nombre + " ");
    }

    Console.WriteLine();

    var nombresUniques = nombresConcatenes.Distinct();

    // Affichera : 1 2 3 4 5 6 7 8
    foreach (var nombre in nombresUniques)
    {
        Console.Write(nombre + " ");
    }
}
```

Dans cet exemple supplémentaire, nous avons deux listes d'entiers : `nombres1` et `nombres2`. Après avoir concaténé ces deux listes, nous affichons d'abord tous les nombres, ce qui inclut les doublons. Ensuite, en utilisant la méthode `Distinct()`, nous affichons uniquement les nombres uniques en supprimant les doublons.

