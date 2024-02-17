# Classes C# vs Records

## Introduction

En C#, les classes et les Records sont tous deux utilisés pour définir des structures de données, mais ils présentent des caractéristiques et des cas d'utilisation différents. Comprendre les différences entre eux est crucial pour écrire un code efficace et maintenable. Dans ce guide, nous explorerons les distinctions entre les classes et les Records en C#, avec des exemples pour illustrer leur utilisation.

## Classes

### Définition

Une classe en C# est un modèle pour créer des objets. Elle encapsule des données pour l'objet et un comportement via des méthodes. Voici un exemple simple d'une classe en C# :

```csharp
public class Voiture
{
    public string Marque { get; set; }
    public string Modèle { get; set; }
    public int Année { get; set; }
    
    public void DémarrerMoteur()
    {
        Console.WriteLine("Moteur démarré !");
    }
}
```

Dans le code ci-dessus :
- La classe `Voiture` a trois propriétés : `Marque`, `Modèle` et `Année`.
- Elle a également une méthode `DémarrerMoteur()` qui affiche un message indiquant que le moteur a démarré.

### Utilisation

Vous pouvez créer des instances de la classe `Voiture` et accéder à ses propriétés et méthodes comme ceci :

```csharp
Voiture maVoiture = new Voiture();
maVoiture.Marque = "Toyota";
maVoiture.Modèle = "Camry";
maVoiture.Année = 2022;

Console.WriteLine($"Ma voiture est une {maVoiture.Année} {maVoiture.Marque} {maVoiture.Modèle}");
maVoiture.DémarrerMoteur();
```

## Records

### Définition

Les Records sont une nouvelle fonctionnalité introduite en C# 9.0. Ils sont similaires aux classes mais sont principalement destinés aux types de données immuables. Les Records offrent une syntaxe concise pour définir des types immuables. Voici un exemple :

```csharp
public record Personne
{
    public string Prénom { get; init; }
    public string Nom { get; init; }
    public int Âge { get; init; }
}
```

Dans le code ci-dessus :
- L'enregistrement `Personne` définit des propriétés pour `Prénom`, `Nom` et `Âge`.
- L'accessoir `init` garantit que ces propriétés ne peuvent être définies que lors de l'initialisation et ne peuvent pas être modifiées par la suite.

### Utilisation

Les Records sont souvent utilisés pour représenter des objets de transfert de données (DTO) ou des structures de données immuables. Vous pouvez créer des instances d'un enregistrement comme ceci :

```csharp
Personne personne = new Personne
{
    Prénom = "Jean",
    Nom = "Dupont",
    Âge = 30
};

Console.WriteLine($"Bonjour, {personne.Prénom} {personne.Nom} ! Vous avez {personne.Âge} ans.");
```

## Conclusion

En résumé, les classes et les Records sont tous deux des outils essentiels pour définir des structures de données en C#. Les classes sont plus flexibles et adaptées aux objets à état mutable et comportement, tandis que les Records sont optimisés pour les données immuables et offrent une syntaxe plus concise. Comprendre quand utiliser chacun est crucial pour écrire un code efficace et maintenable.