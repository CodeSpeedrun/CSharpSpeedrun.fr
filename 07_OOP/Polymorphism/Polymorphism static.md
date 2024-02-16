### Comment implémenter le polymorphisme statique?

Le polymorphisme statique est une technique de la programmation orientée objet dans laquelle une méthode peut avoir plusieurs formes mais la résolution se fait au moment de la compilation, contrairement au polymorphisme dynamique où la résolution se fait au moment de l'exécution.

#### Qu'est-ce que le polymorphisme statique?

Le polymorphisme statique, également connu sous le nom de surcharge de méthode, permet à une classe d'avoir plusieurs méthodes avec le même nom mais avec différents paramètres. La méthode appropriée est sélectionnée par le compilateur en fonction des types de paramètres passés lors de l'appel de la méthode.

#### Exemple de code:

```csharp
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static public int AdditionCalculator(int number1, int number2)
            => number1 + number2;

        static public double AdditionCalculator(double number1, double number2)
            => number1 + number2;

        static void Main(string[] args)
        {
            Console.WriteLine(AdditionCalculator(1, 4));
        }
    }
}
```

Dans cet exemple, nous avons deux méthodes `AdditionCalculator` avec le même nom mais des types de paramètres différents. Lorsque nous appelons `AdditionCalculator(1, 4)`, le compilateur sélectionne automatiquement la méthode prenant deux entiers comme paramètres. Cela retourne 5, car 1 + 4 est égal à 5.

Ce code illustre le polymorphisme statique en action. Le compilateur choisit la méthode appropriée en fonction des types de paramètres fournis lors de l'appel de la méthode.