## Introduction
Les delegates et la programmation fonctionnelle sont des concepts essentiels en C#. Ils permettent de créer des fonctions anonymes et de les passer comme arguments à d'autres fonctions. Dans ces notes, nous allons explorer les delegates et les utiliser pour implémenter des fonctions à l'aide des délégués prédéfinis `Func<>` et `Action<>`.

## Utilisation des délégués prédéfinis
Les délégués prédéfinis `Func<>` et `Action<>` sont largement utilisés en C# pour encapsuler des méthodes anonymes.

### Exemple d'utilisation de `Func<>`
```csharp
// Fonction pour ajouter deux nombres
static int Additionner(int x, int y)
{
    return x + y;
}

// Utilisation d'un délégué Func<>
Func<int, int, int> delegueAddition = Additionner;

// Appel de la fonction à travers le délégué
int resultat = delegueAddition.Invoke(40, 40);
Console.WriteLine("40 + 40 = {0}", resultat);
```

Dans cet exemple, nous définissons une fonction `Additionner` qui prend deux entiers en paramètre et retourne leur somme. Ensuite, nous utilisons un délégué `Func<>` pour encapsuler cette fonction, ce qui nous permet d'appeler `Additionner` via le délégué.

### Exemple d'utilisation de `Action<>`
Les délégués de type `Action<>` sont utilisés pour encapsuler des méthodes qui ne retournent pas de valeur.

```csharp
// Fonction pour afficher un message
static void AfficherMessage(string message)
{
    Console.WriteLine(message);
}

// Utilisation d'un délégué Action<>
Action<string> delegueAffichage = AfficherMessage;

// Appel de la fonction à travers le délégué
delegueAffichage("Bonjour!");

```

Dans cet exemple, nous définissons une fonction `AfficherMessage` qui prend une chaîne de caractères en paramètre et l'affiche à la console. Ensuite, nous utilisons un délégué `Action<>` pour encapsuler cette fonction, ce qui nous permet d'appeler `AfficherMessage` via le délégué.

## Création de délégués personnalisés
En plus des délégués prédéfinis, il est possible de créer des délégués personnalisés pour mieux refléter le domaine du problème.

```csharp
// Définition d'un délégué personnalisé pour une opération mathématique
delegate double OperationMathematique(double x, double y);

// Méthode pour multiplier deux nombres
static double Multiplier(double x, double y)
{
    return x * y;
}

// Utilisation du délégué personnalisé
OperationMathematique delegueMultiplication = Multiplier;

// Appel de la fonction à travers le délégué
double resultatMultiplication = delegueMultiplication(3.5, 2.0);
Console.WriteLine("3.5 * 2.0 = {0}", resultatMultiplication);
```

Dans cet exemple, nous définissons un délégué personnalisé `OperationMathematique` qui encapsule une opération mathématique prenant deux doubles en paramètre et retournant un double. Ensuite, nous utilisons ce délégué pour encapsuler la fonction `Multiplier`, permettant ainsi d'appeler `Multiplier` via le délégué.

## Conclusion
Les délégués et la programmation fonctionnelle offrent des moyens puissants pour encapsuler et manipuler des fonctions en C#. En utilisant des délégués prédéfinis tels que `Func<>` et `Action<>`, ainsi que des délégués personnalisés, les développeurs peuvent écrire un code plus expressif et flexible.