### Les délégués en C#

Les délégués en C# permettent de passer une fonction en tant que paramètre. Ils sont également utilisés lors de la manipulation de fonctions de rappel (callback functions) et d'événements. Le délégué définit la signature de la méthode.

#### Workflow des délégués

1. Déclarer un délégué
2. Lier des méthodes
3. Appeler le délégué

#### Exemple de code :

```csharp
using System;

namespace CSharpSpeedrun
{
    // Déclaration d'un délégué
    public delegate void DemoDelegate(string msg);

    class Program
    {
        static void Main(string[] args)
        {
            // Lier la méthode Greetings au délégué
            DemoDelegate d = Greetings;

            // Appel du délégué
            d("Bonjour");

            // Utilisation d'une expression lambda pour redéfinir le délégué
            d = (string txt) => Console.WriteLine("Expression lambda : " + txt);
            d("Bonjour");
        }

        // Méthode de salutation
        public static void Greetings(string txt)
        {
            Console.WriteLine("Appel de la méthode Greetings() avec le paramètre : " + txt);
        }
    }
}
```

Ce programme illustre l'utilisation des délégués en C#. Tout d'abord, nous déclarons un délégué `DemoDelegate`, puis nous lui lions la méthode `Greetings`. Ensuite, nous appelons le délégué avec un message. Enfin, nous redéfinissons le délégué en utilisant une expression lambda et appelons à nouveau le délégué avec un autre message.

Le résultat affiché serait :
```
Appel de la méthode Greetings() avec le paramètre : Bonjour
Expression lambda : Bonjour
```

Cela montre comment les délégués peuvent être utilisés pour encapsuler des méthodes et les passer comme paramètres, offrant ainsi une flexibilité et une réutilisation accrues dans le code.