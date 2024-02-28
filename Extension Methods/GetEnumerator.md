# L'utilisation de GetEnumerator dans LINQ

Les méthodes d'extension jouent un rôle essentiel dans les API LINQ.

## Méthode d'Extension pour le Support de GetEnumerator

Dans le contexte de LINQ, la méthode GetEnumerator est utilisée pour itérer sur une collection. Pour les types personnalisés, il est souvent nécessaire de fournir une implémentation de cette méthode pour permettre l'itération. Cependant, les méthodes d'extension offrent une manière élégante d'étendre les fonctionnalités des types existants sans modifier leur code source.

Considérons une classe Garage qui contient un tableau de voitures, représenté par la propriété CarsInGarage.

```csharp
namespace PourChaqueAvecMethodesExtension
{
    class Garage
    {
        public Voiture[] VoituresDansGarage { get; set; }
    }
}
```

Supposons que nous voulions utiliser la boucle foreach pour itérer sur les voitures dans le garage. Normalement, pour utiliser foreach, la classe Garage devrait implémenter l'interface IEnumerable ou définir une méthode GetEnumerator.

Cependant, avec les méthodes d'extension, nous pouvons fournir cette fonctionnalité sans modifier la classe Garage elle-même. Voici comment cela peut être fait en créant une méthode d'extension sur la classe Garage qui fournit une implémentation de GetEnumerator :

```csharp
using System.Collections;

namespace PourChaqueAvecMethodesExtension
{
    static class ExtensionsGarage
    {
        public static IEnumerator GetEnumerator(this Garage garage)
        {
            return garage.VoituresDansGarage.GetEnumerator();
        }
    }
}
```

Dans cet exemple, la méthode d'extension GetEnumerator est définie pour la classe Garage. Elle retourne l'objet IEnumerator associé au tableau de voitures dans le garage.

Maintenant, grâce à cette méthode d'extension, nous pouvons utiliser la boucle foreach pour itérer sur les voitures dans le garage, sans avoir à modifier la classe Garage elle-même :

```csharp
foreach (Voiture voiture in garage)
{
    // Faire quelque chose avec la voiture
}
```

Cela permet une séparation claire des responsabilités et une extension facile des fonctionnalités des types existants, ce qui est une pratique courante dans le développement moderne en C#.