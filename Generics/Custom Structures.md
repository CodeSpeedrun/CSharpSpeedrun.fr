# Création de structures génériques personnalisées

Dans ce document, nous explorerons la création de structures génériques personnalisées en C#. Les structures génériques offrent une flexibilité accrue en permettant aux types de données d'être paramétrés lors de leur utilisation, ce qui les rend plus polyvalentes et réutilisables dans divers contextes.

## Définition d'une structure Point générique

Nous commençons par définir une structure `Point<T>` qui représente un point dans un espace en deux dimensions. Cette structure utilise un type générique `T` pour les coordonnées `X` et `Y`, permettant ainsi d'utiliser différents types de données tels que `int`, `float`, `double`, etc.

```csharp
namespace PointGenerique
{
    public struct Point<T>
    {
        private T _xPos;
        private T _yPos;

        public Point(T xVal, T yVal)
        {
            _xPos = xVal;
            _yPos = yVal;
        }

        public T X
        {
            get => _xPos;
            set => _xPos = value;
        }

        public T Y
        {
            get => _yPos;
            set => _yPos = value;
        }

        public override string ToString() => $"[{_xPos}, {_yPos}]";
    }
}
```

## Réinitialisation d'un point avec la valeur par défaut

Nous pouvons réinitialiser les coordonnées d'un point en utilisant la valeur par défaut du type paramétré. Dans les versions précédentes de C#, cela était accompli en utilisant `default(T)`. Cependant, depuis C# 7.1, nous pouvons utiliser `default` directement sans spécifier le type.

```csharp
public void ReinitialiserPoint<T>()
{
    _xPos = default;
    _yPos = default;
}
```

## Correspondance de motifs avec des types génériques

La correspondance de motifs permet de vérifier le type d'une variable et d'exécuter un bloc de code correspondant. Dans C# 7.1, il est possible d'utiliser la correspondance de motifs avec des types génériques.

```csharp
static void CorrespondanceMotifs<T>(Point<T> p)
{
    switch (p)
    {
        case Point<string> pString:
            Console.WriteLine("Le point est basé sur des chaînes de caractères.");
            return;
        case Point<int> pInt:
            Console.WriteLine("Le point est basé sur des entiers.");
            return;
    }
}
```

## Exemple d'utilisation

Maintenant, voyons un exemple d'utilisation de la structure `Point<T>` avec différents types de données :

```csharp
class Programme
{
    static void Main()
    {
        // Création d'un point avec des entiers.
        Point<int> pointEntier = new Point<int>(10, 20);
        Console.WriteLine($"Point entier : {pointEntier}");

        // Réinitialisation du point entier.
        pointEntier.ReinitialiserPoint();
        Console.WriteLine($"Point entier réinitialisé : {pointEntier}");

        // Création d'un point avec des chaînes de caractères.
        Point<string> pointChaine = new Point<string>("A", "B");
        Console.WriteLine($"Point chaîne : {pointChaine}");

        // Utilisation de la correspondance de motifs.
        CorrespondanceMotifs(pointChaine);
    }
}
```

Ce code illustre la création de points avec différents types de données et montre comment réinitialiser un point en utilisant la valeur par défaut du type paramétré. De plus, il démontre l'utilisation de la correspondance de motifs avec des types génériques.
 