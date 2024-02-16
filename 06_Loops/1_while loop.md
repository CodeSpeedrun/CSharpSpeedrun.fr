### Comment arrêter une boucle while en C# ?
Il existe plusieurs façons d'arrêter une boucle while. Au lieu d'utiliser une expression booléenne, le mot-clé break peut être utilisé.

```csharp
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true) // Utilisation d'une boucle while infinie
            {
                Console.WriteLine("Bonjour le monde !");
                i++;

                if (i >= 3)
                {
                    break; // Sortie de la boucle lorsqu'on atteint la condition
                }
            }
        }
    }
}
```

### Explication :

La boucle `while (true)` crée une boucle infinie, car la condition `true` est toujours vraie. Ainsi, le programme continue à s'exécuter jusqu'à ce qu'il rencontre une instruction de sortie, dans ce cas, le `break`. Une fois que la valeur de `i` atteint 3, la condition `if (i >= 3)` devient vraie et le `break` est exécuté, ce qui sort de la boucle `while`.

Dans cet exemple, la boucle `while` est utilisée pour afficher "Bonjour le monde !" à la console trois fois, puis la boucle est interrompue à l'aide du mot-clé `break`.