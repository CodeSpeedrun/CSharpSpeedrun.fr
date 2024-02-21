# Compréhension des Expressions Lambda

Les expressions lambda permettent de manipuler des événements "en ligne" en assignant directement un bloc de code à un événement à l'aide de méthodes anonymes, plutôt que de construire une méthode autonome à appeler par le délégué sous-jacent. Les expressions lambda ne sont rien de plus qu'une manière concise d'écrire des méthodes anonymes et finalement simplifient la manière dont vous travaillez avec le délégué dans .NET Core.

```csharp
// Méthode de la classe System.Collections.Generic.List<T>
public List<T> TrouverTout(Predicate<T> condition)
```

```csharp
// Ce délégué est utilisé par la méthode TrouverTout()
// pour extraire le sous-ensemble.
public delegate bool Predicate<T>(T obj);
```

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Plaisirs avec les Lambdas *****\n");
        SyntaxeDelegateTraditionnelle();
        Console.ReadLine();
    }

    static void SyntaxeDelegateTraditionnelle()
    {
        // Créez une liste d'entiers.
        List<int> liste = new List<int>();
        liste.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

        // Appel de TrouverTout() en utilisant la syntaxe du délégué traditionnelle.
        Predicate<int> rappel = EstNombrePair;
        List<int> nombresPairs = liste.TrouverTout(rappel);

        Console.WriteLine("Voici vos nombres pairs :");
        foreach (int nombrePair in nombresPairs)
        {
            Console.Write("{0}\t", nombrePair);
        }
        Console.WriteLine();
    }

    // Cible pour le délégué Predicate<>.
    static bool EstNombrePair(int i)
    {
        // Est-ce un nombre pair ?
        return (i % 2) == 0;
    }
}
```

```csharp
static void SyntaxeMethodeAnonyme()
{
    // Créez une liste d'entiers.
    List<int> liste = new List<int>();
    liste.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

    // Maintenant, utilisez une méthode anonyme.
    List<int> nombresPairs = liste.TrouverTout(delegate(int i) { return (i % 2) == 0; });

    Console.WriteLine("Voici vos nombres pairs :");
    foreach (int nombrePair in nombresPairs)
    {
        Console.Write("{0}\t", nombrePair);
    }
    Console.WriteLine();
}
```

```csharp
static void SyntaxeExpressionLambda()
{
    // Créez une liste d'entiers.
    List<int> liste = new List<int>();
    liste.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

    // Maintenant, utilisez une expression lambda C#.
    List<int> nombresPairs = liste.TrouverTout(i => (i % 2) == 0);

    Console.WriteLine("Voici vos nombres pairs :");
    foreach (int nombrePair in nombresPairs)
    {
        Console.Write("{0}\t", nombrePair);
    }
    Console.WriteLine();
}
```

L'expression lambda `i => (i % 2) == 0` est compilée en une méthode anonyme équivalente :

```csharp
List<int> nombresPairs = liste.TrouverTout(delegate (int i)
{
    return (i % 2) == 0;
});
```

Dans les exemples ci-dessus :

- `SyntaxeDelegateTraditionnelle()` utilise la syntaxe de délégué traditionnelle pour appeler la méthode `TrouverTout()`.
- `SyntaxeMethodeAnonyme()` utilise une méthode anonyme pour filtrer les nombres pairs dans la liste.
- `SyntaxeExpressionLambda()` utilise une expression lambda pour le même but.

Les expressions lambda offrent une syntaxe plus concise et expressive pour définir des fonctions anonymes, ce qui rend le code plus lisible et maintenable. Elles sont largement utilisées dans le développement C# pour simplifier les opérations sur les collections et le traitement des événements.