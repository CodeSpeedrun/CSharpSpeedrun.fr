# Réaménagement de l'exemple CarEvents en utilisant des expressions lambda

Les expressions lambda fournissent un moyen propre et concis de définir une méthode anonyme, ce qui simplifie indirectement le travail avec les délégués. Dans cet exemple, nous allons réaménager le projet CarEventArgs créé précédemment dans ce chapitre en utilisant la syntaxe des expressions lambda. Voici une version simplifiée de la classe Program de ce projet, qui utilise la syntaxe des expressions lambda pour se connecter à chaque événement envoyé par l'objet Car :

```csharp
using System;
using CarEventsWithLambdas;

Console.WriteLine("***** Plus de plaisir avec les Lambdas *****\n");

// Crée une voiture comme d'habitude.
Voiture voiture1 = new Voiture("SlugBug", 100, 10);

// Se connecte aux événements avec des lambdas !
voiture1.AlarmeSurPointDeSurchauffe += (expediteur, evenement) =>
{
    Console.WriteLine(evenement.message);
};

voiture1.Explosion += (expediteur, evenement) =>
{
    Console.WriteLine(evenement.message);
};

// Accélère (ceci va générer les événements).
Console.WriteLine("\n***** Accélération *****");
for (int i = 0; i < 6; i++)
{
    voiture1.Accelerer(20);
}

Console.ReadLine();
```

Dans cet exemple, nous avons utilisé des expressions lambda pour connecter des gestionnaires d'événements aux événements déclenchés par l'objet `Voiture`. 

## Comprendre les Expressions Lambda

Les expressions lambda sont des fonctions anonymes qui peuvent contenir des expressions et des instructions. Elles sont utilisées principalement pour créer des délégués ou des arbres d'expression. Une expression lambda se compose des paramètres (s'ils existent), de l'opérateur `=>` (appelé opérateur lambda) et du corps.

Dans notre exemple :
- `(expediteur, evenement) => { Console.WriteLine(evenement.message); }` est une expression lambda qui agit comme un gestionnaire d'événements.
- `expediteur` est le paramètre représentant l'objet envoyant l'événement.
- `evenement` est le paramètre représentant les données de l'événement.
- `{ Console.WriteLine(evenement.message); }` est le corps de l'expression lambda, qui définit les actions à effectuer lorsque l'événement est déclenché.

## Avantages des Expressions Lambda

Les expressions lambda offrent plusieurs avantages, notamment :
- **Concision du code :** Elles permettent de définir des fonctions anonymes en quelques lignes de code, ce qui rend le code plus lisible et compact.
- **Facilité d'utilisation :** Elles simplifient le travail avec les délégués et les événements en permettant une syntaxe plus simple et plus intuitive.

En utilisant des expressions lambda, nous pouvons rendre notre code plus élégant et plus facile à comprendre, tout en conservant la même fonctionnalité que l'exemple précédent utilisant des délégués bruts.