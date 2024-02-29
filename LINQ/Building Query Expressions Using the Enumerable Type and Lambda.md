# Utilisation de l'Enumerable Type et Lambda pour Construire des Expressions de Requête

Dans ce document, nous explorons l'utilisation de l'Enumerable Type et des expressions Lambda pour construire des requêtes dans le langage C#. Nous commençons par un exemple pratique de manipulation d'un tableau de noms de jeux vidéo.

## Exemple Pratique

Supposons que nous ayons un tableau de noms de jeux vidéo :

```csharp
string[] jeuxVideosActuels = {"Dune", "Uncharted 2", "Bio Shock 2"};
```

### Construction de l'Expression de Requête

Nous voulons filtrer les jeux vidéo qui contiennent un espace dans leur nom et les trier par ordre alphabétique. Nous utilisons pour cela les méthodes d'extension fournies par le type Enumerable.

```csharp
// Construction de l'expression de requête en utilisant des méthodes d'extension
var jeuxAvecEspaces = jeuxVideosActuels.Where(jeu => jeu.Contains(" "));
var jeuxTries = jeuxAvecEspaces.OrderBy(jeu => jeu);
var sousEnsemble = jeuxTries.Select(jeu => jeu);
```

### Décomposition de l'Expression de Requête

Nous pouvons également décomposer l'expression de requête en étapes distinctes pour une meilleure lisibilité du code.

```csharp
var jeuxAvecEspaces = jeuxVideosActuels.Where(jeu => jeu.Contains(" "));
var jeuxTries = jeuxAvecEspaces.OrderBy(jeu => jeu);
var sousEnsemble = jeuxTries.Select(jeu => jeu);
```

Dans cet exemple, nous avons :

- `jeuxAvecEspaces`: une expression de requête filtrant les jeux vidéo qui contiennent un espace dans leur nom.
- `jeuxTries`: une expression de requête triant les jeux vidéo filtrés par ordre alphabétique.
- `sousEnsemble`: une expression de requête sélectionnant les jeux vidéo triés.

## Plus de Détails

### Utilisation de Méthodes d'Extension

Les méthodes d'extension telles que `Where`, `OrderBy` et `Select` sont fournies par le type Enumerable pour manipuler des collections de manière fonctionnelle.

### Expressions Lambda

Les expressions Lambda, telles que `jeu => jeu.Contains(" ")`, sont des fonctions anonymes utilisées pour définir des critères de filtrage, de tri ou de sélection dans les expressions de requête.

### Types Enumerable et Extension

Le type Enumerable fournit des méthodes d'extension pour manipuler des collections telles que les tableaux, les listes, etc. Ces méthodes facilitent les opérations de filtrage, de tri et de sélection sur ces collections.

### Linq

Ce type de requête est couramment utilisé dans le cadre du `Langage Integrated Query (LINQ)`, une fonctionnalité de C# permettant d'écrire des requêtes SQL-like sur des sources de données .NET.

En conclusion, l'utilisation de l'Enumerable Type et des expressions Lambda pour construire des expressions de requête offre une manière élégante et efficace de manipuler des collections de données dans le langage C#.
