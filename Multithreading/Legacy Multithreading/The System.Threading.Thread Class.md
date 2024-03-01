# La Classe System.Threading.Thread

La classe `Thread` pour la gestion du multithreading

## Principaux Membres Statiques du Type Thread

| Membre Statique | Signification |
|-----------------|---------------|
| ContexteExecution | Cette propriété en lecture seule renvoie des informations pertinentes pour le thread d'exécution logique, incluant la sécurité, les appels, la synchronisation, la localisation et les contextes de transaction. |
| ThreadCourant | Cette propriété en lecture seule renvoie une référence vers le thread actuellement en cours d'exécution. |
| Attendre() | Cette méthode suspend le thread actuel pendant une durée spécifiée. |

## Membres au Niveau d'Instance du Type Thread

| Membre au Niveau d'Instance | Signification |
|------------------------------|---------------|
| EstVivant | Renvoie un booléen indiquant si ce thread a été démarré (et n'a pas encore été terminé ou annulé). |
| EstArrièrePlan | Obtient ou définit une valeur indiquant si ce thread est un "thread en arrière-plan" (plus de détails dans un instant). |
| Nom | Vous permet d'établir un nom de texte convivial pour le thread. |
| Priorité | Obtient ou définit la priorité d'un thread, qui peut être affectée par une valeur de l'énumération `PrioritéDuThread`. |
| ÉtatDuThread | Obtient l'état de ce thread, qui peut être affecté par une valeur de l'énumération `ÉtatDuThread`. |

## Exemple d'Utilisation

```csharp
using System;
using System.Threading;

class Programme {
    static void Main() {
        // Création d'une nouvelle instance de Thread
        Thread monThread = new Thread(MaMéthode);
        
        // Attribution d'un nom au thread
        monThread.Name = "ThreadPrincipal";
        
        // Définition du thread en arrière-plan
        monThread.IsBackground = true;
        
        // Définition de la priorité du thread
        monThread.Priority = ThreadPriority.High;
        
        // Démarrage du thread
        monThread.Start();
        
        // Attente de la fin du thread
        monThread.Join();
    }
    
    // Méthode exécutée par le thread
    static void MaMéthode() {
        Console.WriteLine("Début de l'exécution du thread.");
        
        // Simuler un travail long
        Thread.Sleep(2000);
        
        Console.WriteLine("Fin de l'exécution du thread.");
    }
}
```

Dans cet exemple, un nouveau thread est créé en utilisant la classe `Thread` et une méthode `MaMéthode` est spécifiée comme méthode à exécuter dans ce thread. Le nom du thread est défini comme "ThreadPrincipal". Le thread est défini comme un thread en arrière-plan et sa priorité est définie comme "High". Ensuite, le thread est démarré et le programme principal attend que le thread se termine à l'aide de la méthode `Join()`.

## Explications Supplémentaires

- Le contexte d'exécution (`ExecutionContext`) contient des informations telles que la sécurité, les appels, la synchronisation, la localisation et les contextes de transaction associés à un thread.
- La priorité d'un thread peut être définie à l'aide de l'énumération `ThreadPriority`, qui comprend des valeurs telles que `Lowest`, `BelowNormal`, `Normal`, `AboveNormal` et `Highest`.
- Le statut d'un thread peut être suivi à l'aide de l'énumération `ThreadState`, qui comprend des valeurs telles que `Running`, `Stopped`, `WaitSleepJoin`, `Suspended`, `AbortRequested` et `Aborted`.
- Les threads en arrière-plan sont automatiquement arrêtés lorsque tous les threads avant-plan ont été terminés.