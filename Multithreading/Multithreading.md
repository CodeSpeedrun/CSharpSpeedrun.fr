## Qu'est-ce que le Multithreading?

Une application multithread signifie qu'elle exécute plusieurs threads en parallèle pour effectuer plusieurs tâches. Par exemple, le système d'exploitation Android peut ouvrir plusieurs applications telles que le navigateur, le lecteur de musique et bien d'autres. Chaque application est gérée par des threads distincts.

```csharp
using System;
using System.Threading;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(app1));
            Thread t2 = new Thread(new ThreadStart(app2));
            t1.Start();
            t2.Start();
        }
        static void app1()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(50);
            }
            Console.WriteLine("app1 ended");
            Console.WriteLine();
        }
        static void app2()
        {
            for (int i = 10; i <= 12; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("app2 ended");
        }
    }
}
/*
1
10
11
12
app2 ended
2
3
app1 ended
*/
```

Dans les applications modernes ASP.NET Core, le multithreading est toujours utilisé, mais il est souvent abstrait ou géré par des constructions de plus haut niveau telles que async/await, la bibliothèque de tâches parallèles (TPL), ou des abstractions de niveau supérieur fournies par le framework.

Voici comment le multithreading est généralement géré dans les applications ASP.NET Core :

1. **Async/Await** :
   - Async/await fournit un mécanisme plus moderne et plus facile à utiliser pour gérer les opérations asynchrones.
   - Il vous permet d'écrire du code asynchrone qui ressemble à du code synchrone, ce qui facilite sa compréhension et sa maintenance.
   - C'est l'approche recommandée pour gérer les opérations liées aux entrées/sorties (I/O-bound) dans les applications ASP.NET Core.

2. **Bibliothèque de Tâches Parallèles (TPL)** :
   - La TPL fournit un ensemble de types et d'API pour écrire du code parallèle et concurrent.
   - Elle inclut des constructions telles que `Task` et `Parallel.ForEach` qui facilitent le travail avec le multithreading et la parallélisme.
   - La TPL est largement utilisée dans les applications ASP.NET Core pour paralléliser les opérations liées au processeur (CPU-bound).

3. **Abstractions de Niveau Supérieur** :
   - ASP.NET Core fournit des abstractions de niveau supérieur pour gérer la concurrence, telles que `HttpClient`, qui est optimisé pour les opérations d'E/S asynchrones.
   - Des bibliothèques telles qu'Entity Framework Core prennent également en charge les opérations de base de données asynchrones, ce qui vous permet d'effectuer des requêtes de base de données de manière asynchrone sans bloquer le thread principal.

Bien que l'approche de bas niveau des threads présentée dans votre code soit toujours techniquement valide, elle est moins courante dans les applications modernes ASP.NET Core en raison de la disponibilité de constructions de concurrence plus modernes et de niveau supérieur offrant de meilleures performances, une meilleure évolutivité et une meilleure maintenabilité.