# Lambdas et membres de type Expression

La programmation en C# offre des fonctionnalités avancées telles que les lambdas et les membres de type expression. Ces fonctionnalités permettent de simplifier le code et d'améliorer la lisibilité.

## Utilisation des Lambdas

Les lambdas sont des fonctions anonymes qui peuvent être utilisées pour créer des délégués ou des expressions de type fonctionnel. Elles sont souvent utilisées pour simplifier la syntaxe lors de la définition de fonctions à usage unique.

```csharp
// Exemple de définition d'une lambda pour ajouter deux nombres
Func<int, int, int> addition = (x, y) => x + y;
int resultat = addition(3, 4); // Le résultat sera 7
```

Dans cet exemple, la lambda `(x, y) => x + y` définit une fonction prenant deux paramètres `x` et `y`, et renvoyant leur somme. Cette fonction est ensuite attribuée à la variable `addition`, qui est de type `Func<int, int, int>`.

## Membres de Type Expression

Les membres de type expression sont des méthodes ou des propriétés dont le corps est exprimé comme une seule instruction. Cela permet de réduire la syntaxe boilerplate pour des méthodes simples.

```csharp
// Exemple de membre de type expression pour l'addition
public int Addition(int x, int y) => x + y;
```

Dans cet exemple, la méthode `Addition` est définie comme un membre de type expression. Elle prend deux paramètres `x` et `y`, et renvoie leur somme. La syntaxe `=>` est utilisée pour définir le corps de la méthode en une seule instruction.

## Utilisation dans .NET Core

Les lambdas et les membres de type expression sont largement utilisés dans l'écosystème .NET Core pour simplifier le code et améliorer la lisibilité.

```csharp
// Exemple d'utilisation de lambda dans LINQ
var nombresPairs = nombres.Where(n => n % 2 == 0).ToList();
```

Dans cet exemple, une lambda est utilisée pour filtrer les nombres pairs à partir d'une liste de nombres. La méthode `Where` de LINQ prend une lambda comme argument, ce qui simplifie la syntaxe de filtrage.

## Avantages

L'utilisation de lambdas et de membres de type expression offre plusieurs avantages :

- **Simplicité syntaxique :** Les lambdas permettent de définir des fonctions anonymes de manière concise.
- **Réduction de la boilerplate :** Les membres de type expression permettent de réduire la syntaxe boilerplate pour des méthodes simples.
- **Amélioration de la lisibilité :** En éliminant le bruit syntaxique, les lambdas et les membres de type expression rendent le code plus lisible.

## Conclusion

Les lambdas et les membres de type expression sont des fonctionnalités puissantes de la programmation en C#. Leur utilisation permet de simplifier le code, d'améliorer la lisibilité et de réduire la boilerplate. Ils sont largement utilisés dans l'écosystème .NET Core et constituent un outil essentiel pour tout développeur C#.