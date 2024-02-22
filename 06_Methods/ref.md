### Qu'est-ce que le modificateur ref ?

Le modificateur ref est l'abréviation de référence. En utilisant ref, vous passez une référence aux données originales plutôt qu'une copie. Remarquez que le modificateur ref est ajouté à deux endroits. Premièrement, à l'intérieur de la déclaration de méthode `GetSquared(ref myFavNumber);`. Deuxièmement, lors de l'appel de la méthode `static void GetSquared(ref int number)`.

Cette fois, nous obtenons le résultat attendu 49 au lieu de 7.

```csharp
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main()
        {
            int myFavNumber = 7;

            GetSquared(ref myFavNumber);

            Console.WriteLine(myFavNumber);
        }

        static void GetSquared(ref int number)
        {
            number = number * number;
        }
    }
}
```

### Dans ce code :

- `myFavNumber` est une variable contenant la valeur 7.
- `GetSquared` est une méthode qui prend une référence à un entier (`ref int number`) et calcule le carré de cet entier.
- Lorsque `GetSquared` est appelé avec `ref myFavNumber`, il modifie directement la valeur de `myFavNumber` pour être son carré.
- La sortie affiche le résultat 49, le carré de 7, après l'appel de la méthode `GetSquared`.