### Comment itérer à l'aide de la boucle foreach en C#?

Étant donné que la classe de collection List implémente l'interface IEnumerable, nous sommes autorisés à utiliser la boucle foreach pour itérer sur son contenu.

```csharp
using System;
using System.Collections.Generic;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> jeuxPopulaires = new List<string>()
            {
                "baseball",
                "Scrabble"
            };

            List<string> mesJeuxPref = new List<string>();
            mesJeuxPref.Add("golf");
            mesJeuxPref.Add("chess");
            mesJeuxPref.Add("poker");

            mesJeuxPref.AddRange(jeuxPopulaires);

            foreach (string jeu in mesJeuxPref)
            {
                Console.WriteLine(jeu);
            }
        }
    }
}
```