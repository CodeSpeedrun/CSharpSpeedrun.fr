# LINQ (Language Integrated Query)

LINQ est un ensemble de technologies connexes qui tentent de fournir une manière unique et symétrique d'interagir avec diverses formes de données. Comme expliqué tout au long de ce chapitre, LINQ peut interagir avec n'importe quel type implémentant l'interface IEnumerable<T>, y compris les tableaux simples ainsi que les collections génériques et non génériques de données.

En travaillant avec les technologies LINQ, plusieurs fonctionnalités du langage C# sont utilisées. Par exemple, étant donné que les expressions de requête LINQ peuvent retourner un nombre quelconque d'ensembles de résultats, il est courant d'utiliser le mot-clé var pour représenter le type de données sous-jacent. De plus, les expressions lambda, la syntaxe d'initialisation d'objet et les types anonymes peuvent tous être utilisés pour construire des requêtes LINQ fonctionnelles et compactes.

Plus important encore, vous avez vu comment les opérateurs de requête LINQ en C# ne sont que des notations abrégées pour appeler des membres statiques du type System.Linq.Enumerable. Comme montré, la plupart des membres de Enumerable opèrent sur des types de délégué Func<T>, qui peuvent prendre des adresses de méthode littérales, des méthodes anonymes ou des expressions lambda en tant qu'entrée pour évaluer la requête.

Les données peuvent être trouvées dans de nombreux endroits, y compris les fichiers XML, les bases de données relationnelles, les collections en mémoire et les tableaux primitifs.

La technologie LINQ, introduite initialement dans .NET 3.5, fournit une manière concise, symétrique et fortement typée pour accéder à une grande variété de sources de données.

Vous constaterez que les variables locales à typage implicite, la syntaxe d'initialisation d'objet, les expressions lambda, les méthodes d'extension et les types anonymes seront très utiles.

Il est recommandé de considérer les requêtes LINQ comme des instructions uniques, qui "ressemblent" simplement à du SQL.

Les requêtes LINQ sont fortement typées contrairement à une instruction SQL traditionnelle.

## Où trouver les données et comment les obtenir

| Type de données       | Comment les obtenir                            |
|-----------------------|-----------------------------------------------|
| Données relationnelles| System.Data.dll, System.Data.SqlClient.dll, etc.|
| Données de documents XML| System.Xml.dll                              |
| Tables de métadonnées | L'espace de noms System.Reflection           |
| Collections d'objets | System.Array et les espaces de noms System.Collections/System.Collections.Generic |

## Exemple de requête LINQ sur des chaînes de caractères

```csharp
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        QueryOverStrings();
    }

    static void QueryOverStrings()
    {
        string[] jeuxVideos = {"Half life", "Uncharted 2","Daxter"};
        
        // Construire une expression de requête pour trouver les éléments dans le tableau
        // qui ont un espace intégré.
        IEnumerable<string> sousEnsemble =
            from j in jeuxVideos
            where j.Contains(" ")
            orderby j
            select j;

        foreach (var jeu in sousEnsemble)
        {
            Console.WriteLine(jeu);
        }
    }
}
```

Dans cet exemple, nous avons un tableau de chaînes de caractères représentant des noms de jeux vidéo. Nous utilisons une expression de requête LINQ pour sélectionner et trier les jeux qui contiennent un espace.

## Utilisation des méthodes d'extension pour les requêtes sur des chaînes de caractères

```csharp
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        QueryOverStringsWithExtensionMethods();
    }

    static void QueryOverStringsWithExtensionMethods()
    {
        string[] jeuxVideos = {"Half life", "Uncharted 2","Daxter"};
        
        // Construire une expression de requête pour trouver les éléments dans le tableau
        // qui ont un espace intégré en utilisant des méthodes d'extension.
        IEnumerable<string> sousEnsemble =
            jeuxVideos.Where(j => j.Contains(" "))
                      .OrderBy(j => j)
                      .Select(j => j);

        foreach (var jeu in sousEnsemble)
        {
            Console.WriteLine(jeu);
        }
    }
}
```

Dans cet exemple, nous utilisons des méthodes d'extension LINQ pour obtenir le même résultat que dans l'exemple précédent, mais en utilisant une syntaxe légèrement différente. Les méthodes d'extension permettent une syntaxe fluide et concise pour écrire des requêtes LINQ.

Ces notes couvrent les principes fondamentaux de LINQ, y compris son utilisation avec différents types de données, la syntaxe des expressions de requête et des méthodes d'extension, ainsi que des conseils pour écrire des requêtes LINQ efficaces.