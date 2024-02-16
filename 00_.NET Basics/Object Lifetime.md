# Comprendre la durée de vie des objets en C#

En C#, le temps de vie des objets est géré par l'exécution à travers un processus appelé la collecte des ordures (GC). Les objets sont alloués sur le tas géré et sont automatiquement nettoyés par le GC lorsqu'ils ne sont plus référencés.

## Tas géré et collecte des ordures

Le tas géré est une région de mémoire où les objets .NET Core sont alloués. Le collecteur de déchets examine périodiquement ce tas pour récupérer la mémoire occupée par des objets qui ne sont plus utilisés. Ce processus aide à optimiser l'utilisation de la mémoire et à prévenir les fuites de mémoire.

## Allocation d'objets avec le mot-clé `new`

En C#, les objets sont créés à l'aide du mot-clé `new`. Lorsque `new` est utilisé pour instancier une classe, la mémoire est allouée sur le tas géré, et une référence vers l'objet est renvoyée. Il est important de comprendre que la référence renvoyée par `new` pointe vers l'objet sur le tas, pas vers l'objet lui-même.

```csharp
// Exemple de création d'un objet Car et d'obtention d'une référence à celui-ci
Car maVoiture = new Car("Zippy", 50);
```

## Gestion du temps de vie des objets

La durée de vie d'un objet dépend des références qui lui sont associées. Lorsqu'il n'y a plus de références à un objet, celui-ci devient éligible à la collecte des ordures. Cependant, il est essentiel de noter que la destruction réelle de l'objet par le GC se produit à un moment indéterminé dans le futur.

```csharp
static void CréerVoiture()
{
    // Création d'un objet Car dans une méthode
    Car maVoiture = new Car();
    // Lorsque cette méthode retourne, si `maVoiture` est la seule référence à l'objet Car,
    // il peut être détruit par le collecteur de déchets.
}
```

## Génération de CIL pour le mot-clé `new`

Lorsque le compilateur C# rencontre le mot-clé `new`, il génère des instructions de Common Intermediate Language (CIL), spécifiquement l'instruction `newobj`, dans l'implémentation de la méthode. Cette instruction est responsable de l'allocation de mémoire pour le nouvel objet.

## Conclusion

Comprendre la durée de vie des objets et la gestion de la mémoire en C# est crucial pour écrire des applications efficaces et évolutives. En étant conscient de l'allocation des objets, des références et de la collecte des ordures, les développeurs peuvent optimiser leur code pour une meilleure performance et une meilleure utilisation des ressources.

```csharp
// Définition d'une classe Car d'exemple
public class Car
{
    public string Modèle { get; set; }
    public int Vitesse { get; set; }

    // Constructeur avec des paramètres
    public Car(string modèle, int vitesse)
    {
        Modèle = modèle;
        Vitesse = vitesse;
    }

    // Constructeur par défaut
    public Car()
    {
        // Implémentation du constructeur par défaut
    }
}
```

```csharp
// Exemple d'utilisation de la classe Car
class Program
{
    static void Main(string[] args)
    {
        // Création d'un nouvel objet Car
        Car maVoiture = new Car("Zippy", 50);

        // Affichage des informations sur la voiture
        Console.WriteLine($"Modèle : {maVoiture.Modèle}, Vitesse : {maVoiture.Vitesse}");
    }
}
```

```csharp
// Autre exemple illustrant la durée de vie des objets
class Program
{
    static void Main(string[] args)
    {
        CréerVoiture();
        // À ce stade, l'objet Car créé à l'intérieur de la méthode CréerVoiture() peut être éligible à la collecte des ordures.
    }

    static void CréerVoiture()
    {
        Car maVoiture = new Car();
        // Lorsque cette méthode retourne, si `maVoiture` est la seule référence à l'objet Car,
        // il peut être détruit par le collecteur de déchets.
    }
}
```

```csharp
// Exemple de code CIL généré pour le mot-clé `new`
.method private hidebysig static void FaireUneVoiture() cil managed
{
    .maxstack 1
    .locals init (class Car V_0)
    // Instanciation d'un nouvel objet Car
    IL_0000: newobj instance void Car::.ctor()
    IL_0005: stloc.0
    IL_0006: ret
}
```


### Notes de programmation C#

Ci-dessous, des notes couvrant divers aspects de la programmation C#, notamment la gestion de la mémoire, l'interface IDisposable, l'instruction using, la classe Lazy<T>, et plus encore.

```csharp
// Forcer la collecte des ordures et attendre la finalisation des objets.
GC.Collect();
GC.WaitForPendingFinalizers();
```

En C#, la collecte des ordures est le processus par lequel l'exécution .NET gère la mémoire. La méthode `GC.Collect()` force la collecte des ordures, récupérant la mémoire occupée par des objets qui ne sont plus utilisés. `GC.WaitForPendingFinalizers()` assure que tous les objets en attente de finalisation sont traités avant de continuer.

```csharp
public interface IDisposable
{
    void Dispose();
}
```

L'interface `IDisposable` est utilisée pour fournir un mécanisme de libération des ressources non managées, telles que les handles de fichier ou les connexions de base de données. Implémenter `IDisposable` nécessite de définir une méthode `Dispose()`, qui devrait libérer toutes les ressources détenues par l'objet.

```csharp
finally
{
    // Appeler Dispose() toujours, qu'une erreur survienne ou non.
    monWrapper.Dispose();
}
```

Dans les scénarios sujets aux erreurs, il est crucial de libérer les ressources même si une exception se produit. Le bloc `finally` garantit que `Dispose()` est toujours appelé, que ce soit une exception est levée ou non.

```csharp
// Dispose() est automatiquement appelé lorsque le scope using se termine.
using (MyResourceWrapper monWrapper = new MyResourceWrapper())
{
    // Utiliser l'objet

 myWrapper.
}
```

L'instruction `using` fournit une syntaxe pratique pour appeler automatiquement `Dispose()` sur les objets qui implémentent `IDisposable`. Cela garantit que les ressources sont correctement libérées même si des exceptions se produisent dans le bloc `using`.

```csharp
private static void UsingDeclaration()
{
    // La variable sera dans le scope jusqu'à la fin de la méthode.
    using var monWrapper = new MyResourceWrapper();
    // Effectuer des opérations en utilisant monWrapper.
}
```

Introduite dans C# 8.0, la déclaration `using` simplifie la gestion des ressources en disposant automatiquement des objets à la fin du scope englobant. La variable déclarée avec `using` est disponible jusqu'à la fin de la méthode dans laquelle elle est déclarée.

```csharp
// La classe MediaPlayer encapsule un objet Lazy<AllTracks>.
class MediaPlayer
{
    private Lazy<AllTracks> _tousLesMorceaux = new Lazy<AllTracks>();

    public AllTracks GetAllTracks()
    {
        // Récupérer tous les morceaux.
        return _tousLesMorceaux.Value;
    }
}
```

La classe `Lazy<T>` retarde la création d'un objet jusqu'à ce qu'il soit accédé pour la première fois. Cela peut être bénéfique pour les scénarios critiques en termes de performances où l'initialisation d'un objet est coûteuse et peut ne pas toujours être nécessaire. Dans cet exemple, `MediaPlayer` initialise paresseusement son champ `_tousLesMorceaux` lorsque `GetAllTracks()` est appelé.

### Conclusion

Ces notes de programmation C# couvrent des concepts essentiels tels que la collecte des ordures, l'interface IDisposable, l'instruction using, et la classe Lazy<T>. Comprendre ces concepts est crucial pour une gestion efficace des ressources et le développement d'applications efficaces en C#.