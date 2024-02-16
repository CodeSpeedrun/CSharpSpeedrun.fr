## Qu'est-ce que Regex (Expression Régulière) ?

Une expression régulière est un modèle souvent utilisé pour valider du texte. En C#, les classes associées proviennent de l'espace de noms `System.Text.RegularExpressions`.

```csharp
using System;
using System.Text.RegularExpressions;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "Bonjour le monde, bienvenue chaleureuse@au C#SharpSpeedrun";
            string result = Regex.Replace(txt, "[^a-zA-Z0-9_]+", " ");
            Console.Write(result); 
        }
    }
}
/*
Bonjour le monde bienvenue chaleureuse au C SharpSpeedrun
*/
```

Dans ce code :

- `using System;` : Cette instruction indique au compilateur de C# d'inclure l'espace de noms `System`, ce qui donne accès aux fonctionnalités de base du langage.
- `using System.Text.RegularExpressions;` : Cela permet d'utiliser les classes liées aux expressions régulières à l'intérieur du code.
- `string txt = "Bonjour le monde, bienvenue chaleureuse@au C#SharpSpeedrun";` : Définit une chaîne de caractères `txt` contenant un texte à traiter.
- `string result = Regex.Replace(txt, "[^a-zA-Z0-9_]+", " ");` : Utilise la méthode `Replace` de la classe `Regex` pour remplacer tous les caractères qui ne sont pas des lettres, des chiffres ou des soulignés par un espace. Cette expression régulière `[a-zA-Z0-9_]` correspond à toutes les lettres, chiffres et soulignés. Le `^` dans `[^\w]` signifie "pas", donc `[^\w]` correspond à tout sauf des lettres, chiffres ou soulignés.
- `Console.Write(result);` : Affiche le résultat dans la console.

Ce programme illustre comment utiliser les expressions régulières pour nettoyer du texte en remplaçant les caractères non alphanumériques par des espaces.