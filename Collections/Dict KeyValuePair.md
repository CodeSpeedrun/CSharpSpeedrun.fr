```markdown
### Comment utiliser la structure KeyValuePair ?
La structure KeyValuePair offre davantage de flexibilité lors de l'itération d'un dictionnaire car elle fournit de nombreuses propriétés utiles.

```csharp
using System;
using System.Collections.Generic;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> stockTracker = new Dictionary<string, int>();

            stockTracker.Add("shampooing", 21);
            stockTracker.Add("stylo", 65);

            foreach (KeyValuePair<string, int> item in stockTracker)
            {
                Console.WriteLine(item.Key + " => " + item.Value + " en stock.");
            }
        }
    }
}
//shampooing => 21 en stock.
//stylo => 65 en stock.
```
```