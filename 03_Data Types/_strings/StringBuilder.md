### Qu'est-ce que StringBuilder ?

Le type de données string est conçu pour être immuable. En d'autres termes, une fois qu'il est créé, il ne peut pas être modifié. Lorsqu'une variable de type string se voit attribuer une nouvelle valeur, le compilateur crée un nouvel objet string en mémoire. Comme vous pouvez le deviner, attribuer constamment de nouvelles valeurs aux variables nuit aux performances.

Le StringBuilder a été introduit pour résoudre ce problème. Il ne crée pas de nouveaux objets string, mais il étend constamment la mémoire pour contenir la chaîne nouvellement modifiée.

Le code ci-dessous est un exemple d'utilisation de StringBuilder :

```csharp
using System;
using System.Text;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Bonjour ");
            sb.AppendLine("le monde !");
            sb.AppendLine("Bienvenue dans CSharpSpeedrun");
            Console.WriteLine(sb);
        }
    }  
}
/*
Bonjour le monde !
Bienvenue dans CSharp Speedrun
*/
```

#### Explication du code :

- Nous commençons par inclure l'espace de noms `System.Text`, qui contient la définition de la classe StringBuilder.
- Ensuite, nous créons une instance de StringBuilder appelée `sb`.
- Nous utilisons la méthode `Append()` pour ajouter du texte à la fin de la chaîne.
- La méthode `AppendLine()` ajoute également une nouvelle ligne à la fin de la chaîne.
- Enfin, nous utilisons `Console.WriteLine()` pour afficher le contenu de StringBuilder.

Cet exemple illustre comment StringBuilder peut être utilisé pour construire efficacement des chaînes de caractères, en évitant la surcharge de création d'objets string à chaque modification.