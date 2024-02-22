# Tableaux de Types d'Interface en C#

En C#, les interfaces fournissent un moyen de définir un contrat auquel les classes peuvent adhérer. Les tableaux de types d'interface permettent une flexibilité dans le travail avec différents types d'objets qui implémentent la même interface. Ce concept est essentiel pour le polymorphisme et l'abstraction en programmation orientée objet.

## Implémentation d'Interface

En C#, les interfaces définissent un ensemble de signatures de méthode et de propriété sans spécifier l'implémentation. Les classes qui implémentent une interface doivent fournir des implémentations concrètes pour tous les membres de cette interface.

```csharp
// ISharp.cs
namespace CustomInterfaces
{
    interface ISharp
    {
        byte Points { get; }
    }
}
```

Dans l'extrait de code ci-dessus, nous définissons une interface appelée `ISharp`, qui a une propriété `Points` retournant une valeur de type byte.

## Implémentation des Interfaces

Implémentons l'interface `ISharp` dans différentes classes représentant divers objets tranchants tels que des couteaux, des fourchettes et des fourches.

```csharp
// Knife.cs
namespace CustomInterfaces
{
    class Knife : ISharp
    {
        public byte Points => 2;
    }
}

// Fork.cs
namespace CustomInterfaces
{
    class Fork : ISharp
    {
        public byte Points => 4;
    }
}

// PitchFork.cs
namespace CustomInterfaces
{
    class PitchFork : ISharp
    {
        public byte Points => 3;
    }
}
```

Ici, les classes `Knife`, `Fork`, et `PitchFork` implémentent l'interface `ISharp`, fournissant l'implémentation pour la propriété `Points`.

## Tableau de Types d'Interface

Les tableaux de types d'interface permettent des collections d'objets qui implémentent la même interface, offrant ainsi une flexibilité dans le travail avec différents types d'objets de manière interchangeable.

```csharp
using System;

namespace CustomInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tableau d'objets implémentant l'interface ISharp
            ISharp[] sharpObjects = { new Knife(), new Fork(), new PitchFork() };

            foreach (ISharp sharpObject in sharpObjects)
            {
                Console.WriteLine("L'objet a {0} points.", sharpObject.Points);
            }

            Console.ReadLine();
        }
    }
}
```

Dans la méthode `Main` de la classe `Program`, nous créons un tableau `sharpObjects` de type `ISharp[]`, qui peut contenir des objets de classes implémentant l'interface `ISharp`. Nous parcourons ensuite le tableau et affichons le nombre de points de chaque objet.

## Polymorphisme et Abstraction

Les tableaux de types d'interface illustrent le polymorphisme et l'abstraction, permettant d'écrire du code en termes d'interfaces plutôt que d'implémentations concrètes. Cela améliore la flexibilité et l'extensibilité dans la base de code, car de nouvelles classes implémentant l'interface peuvent s'intégrer facilement avec le code existant.

## Conclusion

Comprendre les tableaux de types d'interface en C# est crucial pour écrire un code flexible et maintenable. En tirant parti des interfaces, du polymorphisme et de l'abstraction, les développeurs peuvent concevoir des systèmes robustes capables de prendre en compte les changements et les ajouts avec un impact minimal sur le code existant.