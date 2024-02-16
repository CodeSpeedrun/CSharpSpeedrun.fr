# Les interfaces `IEnumerable` et `IEnumerator`

En C#, les interfaces `IEnumerable` et `IEnumerator` sont des composants fondamentaux des capacités d'itération du langage. Ces interfaces permettent le parcours de collections telles que les tableaux, les listes et les types de collection personnalisés. Comprendre ces interfaces est crucial pour travailler efficacement avec les collections en C#.

## Interface IEnumerable

L'interface `IEnumerable` signifie qu'un objet peut être énuméré, ce qui signifie qu'il peut être parcouru à l'aide de constructions telles que `foreach` en C#. Cette interface contient une seule méthode :

```csharp
public interface IEnumerable
{
    IEnumerator GetEnumerator();
}
```

La méthode `GetEnumerator()` retourne une instance de `IEnumerator`, qui facilite le processus d'itération.

## Interface IEnumerator

L'interface `IEnumerator` fournit des fonctionnalités pour traverser une collection. Elle comprend les membres suivants :

```csharp
public interface IEnumerator
{
    bool MoveNext(); // Avance la position interne du curseur.
    object Current { get; } // Obtient l'élément actuel (propriété en lecture seule).
    void Reset(); // Réinitialise le curseur avant le premier élément.
}
```

En implémentant ces méthodes, une classe permet l'itération sur ses instances.

## Implémentation Exemplaire

Prenons un exemple d'une classe `Garage` qui contient un tableau d'objets `Car`. Nous allons démontrer comment implémenter ces interfaces dans le contexte de la classe `Garage`.

```csharp
public class Garage : IEnumerable
{
    private Car[] cars = new Car[4]; // Tableau pour stocker les voitures.

    // Constructeur pour initialiser les voitures dans le garage.
    public Garage()
    {
        cars[0] = new Car("Ferrari", 200);
        cars[1] = new Car("Toyota", 90);
        cars[2] = new Car("Honda", 30);
        cars[3] = new Car("Ford", 30);
    }

    // Implémentation de IEnumerable.GetEnumerator().
    public IEnumerator GetEnumerator()
    {
        return cars.GetEnumerator();
    }
}
```

Dans cet exemple, `Garage` implémente `IEnumerable` en fournissant sa propre implémentation de `GetEnumerator()`, qui délègue simplement l'appel à la méthode `GetEnumerator()` du tableau sous-jacent `cars`.

## Avantages de l'Implémentation de IEnumerable

Implémenter `IEnumerable` et `IEnumerator` permet aux objets de s'intégrer parfaitement aux constructions d'itération de C# telles que `foreach`. En respectant ces interfaces, les types de collection personnalisés peuvent être utilisés de manière cohérente avec les types de collection .NET intégrés.

## Implémentation d'Interface Explicite

Parfois, il est souhaitable de masquer la méthode `GetEnumerator()` au niveau de l'objet. Dans de tels cas, l'implémentation d'interface explicite peut être employée.

```csharp
public class Garage : IEnumerable
{
    private Car[] cars = new Car[4]; // Tableau pour stocker les voitures.

    // Constructeur pour initialiser les voitures dans le garage.
    public Garage()
    {
        cars[0] = new Car("Ferrari", 200);
        cars[1] = new Car("Toyota", 90);
        cars[2] = new Car("Honda", 30);
        cars[3] = new Car("Ford", 30);
    }

    // Implémentation explicite de IEnumerable.GetEnumerator().
    IEnumerator IEnumerable.GetEnumerator()
    {
        return cars.GetEnumerator();
    }
}
```

En implémentant explicitement `IEnumerable.GetEnumerator()`, la méthode `GetEnumerator()` n'est pas accessible au niveau de l'objet, mais elle est toujours disponible pour être utilisée par des constructions telles que `foreach`. Cette encapsulation peut être utile pour certaines considérations de conception.