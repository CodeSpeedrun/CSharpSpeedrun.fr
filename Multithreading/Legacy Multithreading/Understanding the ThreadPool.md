# Compréhension du Pool de Threads

Lorsqu'il s'agit d'efficacité, il y a un coût associé à la création d'un nouveau thread. Pour optimiser les performances, le pool de threads conserve les threads déjà créés (mais inactifs) jusqu'à ce qu'ils soient nécessaires.

Le pool de threads offre différentes méthodes, dont voici deux exemples :

```csharp
public static class PoolDeThreads
{
    ...
    public static bool EnqueueTacheUtilisateur(Action<object> callBack);
    public static bool EnqueueTacheUtilisateur(Action<object> callBack, object state);
}
```

Pour illustrer son utilisation, voici un exemple de code :

```csharp
using System;
using System.Threading;
using MonApplicationThreadPool;

Console.WriteLine("***** Exploration du Pool de Threads de .NET Core *****\n");
Console.WriteLine("Le thread principal a démarré. ID du thread = {0}", Thread.CurrentThread.ManagedThreadId);
Imprimante imprimante = new Imprimante();
Action<object> tache = new Action<object>(ImprimerLesNombres);

// Mettre en file la méthode dix fois.
for (int i = 0; i < 10; i++)
{
    PoolDeThreads.EnqueueTacheUtilisateur(tache, imprimante);
}

Console.WriteLine("Toutes les tâches ont été mises en file d'attente");
Console.ReadLine();

static void ImprimerLesNombres(object etat)
{
    Imprimante tache = (Imprimante)etat;
    tache.ImprimerNombres();
}
```

L'utilisation du pool de threads présente plusieurs avantages, notamment :

- Il gère efficacement les threads en minimisant le nombre de threads à créer, démarrer et arrêter.
- En utilisant le pool de threads, vous pouvez vous concentrer sur le problème métier plutôt que sur l'infrastructure de threading de l'application.

Cependant, il est préférable d'utiliser une gestion manuelle des threads dans certains cas, par exemple :

- Si vous avez besoin de threads foreground ou devez définir la priorité du thread. Les threads du pool sont toujours des threads background avec une priorité par défaut (ThreadPriority.Normal).
- Si vous avez besoin d'un thread avec une identité fixe pour l'abandonner, le suspendre ou le découvrir par son nom.