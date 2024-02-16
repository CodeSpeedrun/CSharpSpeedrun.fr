### Comment itérer une Queue<T>?

La classe Queue<T> implémente également l'interface IEnumerable. Par conséquent, nous pouvons utiliser la boucle foreach pour itérer son contenu.

```csharp
using System;
using System.Collections.Generic;

namespace CSharpSpeedrun 
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> clients = new Queue<string>();

            clients.Enqueue("Mark");
            clients.Enqueue("Pooja");
            clients.Enqueue("Warren");

            foreach (string client in clients)
            {
                Console.WriteLine(client);
            }
        }
    }
}
/*
Mark
Pooja
Warren
*/
```
 