# LINQ et Méthodes d'Extension

Les expressions de requête LINQ peuvent être utilisées pour itérer sur des conteneurs de données qui implémentent l'interface générique `IEnumerable<T>`.

Cependant, le type de classe `System.Array` (utilisé pour représenter le tableau de chaînes et le tableau d'entiers) n'implémente pas ce contrat.

```csharp
// Le type System.Array ne semble pas implémenter
// l'infrastructure correcte pour les expressions de requête !
public abstract class Array : ICloneable, IList,
IStructuralComparable, IStructuralEquatable
{
```

Bien que `System.Array` n'implémente pas directement l'interface `IEnumerable<T>`, il acquiert indirectement les fonctionnalités requises de ce type (ainsi que de nombreux autres membres centrés sur LINQ) via le type de classe statique `System.Linq.Enumerable`.

Cette classe utilitaire définit un bon nombre de méthodes d'extension génériques (telles que `Aggregate<T>()`, `First<T>()`, `Max<T>()`, etc.), que `System.Array` (et d'autres types) acquiert en arrière-plan. Ainsi, si vous appliquez l'opérateur point sur la variable locale `jeuxVideosActuels`, vous trouverez un bon nombre de membres qui ne se trouvent pas dans la définition formelle de `System.Array`.

## Exemple d'Utilisation

Considérons un exemple où nous avons un tableau d'entiers et nous voulons trouver la somme de tous les éléments supérieurs à 5.

```csharp
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nombres = { 1, 7, 4, 9, 2, 6, 3, 8, 5 };

        var somme = nombres.Where(n => n > 5).Sum();

        Console.WriteLine("La somme des nombres supérieurs à 5 est : " + somme);
    }
}
```

Dans cet exemple, nous utilisons la méthode d'extension `Where()` pour filtrer les nombres supérieurs à 5, puis nous utilisons la méthode `Sum()` pour calculer la somme de ces nombres filtrés.

## Méthodes d'Extension Communes

Outre les méthodes d'exemple mentionnées ci-dessus, voici quelques-unes des méthodes d'extension couramment utilisées fournies par `System.Linq.Enumerable` :

- `Aggregate<T>()` : Effectue une opération d'agrégation sur une séquence.
- `First<T>()` : Retourne le premier élément d'une séquence.
- `Max<T>()` : Retourne le plus grand élément d'une séquence.
- `Where<T>()` : Filtre une séquence en fonction d'un prédicat.
- `Select<T>()` : Transforme chaque élément d'une séquence en un nouveau formulaire.

Ces méthodes offrent une grande flexibilité lors du traitement de données dans les tableaux, listes et autres types de collections.

## Conclusion

Bien que les tableaux en C# ne supportent pas directement les expressions de requête LINQ via l'interface `IEnumerable<T>`, les méthodes d'extension fournies par `System.Linq.Enumerable` permettent d'effectuer facilement des opérations de traitement de données sur les tableaux et autres collections. Cette approche facilite le développement d'un code plus lisible et expressif, tout en offrant une puissante suite d'outils pour manipuler les données.