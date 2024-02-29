# Renvoi des résultats LINQ via une exécution immédiate

## Introduction
Dans le développement logiciel avec C#, LINQ (Language Integrated Query) est une technologie puissante permettant de manipuler et interroger des collections de données. L'une des considérations importantes lors de l'utilisation de LINQ est de comprendre le moment où les résultats sont effectivement récupérés. Dans ce contexte, nous discuterons de l'exécution immédiate des résultats LINQ.

## Méthode `ObtenirSous-EnsembleChaîneCommeTableau`
Pour illustrer l'exécution immédiate des résultats LINQ, considérons une méthode fictive `ObtenirSous-EnsembleChaîneCommeTableau` qui prend un tableau de chaînes en entrée et renvoie un sous-ensemble de ces chaînes qui contiennent le mot "Rouge".

```csharp
static string[] ObtenirSousEnsembleChaineCommeTableau()
{
    string[] couleurs = {"Rouge Clair", "Vert", "Jaune", "Rouge Foncé", "Rouge", "Violet"};
    var couleursRouges = from couleur in couleurs where couleur.Contains("Rouge") select couleur;
    // Mapper les résultats dans un tableau.
    return couleursRouges.ToArray();
}
```

### Explication
- La méthode `ObtenirSousEnsembleChaineCommeTableau` prend un tableau de chaînes en entrée et renvoie un sous-ensemble de ces chaînes qui contiennent le mot "Rouge".
- Nous utilisons une requête LINQ pour filtrer les chaînes contenant le mot "Rouge" à l'aide de la clause `where`.
- La méthode `ToArray` est appelée sur le résultat de la requête LINQ pour convertir les résultats en un tableau.

## Utilisation de la méthode `ObtenirSous-EnsembleChaîneCommeTableau`
Un exemple d'utilisation de la méthode `ObtenirSous-EnsembleChaîneCommeTableau` :

```csharp
foreach (string couleur in ObtenirSousEnsembleChaineCommeTableau())
{
    // Traitement pour chaque élément de la sous-ensemble de chaînes contenant "Rouge".
}
```

### Explication
- La boucle `foreach` itère à travers chaque élément du sous-ensemble de chaînes contenant le mot "Rouge".
- L'utilisateur de cette méthode peut traiter les éléments du sous-ensemble sans avoir à connaître l'implémentation interne qui utilise LINQ.

## Conclusion
L'exécution immédiate des résultats LINQ est une technique importante à comprendre lors de l'utilisation de LINQ en C#. Elle garantit que les résultats d'une requête LINQ sont récupérés immédiatement, ce qui peut avoir un impact sur les performances et le comportement de votre programme. En comprenant cette notion, les développeurs peuvent écrire un code plus efficace et prévisible lorsqu'ils travaillent avec LINQ dans leurs projets C#.