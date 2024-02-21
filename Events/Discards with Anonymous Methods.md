# Notes sur les Discards avec les Méthodes Anonymes

Les discards sont des variables anonymes utilisées comme paramètres d'entrée pour les méthodes anonymes. Dans les versions antérieures de C#, le caractère souligné (_) était un identificateur de variable légal. Cependant, pour qu'un underscore soit traité comme un discard, il faut en avoir au moins deux utilisés avec la méthode anonyme.

```csharp
Console.WriteLine("******** Discards with Anonymous Methods ********");
Func<int,int,int> constant = delegate (int _, int _) {return 42;};
Console.WriteLine("constant(3,4)={0}",constant(3,4));
```

L'exemple ci-dessus illustre l'utilisation des discards avec les méthodes anonymes. Une fonction constante est déclarée prenant deux paramètres entiers anonymes (_). Elle retourne toujours 42, indépendamment des valeurs des paramètres. Lorsque la fonction constant est appelée avec les valeurs 3 et 4, elle retourne 42.

Les discards sont utiles lorsqu'on a besoin de passer des paramètres à une méthode anonyme mais qu'on ne compte pas les utiliser à l'intérieur de la méthode. En utilisant des discards, on évite de devoir nommer les variables de paramètre, ce qui peut être pratique dans certains scénarios.

## Utilisation des Discards avec les Méthodes Anonymes

L'utilisation de discards avec les méthodes anonymes permet de passer des paramètres sans avoir à leur attribuer de noms spécifiques. Cela simplifie le code dans les cas où les valeurs des paramètres ne sont pas utilisées à l'intérieur de la méthode anonyme.

## Syntaxe des Discards

La syntaxe des discards en C# utilise le caractère souligné (_) pour représenter une variable anonyme. Dans le contexte des méthodes anonymes, il est possible d'utiliser des discards comme paramètres d'entrée.

## Limitation des Discards avec les Méthodes Anonymes

Dans les versions antérieures de C#, il était possible d'utiliser le caractère souligné (_) comme identificateur de variable. Ainsi, pour distinguer un underscore utilisé comme discard, il faut en avoir au moins deux dans une même portée de méthode anonyme.

## Exemple Pratique

```csharp
// Définition d'une méthode anonyme prenant deux paramètres, mais n'utilisant pas leur valeur
Func<int, int, int> add = delegate (int _, int _) { return 10; };

// Utilisation de la méthode anonyme avec des valeurs de paramètres
int result = add(5, 3); // Le résultat sera toujours 10, indépendamment des valeurs des paramètres
```

Dans cet exemple, la méthode anonyme `add` prend deux paramètres mais retourne toujours 10, indépendamment des valeurs des paramètres fournis. Les discards sont utilisés pour représenter des paramètres dont la valeur n'est pas utilisée dans le corps de la méthode anonyme.

Ce document Markdown présente une explication détaillée de l'utilisation des discards avec les méthodes anonymes en C#, en fournissant des exemples pratiques et des explications sur la syntaxe et les limitations de cette fonctionnalité.