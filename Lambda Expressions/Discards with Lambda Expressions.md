# L'utilisation des Discards avec les Expressions Lambda en C#

Les discards peuvent être utilisés avec les expressions lambda de la même manière qu'avec les délégués. Les variables d'entrée d'une expression lambda peuvent être remplacées par des discards si ces variables ne sont pas nécessaires. La même règle s'applique qu'avec les délégués. Puisque le tiret bas (_) était un identificateur de variable valide dans les versions précédentes de C#, il doit y avoir au moins deux discards utilisés avec l'expression lambda.

```csharp
int variableExterne = 0;
Func<int, int, bool> RealiserTravail = (x,y) =>
{
    variableExterne++;
    return true;
};
RealiserTravail(_,_);
```

Dans cet exemple, une expression lambda est utilisée pour définir la méthode `RealiserTravail`. Cette méthode prend deux paramètres, `x` et `y`, mais les discards sont utilisés car ces paramètres ne sont pas nécessaires pour la logique interne de la méthode. La variable `variableExterne` est une variable externe à la méthode lambda qui est incrémentée à chaque appel de la méthode.

Les discards offrent une manière concise de spécifier que certaines valeurs ne sont pas utilisées dans une expression lambda, ce qui peut rendre le code plus lisible et plus concis.

## Avantages des Discards avec les Expressions Lambda
- Simplifie la syntaxe lorsque les paramètres ne sont pas nécessaires.
- Améliore la lisibilité du code en mettant en évidence les valeurs non utilisées.
- Favorise une approche plus concise et expressive dans la définition des méthodes lambda.

## Limitations des Discards avec les Expressions Lambda
- Les discards ne peuvent être utilisés que pour les paramètres d'entrée dont la valeur n'est pas nécessaire.
- Le tiret bas (_) doit être utilisé comme discard, et au moins deux discards sont requis dans une expression lambda.

En utilisant les discards avec les expressions lambda, les développeurs peuvent écrire un code plus propre et plus lisible tout en évitant d'utiliser des valeurs de paramètre qui ne sont pas nécessaires pour la logique métier.
