# LINQ et Variables Locales Typées Implicitement

Dans le langage C#, LINQ (Language Integrated Query) offre une syntaxe concise pour interroger des collections de données. Une pratique courante consiste à utiliser des variables locales typées implicitement pour rendre le code plus lisible et concis.

## Requêter des Entiers

Considérons un exemple où nous avons une liste d'âges et nous voulons sélectionner uniquement les personnes majeures, c'est-à-dire celles dont l'âge est supérieur à 18 ans.

```csharp
static void RequeteSurAges()
{
    int[] ages = {16, 25, 30, 17, 21, 40, 19, 22};
    // Sélectionner les âges supérieurs à 18.
    var majeurs = from age in ages where age > 18 select age;
}
```

Dans cet exemple, la méthode `RequeteSurAges` prend une liste d'âges en entrée. Nous utilisons ensuite une requête LINQ pour sélectionner les âges supérieurs à 18. Le résultat est stocké dans une variable `majeurs`, dont le type est déterminé implicitement grâce à `var`.

## Comprendre le Typage Implicite

L'utilisation de `var` permet au compilateur de déduire automatiquement le type de la variable en fonction de l'expression à droite de l'opérateur d'assignation. Cela simplifie la syntaxe et rend le code plus lisible. Cependant, le type exact est toujours connu au moment de la compilation.

## Clarté et Lisibilité

Bien que les variables typées implicitement rendent souvent le code plus concis, il est essentiel de maintenir la clarté et la lisibilité du code. Les noms de variables doivent être descriptifs et les contextes d'utilisation doivent être clairs pour faciliter la compréhension par d'autres développeurs.

## Conclusion

Les variables locales typées implicitement, en combinaison avec LINQ, offrent un moyen efficace de manipuler des données dans C#. Toutefois, il est important de les utiliser avec discernement pour garantir la clarté et la compréhension du code.
