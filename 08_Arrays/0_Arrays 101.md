************************************

# Les Tableaux en C#

## Introduction
Les tableaux en C# sont des structures de données fondamentales qui permettent de stocker une collection d'éléments du même type. Ils offrent un accès aléatoire efficace aux éléments en utilisant des indices numériques.

## Tableaux Basiques
Un tableau est un ensemble de points de données contigus du même type.

```csharp
int[] mesNombres = new int[3];
// Créer un tableau d'entiers avec 3 éléments.
```

```csharp
string[] livresSurDotNet = new string[100];
// Créer un tableau pour stocker les titres de livres sur .NET, avec de l'espace pour 100 titres.
```

### Initialisation des Tableaux
Les tableaux peuvent être initialisés avec des valeurs au moment de la déclaration.

```csharp
string[] tableauDeChaines = new string[] { "un", "deux", "trois" };
```

```csharp
bool[] tableauDeBooleens = { false, false, true };
```

```csharp
var a = new[] { 1, 10, 100, 1000 };
// Initialisation de tableau de type inféré.
```

### Accès aux Éléments
Les éléments du tableau peuvent être accédés en utilisant des indices, en commençant par 0.

```csharp
int premierNombre = mesNombres[0];
```

## Tableaux Rectangulaires
Les tableaux rectangulaires sont des tableaux avec plusieurs dimensions.

```csharp
int[,] maMatrice = new int[3, 4];
// Créer une matrice 3x4.
```

### Peuplement des Tableaux Rectangulaires
Le peuplement d'un tableau rectangulaire implique des boucles imbriquées.

```csharp
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        maMatrice[i, j] = i * j;
    }
}
```

## Tableaux Échelonnés
Les tableaux échelonnés sont des tableaux de tableaux, où chaque tableau interne peut avoir une taille différente.

```csharp
int[][] monTableauEchelonne = new int[5][];
// Créer un tableau échelonné avec 5 tableaux internes.
```

### Initialisation des Tableaux Échelonnés
L'initialisation des tableaux échelonnés implique de créer chaque tableau interne séparément.

```csharp
for (int i = 0; i < monTableauEchelonne.Length; i++)
{
    monTableauEchelonne[i] = new int[i + 7];
}
```

## Méthodes et Tableaux
Les méthodes peuvent renvoyer des tableaux.

```csharp
static string[] ObtenirTableauDeChaines()
{
    string[] lesChaines = { "Bonjour", "depuis", "ObtenirTableauDeChaines" };
    return lesChaines;
}
```

## Conclusion
Les tableaux sont des structures de données polyvalentes en C#, offrant un stockage et un accès efficaces pour les collections d'éléments. Les tableaux rectangulaires offrent un stockage multi-dimensionnel, tandis que les tableaux échelonnés offrent une flexibilité de taille. Comprendre les tableaux est crucial pour une programmation efficace en C#.