
## Typage implicite des variables locales

Le mot clé `var` de C# permet de définir une variable locale sans spécifier explicitement le type de données sous-jacent. La variable est toutefois fortement typée, car le compilateur déterminera le bon type de données en fonction de l'assignation initiale.

```csharp
var monEntier = 10;
Console.WriteLine("monEntier est de type : {0}", monEntier.GetType().Name);
```

Dans de nombreux cas, les requêtes LINQ renverront une séquence de types de données qui ne sont pas connus avant le temps de compilation. Par conséquent, vous ne pouvez pas déclarer une variable de manière explicite.

## Syntaxe d'initialisation d'objet et de collection

La syntaxe d'initialisation d'objet vous permet de créer une variable de classe ou de structure et de définir un nombre quelconque de ses propriétés publiques en une seule fois.

```csharp
List<Rectangle> maListeDeRectangles = new List<Rectangle>
{
    new Rectangle {TopLeft = new Point { X = 10, Y = 10 },
    BottomRight = new Point { X = 200, Y = 200}}
};
```

## Expressions Lambda

Les expressions lambda de C# (=>) peuvent être utilisées chaque fois que vous invoquez une méthode nécessitant un délégué fortement typé en argument. Les lambdas simplifient considérablement la manière dont vous travaillez avec les délégués, en réduisant la quantité de code que vous devez écrire manuellement.

```csharp
List<int> liste = new List<int>();
liste.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
List<int> nombresPairs = liste.FindAll(i => (i % 2) == 0);
```

Les expressions lambda sont utiles lorsque vous travaillez avec le modèle objet sous-jacent de LINQ. Les opérateurs de requête LINQ en C# ne sont en fait qu'une notation abrégée pour appeler des méthodes sur une classe appelée `System.Linq.Enumerable`. Ces méthodes nécessitent généralement des délégués (en particulier le délégué `Func<>`) en tant que paramètres, et les expressions lambda vous permettent de simplifier votre code.

## Méthodes d'extension

Les méthodes d'extension de C# vous permettent d'ajouter de nouvelles fonctionnalités à des classes existantes sans avoir besoin de créer une sous-classe. Le premier paramètre est qualifié avec le mot clé `this` et marque le type étendu.

```csharp
namespace MesExtensions
{
    static class ExtensionsObjet
    {
        public static void AfficherAssemblyDefinissant(this object obj)
        {
            // Code pour afficher l'assembly définissant.
        }
    }
}
```

Lorsque vous travaillez avec LINQ, vous n'aurez que rarement besoin de créer vos propres méthodes d'extension. En effet, chaque opérateur de requête LINQ en C# est une notation abrégée pour appeler une méthode d'extension sous-jacente, généralement définie par la classe utilitaire `System.Linq.Enumerable`.


## Types anonymes

Cette fonctionnalité permet de modéliser rapidement la "forme" des données en permettant au compilateur de générer une nouvelle définition de classe au moment de la compilation, en fonction d'un ensemble fourni de paires nom-valeur.

```csharp
var achat = new {
    HeureAchat = DateTime.Now,
    ArticleAcheté = new {Couleur = "Rouge", Marque = "Saab", VitesseActuelle = 55},
    Prix = 34.000
};
```

LINQ fait souvent usage de types anonymes lorsque vous souhaitez projeter de nouvelles formes de données à la volée. Par exemple, supposons que vous ayez une collection d'objets `Personne` et que vous souhaitiez utiliser LINQ pour obtenir des informations sur l'âge et le numéro de sécurité sociale de chacun. En utilisant une projection LINQ, vous pouvez permettre au compilateur de générer un nouveau type anonyme contenant vos informations.
