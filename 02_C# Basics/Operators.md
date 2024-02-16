### Opérateurs logiques

Les opérateurs logiques sont des éléments essentiels de la programmation en C#. Ils permettent de réaliser des opérations de logique booléenne sur les valeurs booléennes ou les expressions conditionnelles. Voici quelques opérateurs logiques couramment utilisés :

- **&& (ET logique)** : Renvoie vrai si les deux expressions sont vraies.
- **|| (OU logique)** : Renvoie vrai si au moins l'une des expressions est vraie.
- **! (NON logique)** : Inverse le résultat de l'expression.

#### Opérateur ET (&&)

L'opérateur && retourne vrai uniquement si les deux expressions sur lesquelles il opère sont vraies. Sinon, il renvoie faux.

Exemple :
```csharp
int a = 5;
int b = 10;

Console.WriteLine("Logique et : " + ((a < 3) && b < 20));
```
Résultat : `Logique et : False`

Dans cet exemple, la première expression `(a < 3)` est fausse, donc même si la deuxième expression `b < 20` est vraie, l'opérateur && renvoie false car il nécessite que les deux conditions soient vraies.

#### Opérateur OU (||)

L'opérateur || renvoie vrai si au moins l'une des expressions sur lesquelles il opère est vraie.

Exemple :
```csharp
Console.WriteLine("Logique ou : " + ((a < 3) || b < 20));
```
Résultat : `Logique ou : True`

Dans cet exemple, la deuxième expression `b < 20` est vraie, donc même si la première expression `(a < 3)` est fausse, l'opérateur || renvoie vrai car au moins une des conditions est vraie.

#### Opérateur NON (!)

L'opérateur ! inverse le résultat de l'expression. S'il y a une expression vraie, il renvoie faux, et s'il y a une expression fausse, il renvoie vrai.

Exemple :
```csharp
Console.WriteLine("Logique non : " + (a != b));
```
Résultat : `Logique non : True`

Dans cet exemple, `a` n'est pas égal à `b`, donc l'opérateur ! renvoie vrai.

### Précédence des opérateurs

La précédence des opérateurs détermine l'ordre dans lequel les opérations sont effectuées lorsqu'une expression contient plusieurs opérateurs.

Lorsque plusieurs opérateurs sont utilisés dans une expression, ils sont évalués de gauche à droite. Les opérateurs avec une priorité plus élevée sont évalués avant ceux avec une priorité plus basse. Toutefois, l'utilisation de parenthèses permet de modifier manuellement la priorité des opérateurs.

Exemple :
```csharp
int a = 5;
int b = 10;
Console.WriteLine(a + b * 3); 
Console.WriteLine((a + b) * 3); 
```
Résultats :
```
35
45 
```

Dans le premier cas, `b * 3` est évalué en premier car l'opérateur de multiplication a une priorité plus élevée que l'opérateur d'addition. Dans le deuxième cas, `(a + b)` est évalué en premier en raison des parenthèses, ce qui modifie l'ordre d'évaluation.