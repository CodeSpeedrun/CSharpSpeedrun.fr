# L'espace de noms System.Threading

## Principaux Types de l'espace de noms System.Threading
| Type                | Signification dans le contexte |
|---------------------|--------------------------------|
| Interlocked         | Fournit des opérations atomiques pour les variables partagées entre plusieurs threads. |
| Monitor             | Assure la synchronisation des objets de threading en utilisant des verrous et des signaux d'attente. Le mot-clé lock de C# utilise un objet Monitor sous-jacent. |
| Mutex               | Cette primitive de synchronisation peut être utilisée pour synchroniser entre les limites de domaine d'application. |
| ParameterizedThreadStart | Permet à un thread d'appeler des méthodes avec un nombre variable d'arguments. |
| Semaphore           | Limite le nombre de threads pouvant accéder à une ressource simultanément. |
| Thread              | Représente un thread qui s'exécute dans le Runtime .NET Core. Permet de créer des threads supplémentaires dans le AppDomain d'origine. |
| ThreadPool          | Permet d'interagir avec le pool de threads maintenu par le Runtime .NET Core dans un processus donné. |

```

## Interlocked
Interlocked offre des opérations atomiques pour les variables partagées entre plusieurs threads, garantissant l'intégrité des données. Voici un exemple :

```csharp
int compteurPartage = 0;
Interlocked.Increment(ref compteurPartage);
```

Dans cet exemple, `Interlocked.Increment` garantit une incrémentation sûre et atomique de `compteurPartage`.

## Monitor
Le Monitor assure la synchronisation des objets de threading en utilisant des verrous et des signaux d'attente. Exemple d'utilisation avec `lock` :

```csharp
object objetVerrou = new object();

lock (objetVerrou)
{
    // Code synchronisé ici
}
```

Le bloc de code à l'intérieur de `lock` est synchronisé, empêchant plusieurs threads d'y accéder simultanément.

## Mutex
Le Mutex permet la synchronisation entre les limites de domaine d'application. Exemple d'utilisation :

```csharp
using System.Threading;

Mutex mutex = new Mutex();

if (mutex.WaitOne())
{
    try
    {
        // Code pour accéder à la ressource partagée
    }
    finally
    {
        mutex.ReleaseMutex();
    }
}
```

Le Mutex garantit l'exclusivité d'accès à une ressource partagée entre plusieurs threads.

## ParameterizedThreadStart
ParameterizedThreadStart permet à un thread d'appeler des méthodes avec un nombre variable d'arguments. Exemple :

```csharp
void MethodeThread(object parametre)
{
    // Code exécuté par le thread
}

ParameterizedThreadStart demarrageThread = new ParameterizedThreadStart(MethodeThread);
Thread thread = new Thread(demarrageThread);

thread.Start(parametre);
```

`MethodeThread` est la méthode exécutée par le thread, avec `parametre` comme argument.

## Semaphore
Le Semaphore limite l'accès à une ressource partagée par plusieurs threads. Exemple :

```csharp
Semaphore semaphore = new Semaphore(3, 3); // Autorise jusqu'à 3 threads simultanés

semaphore.WaitOne();

try
{
    // Code pour accéder à la ressource partagée
}
finally
{
    semaphore.Release();
}
```

Le Semaphore garantit qu'un nombre limité de threads peuvent accéder simultanément à une ressource.

## ThreadPool
Le ThreadPool permet d'exécuter des tâches de manière asynchrone dans un pool de threads. Exemple :

```csharp
ThreadPool.QueueUserWorkItem(etat =>
{
    // Code de la tâche asynchrone
});
```

`QueueUserWorkItem` ajoute une tâche au pool de threads pour une exécution asynchrone lorsque des ressources sont disponibles.