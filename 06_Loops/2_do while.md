### Qu'est-ce qu'une boucle do-while ?

Une boucle do-while est une variante de la boucle while avec une différence clé. La boucle while est exécutée au moins une fois même si l'expression conditionnelle est fausse. Elle commence toujours avec le mot-clé do.

```csharp
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            do
            {
                Console.WriteLine("Bonjour le monde");
                counter++;

                if (counter > 3)
                {
                    break;
                }

            } while (true);
        }
    }
}
```

#### Explication du code :
- Dans ce code, une boucle do-while est utilisée pour afficher "Bonjour le monde" à l'écran.
- La variable `counter` est initialement définie à 1.
- La boucle do-while s'exécute au moins une fois, ce qui signifie que "Bonjour le monde" sera affiché même si la condition est fausse.
- À chaque itération, la valeur de `counter` est incrémentée.
- La boucle se terminera si la valeur de `counter` dépasse 3 à l'aide de l'instruction `break`.