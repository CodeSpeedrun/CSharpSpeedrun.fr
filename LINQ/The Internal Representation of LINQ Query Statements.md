# Internal Representation of LINQ Query Statements

Dans cette section, nous allons plonger dans la représentation interne des déclarations de requêtes LINQ en C#. Nous allons explorer la construction d'expressions de requête en utilisant divers opérateurs de requête C# tels que `from`, `in`, `where`, `orderby` et `select`. Vous avez peut-être également découvert que certaines fonctionnalités de l'API LINQ to Objects ne sont accessibles que lors de l'appel de méthodes d'extension de la classe `Enumerable`. Cependant, la vérité est que lorsque les requêtes LINQ sont compilées, le compilateur C# traduit tous les opérateurs LINQ C# en appels de méthodes de la classe `Enumerable`.

Un grand nombre des méthodes de `Enumerable` ont été prototypées pour prendre des délégués en tant qu'arguments. De nombreuses méthodes nécessitent un délégué générique nommé `Func<>`, que vous avez découvert lors de votre étude des délégués génériques au chapitre 10. Considérez la méthode `Where()` de `Enumerable`, qui est appelée automatiquement lorsque vous utilisez l'opérateur de requête `where` en C#.

```csharp
// Versions surchargées de la méthode Enumerable.Where<T>().
// Notez que le deuxième paramètre est de type System.Func<>.
public static IEnumerable<TSource> Where<TSource>(
    this IEnumerable<TSource> source,
    System.Func<TSource,int,bool> predicate)
public static IEnumerable<TSource> Where<TSource>(
    this IEnumerable<TSource> source,
    System.Func<TSource,bool> predicate)
```

Le délégué `Func<>` (comme son nom l'indique) représente un motif pour une fonction donnée avec un ensemble allant jusqu'à 16 arguments et une valeur de retour. Si vous examiniez ce type à l'aide de l'Explorateur d'objets de Visual Studio, vous remarqueriez diverses formes du délégué `Func<>`. Voici un exemple :

```csharp
// Les différents formats du délégué Func<>.
public delegate TResult Func<T1,T2,T3,T4,TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
public delegate TResult Func<T1,T2,T3,TResult>(T1 arg1, T2 arg2, T3 arg3)
```

Le premier code présenté contient des versions surchargées de la méthode `Where` de la classe `Enumerable`. La méthode `Where` est utilisée pour filtrer les éléments d'une séquence en fonction d'une condition spécifiée. Les versions surchargées permettent de spécifier un prédicat avec ou sans index pour chaque élément de la séquence.

Le second extrait de code montre différentes signatures du délégué `Func<>`. Ce délégué est utilisé pour représenter une méthode qui prend un certain nombre d'arguments et renvoie une valeur de retour. Les différentes signatures du délégué `Func<>` correspondent au nombre d'arguments acceptés par la méthode et au type de valeur retournée. 

En résumé, la représentation interne des déclarations de requêtes LINQ en C# implique la traduction des opérateurs de requête en appels de méthodes de la classe `Enumerable`, ainsi que l'utilisation de délégués génériques tels que `Func<>` pour fournir des fonctionnalités flexibles et génériques lors de la manipulation de données à l'aide de LINQ.