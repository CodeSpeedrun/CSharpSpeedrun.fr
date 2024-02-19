# Spécification des paramètres de type pour les membres génériques

Pour spécifier le paramètre générique pour la méthode `Sort<>()`, utilisez :

```csharp
Array.Sort<int>(mesEntiers);
```

La création de méthodes génériques personnalisées

Vous pouvez obtenir une version améliorée des méthodes traditionnelles en surchargeant ces dernières. La surcharge consiste à définir plusieurs versions d'une même méthode, qui diffèrent par le nombre ou le type de paramètres. Bien que la surcharge soit une fonctionnalité utile dans un langage orienté objet, elle peut entraîner la création de nombreuses méthodes qui font essentiellement la même chose.

Plutôt que de construire une seule méthode (non générique) qui opère sur des paramètres objet, vous pouvez rencontrer les problèmes examinés précédemment dans ce chapitre, notamment le boxing, le unboxing, le manque de sécurité des types, le cast explicite, etc.

```csharp
// Echanger deux objets Personne.
static void Echanger<T>(ref T a, ref T b)
{
    Console.WriteLine("Vous avez envoyé à la méthode Echanger() un {0}", typeof(T));
    T temp = a;
    a = b;
    b = temp;
}
```

Cette méthode `Echanger<T>` permet d'échanger deux éléments de n'importe quel type spécifié par le paramètre de type `<T>`.

```csharp
static void AfficherClasseDeBase<T>()
{
    // BaseType est une méthode utilisée dans la réflexion,
    // qui sera examinée dans le chapitre 17.
    Console.WriteLine("La classe de base de {0} est : {1}.", typeof(T), typeof(T).BaseType);
}
```

Cette méthode `AfficherClasseDeBase<T>` affiche la classe de base pour le type spécifié par le paramètre de type `<T>`.

```
```

## Concepts additionnels

- Utilisation de méthodes génériques pour éviter le problème de la surcharge de méthodes.
- Avantages de la généricité en termes de performance et de maintenabilité du code.
- Démonstration des principes de base de la généricité en C#.

## Exemples supplémentaires

### Utilisation de méthodes génériques pour trier des tableaux

```csharp
public class TriTableau
{
    public static void TrierTableau<T>(T[] tableau)
    {
        Array.Sort(tableau);
    }
}
```

Dans cet exemple, la méthode générique `TrierTableau<T>` permet de trier un tableau de n'importe quel type.

### Utilisation de méthodes génériques pour effectuer des opérations mathématiques

```csharp
public class Calcul<T>
{
    public static T Additionner(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x + y;
    }
}
```

Cette classe `Calcul<T>` propose une méthode générique `Additionner` qui peut être utilisée pour additionner des valeurs de n'importe quel type. La `dynamic` est utilisée pour permettre l'addition de valeurs de types différents.

## Conclusion

Les méthodes génériques offrent une flexibilité et une réutilisabilité accrues dans le code en permettant le traitement de différents types de données sans duplication de code. Elles sont particulièrement utiles lorsque vous devez écrire des algorithmes ou des fonctionnalités qui sont indépendants du type de données avec lequel ils travaillent.
 