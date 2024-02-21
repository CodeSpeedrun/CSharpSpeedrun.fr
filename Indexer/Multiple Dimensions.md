# Indexeurs avec Dimensions Multiples

```csharp
public class Conteneur
{
    private int[,] monTableau2D = new int[10, 10];
    public int this[int ligne, int colonne]
    { /* Obtenir ou définir une valeur à partir du tableau 2D */ }
}
```

Les indexeurs en C# permettent d'accéder aux éléments d'une classe comme s'ils étaient dans un tableau. Dans cet exemple, nous avons un indexeur dans une classe `Conteneur` qui prend deux paramètres, représentant les coordonnées de ligne et de colonne, et permettant d'accéder à une valeur dans un tableau 2D privé `monTableau2D`.

## Introduction aux Indexeurs en C#

Les indexeurs en C# sont une fonctionnalité puissante qui permet aux instances de classes d'être accessibles via une syntaxe similaire à celle des tableaux. Cela permet de simplifier l'accès aux données et de rendre le code plus intuitif.

### Utilisation d'Indexeurs

Les indexeurs sont utilisés pour accéder aux éléments d'une classe comme s'ils étaient dans un tableau. Ils sont souvent utilisés pour encapsuler des collections de données et offrir un accès plus naturel aux éléments de ces collections.

### Déclaration d'un Indexeur

Un indexeur est déclaré de manière similaire à une propriété, mais utilise le mot-clé `this`, suivi de paramètres entre crochets pour définir l'index.

## Exemple d'utilisation

```csharp
Conteneur monConteneur = new Conteneur();
monConteneur[2, 3] = 10; // Définit une valeur à la ligne 2, colonne 3 du tableau 2D
int valeur = monConteneur[2, 3]; // Obtient la valeur à la ligne 2, colonne 3 du tableau 2D
```

Dans cet exemple, nous créons une instance de la classe `Conteneur` et utilisons son indexeur pour définir puis récupérer une valeur à partir du tableau 2D.

## Conclusion

Les indexeurs en C# sont une fonctionnalité puissante pour permettre un accès intuitif aux données encapsulées dans une classe. Ils sont particulièrement utiles pour manipuler des collections de données multidimensionnelles, comme dans cet exemple avec un tableau 2D. En comprenant comment déclarer et utiliser des indexeurs, les développeurs peuvent écrire un code plus lisible et plus maintenable.