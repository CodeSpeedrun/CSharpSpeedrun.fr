# Utilisation du mot-clé static avec les expressions lambda

Les expressions lambda en C# sont une forme concise pour définir des délégués, et il est donc logique qu'elles prennent également en charge le mot-clé static.

Considérons l'exemple suivant :

```csharp
// Déclaration d'une variable externe
var variableExterne = 0;

// Définition d'une fonction lambda prenant deux entiers en paramètres
Func<int, int, bool> EffectuerTravail = (x, y) =>
{
    variableExterne++; // Incrémentation de la variable externe
    return true;
};

// Appel de la fonction lambda
EffectuerTravail(3, 4);
```

Dans cet exemple, la fonction lambda `EffectuerTravail` incrémente une variable externe `variableExterne`.

Si nous tentons de modifier la fonction lambda pour qu'elle soit statique, une erreur de compilation sera générée car elle tente de modifier une variable déclarée dans une portée externe :

```csharp
// Déclaration d'une variable externe
var variableExterne = 0;

// Tentative de définition d'une fonction lambda statique
Func<int, int, bool> EffectuerTravail = static (x, y) =>
{
    // Erreur de compilation car elle accède à une variable externe
    // variableExterne++;
    return true;
};
```

Dans cet exemple, l'utilisation du mot-clé static génère une erreur car la fonction lambda tente d'accéder et de modifier une variable externe. En C#, les fonctions lambda statiques sont limitées dans leur accès aux variables externes, contrairement aux fonctions lambda non statiques qui ont accès à leur portée externe.

## Plus de détails sur les expressions lambda en C#

Les expressions lambda en C# offrent une syntaxe concise pour définir des délégués anonymes. Elles sont souvent utilisées pour passer des fonctions comme arguments à d'autres fonctions ou méthodes.

### Syntaxe des expressions lambda

La syntaxe générale d'une expression lambda en C# est la suivante :

```
(paramètres) => expression
```

- Les paramètres sont les entrées de la fonction lambda.
- L'expression est le corps de la fonction lambda qui définit son comportement.

### Portée des variables dans les expressions lambda

Les expressions lambda en C# peuvent accéder aux variables définies dans leur portée externe. Cependant, les fonctions lambda statiques ont des restrictions supplémentaires en ce qui concerne l'accès aux variables externes.

### Utilisation du mot-clé static avec les expressions lambda

L'utilisation du mot-clé static avec les expressions lambda restreint leur accès aux variables externes. Cela peut être utile pour des raisons de sécurité et de cohérence dans certains scénarios.

### Exemple d'utilisation de lambda

```csharp
// Déclaration d'une variable externe
int total = 0;

// Utilisation d'une expression lambda pour effectuer une opération
Func<int, int, int> addition = (a, b) => a + b;

// Utilisation de l'expression lambda pour ajouter deux nombres
total = addition(5, 3); // total vaut 8 après cette opération
```

Dans cet exemple, une expression lambda est utilisée pour définir une fonction d'addition. Cette fonction est ensuite utilisée pour ajouter deux nombres et mettre à jour la variable `total`.