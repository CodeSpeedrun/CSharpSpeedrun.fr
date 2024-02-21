# Méthodes anonymes

Les méthodes anonymes offrent une manière concise et flexible de définir des gestionnaires d'événements en C#. Plutôt que de définir des méthodes spécifiques pour chaque événement, les méthodes anonymes permettent de déclarer le comportement directement au moment de l'inscription à un événement.

## Exemple de méthode anonyme

Considérons une classe `Véhicule` qui émet des événements lorsqu'il est sur le point de tomber en panne ou lorsqu'il explose. Plutôt que de définir des méthodes de gestion d'événements spécifiques, nous pouvons utiliser des méthodes anonymes pour gérer ces événements de manière dynamique.

```csharp
using System;

class Voiture
{
    public event Action SurLePointDeSExploser;
    public event Action<string> Explose;

    public void Accélérer(int vitesse)
    {
        // Logique d'accélération
        if (vitesse > 80)
        {
            SurLePointDeSExploser?.Invoke();
        }
    }
}

class Programme
{
    static void Main(string[] args)
    {
        Voiture voiture = new Voiture();

        // Enregistrement de gestionnaires d'événements anonymes
        voiture.SurLePointDeSExploser += () =>
        {
            Console.WriteLine("Attention ! La voiture est sur le point d'exploser !");
        };

        voiture.Explose += (message) =>
        {
            Console.WriteLine($"La voiture a explosé ! Message : {message}");
        };

        // Simulation de l'accélération
        for (int i = 0; i < 6; i++)
        {
            voiture.Accélérer(20);
        }
    }
}
```

Dans cet exemple, nous avons une classe `Voiture` avec deux événements : `SurLePointDeSExploser` et `Explose`. Plutôt que de définir des méthodes distinctes pour gérer ces événements, nous utilisons des méthodes anonymes pour définir le comportement à exécuter lorsque ces événements se produisent.

## Avantages des méthodes anonymes

- **Flexibilité**: Les méthodes anonymes permettent de définir des gestionnaires d'événements directement à l'endroit où ils sont utilisés, ce qui rend le code plus concis.
- **Pas besoin de méthodes statiques**: Contrairement aux méthodes traditionnelles de gestion d'événements, les méthodes anonymes ne nécessitent pas la définition de méthodes statiques distinctes.

## Syntaxe des méthodes anonymes

La syntaxe générale pour définir une méthode anonyme lors de l'inscription à un événement est la suivante :

```csharp
objet.Evénement += delegate (paramètresOptionnels)
{
    // Corps de la méthode anonyme
};
```

Dans notre exemple, nous avons utilisé la syntaxe lambda pour créer des méthodes anonymes, ce qui rend le code plus lisible et plus concis.

Les méthodes anonymes offrent une manière élégante de gérer les événements en C#, en permettant une flexibilité et une concision accrues dans le code.