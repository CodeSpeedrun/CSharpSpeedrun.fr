### déclarer une propriété en C# :

Il est courant de nommer la propriété d'après le champ privé mais en utilisant CamelCase. Le snippet de code ci-dessous illustre comment `get { return username; }` retourne et `set { username = value; }` affecte des données au champ privé. Remarquez que le mot-clé `value` représente les données à affecter.

```csharp
using System;

namespace CSharpSpeedrun
{
    class Player
    {
        private string username; // champ
        public string UserName   // propriété
        {
            get { return username; }
            set { username = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player starPlayer = new Player();
            starPlayer.UserName = "Tom";
            Console.WriteLine(starPlayer.UserName);
        }
    }
}
//Tom
```

Dans cet exemple :

- Nous avons une classe `Player` qui contient une propriété `UserName`.
- `UserName` est une propriété publique qui encapsule un champ privé `username`.
- Lorsque vous affectez une valeur à `UserName`, la méthode `set` est appelée, et lorsque vous accédez à `UserName`, la méthode `get` est appelée.
- Dans `set`, `value` est la valeur à affecter au champ `username`.
- Nous créons une instance de `Player`, lui affectons un nom via la propriété `UserName`, puis affichons ce nom en utilisant la propriété.

Ce concept est essentiel pour l'encapsulation des données en C# et est largement utilisé dans le développement orienté objet pour garantir la sécurité et la cohérence des données.