# La programmation multithread en C#

La programmation multithread est essentielle pour exploiter pleinement les capacités des processeurs modernes et améliorer les performances des applications. Dans le cadre de .NET Core, en plus du namespace System.Threading qui existe depuis la version 1.0, trois techniques plus récentes sont disponibles pour les développeurs C# : la Task Parallel Library (TPL), Parallel LINQ (PLINQ) et les mots-clés asynchrones intrinsèques (async et await) introduits à partir de C# 6.

## Utilisation du namespace System.Threading

Bien que de nombreuses applications .NET Core puissent fonctionner efficacement sur un seul thread, il est courant qu'un thread principal, créé par le runtime lors de l'exécution du point d'entrée de l'application, génère des threads secondaires pour exécuter des tâches supplémentaires.

### Exemple de récupération du thread en cours d'exécution

```csharp
static void ExtraireThreadActuel()
{
    // Obtient le thread actuellement
    // en cours d'exécution de cette méthode.
    Thread threadCourant = Thread.CurrentThread;
}
```

### Exemple d'extraction du domaine d'application hébergeant le thread actuel

```csharp
static void ExtraireDomaineApplicationDuThread()
{
    // Obtient le domaine d'application hébergeant
    // le thread actuel.
    AppDomain domaineApp = Thread.GetDomain();
}
```

### Exemple d'extraction du contexte d'exécution du thread actuel

```csharp
static void ExtraireContexteExecutionThreadActuel()
{
    // Obtient le contexte d'exécution sous lequel
    // le thread actuel fonctionne.
    ExecutionContext contexte =
        Thread.CurrentThread.ExecutionContext;
}
```

Chaque méthode ci-dessus démontre une manière différente de récupérer des informations sur le thread en cours d'exécution.

## Bibliothèque de parallélisme des tâches (TPL)

La TPL fournit un moyen puissant de paralléliser des tâches. Elle est basée sur le concept de tâches, qui sont des unités de travail asynchrones.

## Parallel LINQ (PLINQ)

PLINQ étend LINQ pour permettre l'exécution parallèle de requêtes LINQ sur des sources de données.

## Mots-clés asynchrones (async/await)

Les mots-clés async et await simplifient la programmation asynchrone en permettant l'écriture de code asynchrone de manière synchrone.

Ces techniques offrent aux développeurs C# des moyens efficaces pour exploiter la puissance du multithreading tout en simplifiant le processus de développement et en améliorant la maintenabilité du code.