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
using System;
using System.Collections;

namespace CSharpSpeedrun {
    public class Car {
        public string Make { get; set; }
        public int MaxSpeed { get; set; }

        public Car(string make, int maxSpeed) {
            Make = make;
            MaxSpeed = maxSpeed;
        }
    }

    public class Garage : IEnumerable {
        private Car[] cars = new Car[4];
        public Garage() {
            cars[0] = new Car("Ferrari", 200);
            cars[1] = new Car("Toyota", 90);
            cars[2] = new Car("Honda", 30);
            cars[3] = new Car("Ford", 30);
        }

        public IEnumerator GetEnumerator() {
            return cars.GetEnumerator();
        }
    }

    class Program {
        static void Main() {
            Garage myGarage = new Garage();

            foreach (Car car in myGarage) {
                Console.WriteLine("Make: {0}, Max Speed: {1}", car.Make, car.MaxSpeed);
            }

        }
    }
}
/*
Make: Ferrari, Max Speed: 200
Make: Toyota, Max Speed: 90
Make: Honda, Max Speed: 30
Make: Ford, Max Speed: 30
*/
```

Dans cet exemple, `Garage` implémente `IEnumerable` en fournissant sa propre implémentation de `GetEnumerator()`, qui délègue simplement l'appel à la méthode `GetEnumerator()` du tableau sous-jacent `cars`.

#### Explication détaillée 
la boucle `foreach` peut utiliser `myGarage` pour accéder au tableau privé `Car[] cars = new Car[4];` d'une autre classe

**1. Interface `IEnumerable`:**

- La classe `Garage` implémente l'interface `IEnumerable`. Cette interface indique que les objets de cette classe peuvent être énumérés, ce qui signifie que leurs éléments peuvent être accédés un par un.
- La méthode `GetEnumerator()`, requise par `IEnumerable`, renvoie un objet `IEnumerator` qui permet l'itération.

**2. Méthode `GetEnumerator()`:**

- Lorsque la boucle `foreach` démarre, elle appelle `GetEnumerator()` sur l'objet `myGarage`.
- La méthode `GetEnumerator()` de la classe `Garage` renvoie un énumérateur pour le tableau `cars`, permettant à la boucle d'accéder à ses éléments.

**3. Énumérateur et bouclage:**

- La boucle `foreach` utilise l'énumérateur pour parcourir le tableau `cars` en interne.
- À chaque itération :
  - L'énumérateur récupère le prochain objet `Car` du tableau.
  - La variable de boucle `car` se voit attribuer cet objet `Car`.
  - Le corps de la boucle s'exécute, accédant aux propriétés de l'objet `car` (`Make` et `MaxSpeed`).

**4. Accès au tableau privé:**

- Bien que le tableau `cars` soit privé, la boucle `foreach` n'y accède pas directement.
- Elle interagit avec le tableau via la méthode publique `GetEnumerator()`, qui fournit indirectement un accès aux éléments sans violer l'encapsulation.

**Points clés:**

- La boucle `foreach` s'appuie sur l'interface `IEnumerable` et la méthode `GetEnumerator()` pour accéder aux éléments d'une classe.
- L'encapsulation est maintenue en contrôlant l'accès au tableau par l'interface publique.
- La variable de boucle (`car` dans ce cas) contient chaque élément pendant chaque itération, permettant des opérations sur des éléments individuels.

### `IEnumerator` et `foreach`
En C#, vous ne pouvez pas itérer directement sur un objet `IEnumerator` dans une boucle `foreach` comme vous le pouvez avec une classe qui implémente `IEnumerable`.

Cependant, vous pouvez toujours obtenir la fonctionnalité désirée en itérant manuellement sur l'objet `IEnumerator` à l'aide d'une boucle `while` et en appelant les méthodes `MoveNext()` et les propriétés `Current`. Voici comment vous pouvez modifier votre deuxième méthode `Main()` pour la faire fonctionner :

```csharp
static void Main() {
    IEnumerable myGarage = new Garage();
    IEnumerator iterator = myGarage.GetEnumerator();
 
    while (iterator.MoveNext()) {
        Car car = (Car)iterator.Current;
        Console.WriteLine("Make: {0}, Max Speed: {1}", car.Make, car.MaxSpeed);
    }
}
```

Dans cette version modifiée, nous parcourons manuellement la collection en utilisant `MoveNext()`, et nous récupérons l'élément courant en utilisant la propriété `Current` de l'objet `IEnumerator`. Nous lançons également l'objet `Current` en tant que `Car` car `IEnumerator.Current` est de type `object`.




## Avantages de l'Implémentation de IEnumerable

Implémenter `IEnumerable` et `IEnumerator` permet aux objets de s'intégrer parfaitement aux constructions d'itération de C# telles que `foreach`. En respectant ces interfaces, les types de collection personnalisés peuvent être utilisés de manière cohérente avec les types de collection .NET intégrés.

## Implémentation d'Interface Explicite

Parfois, il est souhaitable de masquer la méthode `GetEnumerator()` au niveau de l'objet. Dans de tels cas, l'implémentation d'interface explicite peut être employée.

```csharp
    // Implémentation explicite de IEnumerable.GetEnumerator().
    IEnumerator IEnumerable.GetEnumerator()
    {
        return cars.GetEnumerator();
    }

```

En implémentant explicitement `IEnumerable.GetEnumerator()`, la méthode `GetEnumerator()` n'est pas accessible au niveau de l'objet, mais elle est toujours disponible pour être utilisée par des constructions telles que `foreach`. Cette encapsulation peut être utile pour certaines considérations de conception.