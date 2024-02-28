### Qu'est-ce qu'une méthode d'extension?

Les méthodes d'extension sont simplement des méthodes supplémentaires injectées dans la classe originale sans la modifier ni la recompiler.

#### Explication du Code
Le code fourni présente une méthode d'extension qui permet de déterminer si un entier est pair ou non.

```csharp
using System;

namespace CSharpSpeedrun
{
    public static class MethodExtension
    {
        public static bool IsEvenNumber(this int i)
        {
            if(i % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 12;
            bool result = myNum.IsEvenNumber();
            Console.WriteLine(result);
        }
    }
}
```

Dans cet exemple, une méthode d'extension appelée `IsEvenNumber` est définie pour le type `int`. La méthode prend un entier en tant que paramètre (`this int i`) et renvoie `true` si cet entier est pair, sinon elle renvoie `false`. La méthode est définie dans une classe statique `MethodExtension` et est marquée avec le mot-clé `this`, indiquant qu'elle est une méthode d'extension pour le type `int`.

Dans la méthode `Main`, un entier `myNum` est déclaré et initialisé avec la valeur `12`. Ensuite, la méthode d'extension `IsEvenNumber` est appelée sur cet entier, et le résultat est affiché dans la console.

#### Utilisation des méthodes d'extension
Les méthodes d'extension sont utiles pour ajouter des fonctionnalités à des types existants sans avoir à modifier le code source de ces types. Elles sont largement utilisées dans les bibliothèques et frameworks pour étendre les fonctionnalités des types de base.

Par exemple, dans une application de traitement de données, vous pourriez avoir besoin d'ajouter des méthodes supplémentaires pour manipuler des tableaux ou des listes. Plutôt que de créer une nouvelle classe avec ces méthodes, vous pouvez utiliser des méthodes d'extension pour ajouter ces fonctionnalités aux types de base comme `Array` ou `List`.

#### Limitations des méthodes d'extension
Bien que les méthodes d'extension offrent une grande flexibilité, il y a certaines limitations à prendre en compte :

1. **Accessibilité aux membres privés**: Les méthodes d'extension ne peuvent pas accéder aux membres privés de la classe étendue, car elles sont statiques et ne font pas partie de la classe.

2. **Ambiguïté de méthode**: Si une classe possède une méthode avec la même signature que la méthode d'extension, cela peut entraîner une ambiguïté lors de l'appel de la méthode.

3. **Portée des méthodes d'extension**: Les méthodes d'extension sont accessibles uniquement lorsque l'espace de noms qui les contient est importé dans le fichier source à l'aide de la directive `using`.