### Énumération (Enum)

Les énumérations (`enum` en anglais) permettent de définir un type de données avec un ensemble de constantes nommées. Chaque constante a une valeur entière associée.

#### Syntaxe

```csharp
enum NomDeLEnumeration
{
    Constante1,
    Constante2,
    // ...
}
```

#### Exemple

```csharp
using System;

namespace CSharpSpeedrun 
{
    class Program
    {
        enum Days
        {
            Lundi,      //0
            Mardi,      //1
            Mercredi,   //2
            Jeudi = 17,
            Vendredi,   //18
            Samedi,     //19
            Dimanche    //20
        }

        static void Main(string[] args)
        {
            Days monJourPrefere = Days.Samedi;

            //(int)monJourPrefere
            Console.WriteLine((int)monJourPrefere);
        }
    }
}
```

Dans cet exemple, nous avons défini une énumération `Days` avec sept constantes. Les jours de la semaine sont attribués automatiquement à des valeurs entières croissantes à partir de zéro, à moins qu'une valeur explicite ne soit donnée. Par exemple, `Lundi` est associé à 0, `Mardi` à 1, et ainsi de suite. Cependant, `Jeudi` est spécifiquement défini comme ayant la valeur 17, donc `Vendredi` est associé à 18, et ainsi de suite jusqu'à `Dimanche` qui est associé à 20.

Dans la méthode `Main`, nous avons créé une variable `monJourPrefere` de type `Days` et l'avons initialisée avec la valeur `Samedi`. Ensuite, nous avons affiché la valeur entière de cette énumération en utilisant le cast `(int)monJourPrefere`. Cela produira une sortie de `19`, car `Samedi` est associé à la valeur 19 dans l'énumération.

Les énumérations sont utiles pour rendre le code plus lisible et maintenable, car elles permettent de définir des ensembles de constantes nommées. Elles sont souvent utilisées pour représenter des ensembles finis de valeurs, tels que les jours de la semaine, les mois de l'année, etc.