# La création d'expressions de requête à l'aide du type Enumerable et de chaînes brutes

```csharp
string[] jeuxVideoActuels = {"Dune", "Uncharted 2", "Bio Shock 2"};

Func<string, bool> filtreRecherche = new Func<string, bool>(Filtrer);
Func<string, string> elementAtraiter = new Func<string, string>(TraiterElement);

var sousEnsemble =
    jeuxVideoActuels
        .Where(filtreRecherche)
        .OrderBy(elementAtraiter)
        .Select(elementAtraiter);

foreach (var jeu in sousEnsemble)
{
    Console.WriteLine(jeu);
}
```

Dans ce code, nous avons un exemple d'utilisation de LINQ (Language Integrated Query) en C#. LINQ est un ensemble de fonctionnalités de requête intégrées dans le langage C#.

## Principes fondamentaux de LINQ

- **Expressions de requête** : Les expressions de requête permettent de formuler des requêtes de données de manière intuitive et déclarative, en utilisant une syntaxe similaire à SQL.
- **Opérateurs de requête** : Les opérateurs de requête sont des mots-clés spécifiques (tels que `Where`, `OrderBy`, `Select`, etc.) utilisés pour manipuler les collections de données.
- **Type Enumerable** : Le type Enumerable est une classe statique qui fournit un ensemble de méthodes d'extension pour les collections, permettant d'effectuer des opérations de requête.

## Détails du code

1. **Définition des données** : Nous avons une liste de jeux vidéo actuels stockés dans un tableau de chaînes de caractères.
2. **Définition des delegates** : Nous définissons deux delegates, `filtreRecherche` et `elementAtraiter`, qui seront utilisés pour filtrer et traiter les éléments de la liste.
3. **Construction de la requête** : Nous utilisons les opérateurs de requête pour filtrer les jeux vidéo, les ordonner et sélectionner les éléments à traiter.
4. **Exécution de la requête** : Nous exécutons la requête en itérant sur le sous-ensemble résultant et en affichant chaque élément.

## Sous le capot de LINQ

- **Opérateurs de requête vs méthodes d'extension** : Les opérateurs de requête (`Where`, `OrderBy`, `Select`, etc.) sont en fait des méthodes d'extension définies dans la classe `Enumerable`. Les expressions de requête sont traduites en appels de ces méthodes d'extension lors de la compilation.
- **Utilisation de delegates** : Certaines méthodes de `Enumerable` nécessitent des delegates en tant que paramètres. Dans notre exemple, les delegates `Func<string, bool>` et `Func<string, string>` sont utilisés pour spécifier les critères de filtrage et de traitement.
- **Expressions lambda** : Les expressions lambda sont des fonctions anonymes utilisées pour définir des delegates de manière concise. Elles sont souvent utilisées pour passer des fonctions en tant que paramètres à d'autres fonctions, comme c'est le cas ici avec les méthodes de `Enumerable`.

En résumé, LINQ offre une manière puissante et expressive de manipuler des collections de données en C#, en permettant de formuler des requêtes de manière déclarative et en s'appuyant sur des concepts familiers comme les expressions lambda et les méthodes d'extension.