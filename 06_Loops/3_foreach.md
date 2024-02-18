### Qu'est-ce qu'une boucle foreach?
- classe IEnumerable ou
- method return IEnumerab;le

La boucle foreach est l'une des variations de boucle les plus populaires disponibles en C#. Elle est une version simplifiée de la boucle for et est largement utilisée dans de nombreux scénarios de programmation.

La boucle foreach est utilisée pour parcourir les éléments d'une collection ou d'un tableau de manière simple et intuitive, en itérant sur chaque élément de la collection et en exécutant un ensemble d'instructions pour chaque élément.

#### Syntaxe de la boucle foreach:
```csharp
foreach (type variable in collection)
{
    // Instructions à exécuter pour chaque élément de la collection
}
```

Dans cette syntaxe :
- `type` représente le type des éléments dans la collection.
- `variable` est la variable qui contiendra chaque élément de la collection lors de l'itération.
- `collection` est la collection ou le tableau sur lequel itérer.

### Exemple détaillé:

Le code ci-dessus illustre l'utilisation d'une boucle foreach pour parcourir un tableau de chaînes et afficher chaque élément à la console.

```csharp
using System;

namespace CSharpSpeedrun.com
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration et initialisation d'un tableau de chaînes
            string[] myFavFruits = { "Pomme", "Raisin", "Banane" };

            // Utilisation de la boucle foreach pour parcourir le tableau et afficher chaque élément
            foreach (string fruit in myFavFruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
```

**Résultat:**
```
Pomme
Raisin
Banane
```

Dans cet exemple:
- Nous déclarons et initialisons un tableau de chaînes `myFavFruits` contenant quelques noms de fruits.
- Ensuite, nous utilisons la boucle foreach pour itérer sur chaque élément (`fruit`) dans le tableau `myFavFruits`.
- À chaque itération, le nom du fruit actuel est affiché à la console à l'aide de `Console.WriteLine()`.
- Le résultat affiché à la console sera les noms des fruits, chacun sur une ligne différente.