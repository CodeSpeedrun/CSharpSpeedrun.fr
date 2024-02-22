### La notion du mot-clé `sealed` en C#

Le mot-clé `sealed` bloque l'héritage de la classe. En C#, une erreur sera générée si vous essayez d'hériter d'une classe scellée.

```csharp
using System;

namespace CSharpSpeedrun
{
    sealed class Livre // Parent
    {
        public string Titre = "Sapiens"; 
    }

    class EBook: Livre // Enfant
    {
        public string Format = "Pdf";
    }

    class Program
    {
        static void Main(string[] args)
        {
            EBook monEBook = new EBook();  
            Console.WriteLine(monEBook.Titre + ", format = " + monEBook.Format);
        }
    }
}
```

Dans cet exemple, `Livre` est une classe scellée, ce qui signifie qu'elle ne peut pas être utilisée comme classe parente. La classe `EBook` tente d'hériter de `Livre`, mais une erreur sera générée car `Livre` est scellée.