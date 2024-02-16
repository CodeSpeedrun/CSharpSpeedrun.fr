## Les alias .NET

Les applications C# s'exécutent sur le framework .NET. Il est possible d'utiliser les alias de type de données .NET au lieu des types de données C#, et la sortie sera identique.

```csharp
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 45643;
            System.Int32 mySpecialInt = 45643;

            Console.WriteLine(myInt);
            Console.WriteLine(mySpecialInt);
        }
    }
}
/* 
45643
45643 
*/
```

### Dans ce code :

- `using System;` : La directive `using` permet d'inclure l'espace de noms `System`, qui contient les définitions fondamentales pour le développement d'applications C#.

- `int myInt = 45643;` : Déclare une variable `myInt` de type `int` avec une valeur de 45643.

- `System.Int32 mySpecialInt = 45643;` : Déclare une variable `mySpecialInt` de type `Int32` (alias .NET pour `int`) avec une valeur de 45643.

- `Console.WriteLine(myInt);` : Affiche la valeur de `myInt` sur la console.

- `Console.WriteLine(mySpecialInt);` : Affiche la valeur de `mySpecialInt` sur la console.

En utilisant `System.Int32` plutôt que `int`, le programme utilise l'alias .NET pour le type de données `int`. Cela n'affecte pas la sortie du programme, mais cela montre qu'ils sont interchangeables.