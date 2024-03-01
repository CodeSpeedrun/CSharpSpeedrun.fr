# Les Méthodes Asynchrones avec Plusieurs Attentes

Dans cette section, nous aborderons les méthodes asynchrones en C# avec plusieurs attentes. 

## Méthodes Asynchrones avec Attente Multiple

Considérons une méthode qui exécute plusieurs tâches de manière asynchrone et attend leur achèvement avant de passer à la suite. Voici un exemple de code illustrant cette approche :

```csharp
static async Task ExecuteTasksAsync()
{
    await Task.Run(() => { Thread.Sleep(2000); });
    Console.WriteLine("Première tâche terminée !");
    
    await Task.Run(() => { Thread.Sleep(2000); });
    Console.WriteLine("Deuxième tâche terminée !");
    
    await Task.Run(() => { Thread.Sleep(2000); });
    Console.WriteLine("Troisième tâche terminée !");
}
```

Dans cet exemple, chaque tâche représente une unité de travail, comme l'appel à un service web, la lecture d'une base de données, etc. Le code utilise la méthode `Task.Run()` pour exécuter chaque tâche de manière asynchrone.

## Utilisation de Task.WhenAll()

Une autre approche consiste à exécuter toutes les tâches en parallèle et à attendre leur achèvement simultané. Cela peut être utile lorsque plusieurs opérations indépendantes doivent être effectuées en même temps. Voici comment cela peut être réalisé :

```csharp
static async Task ExecuteTasksAsync()
{
    var task1 = Task.Run(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("Première tâche terminée !");
    });
    
    var task2 = Task.Run(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("Deuxième tâche terminée !");
    });
    
    var task3 = Task.Run(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("Troisième tâche terminée !");
    });

    await Task.WhenAll(task1, task2, task3);
}
```

Dans cet exemple, les trois tâches sont lancées simultanément à l'aide de `Task.Run()` avec des délais différents pour simuler des opérations de longueur variable.

## Utilisation de Task.WhenAny()

Il est également possible de surveiller l'achèvement de l'une des tâches à l'aide de `Task.WhenAny()`. Cette méthode retourne la première tâche qui se termine. Voici comment l'utiliser :

```csharp
static async Task ExecuteTasksAsync()
{
    var task1 = Task.Run(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("Première tâche terminée !");
    });
    
    var task2 = Task.Run(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("Deuxième tâche terminée !");
    });
    
    var task3 = Task.Run(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("Troisième tâche terminée !");
    });

    await Task.WhenAny(task1, task2, task3);
}
```

Dans cet exemple, la méthode `ExecuteTasksAsync()` attend la fin de la première tâche à terminer parmi `task1`, `task2` et `task3`.

Ces méthodes offrent une flexibilité dans la gestion des tâches asynchrones en C# et sont utiles dans de nombreuses situations, notamment lors de l'exécution de multiples opérations en parallèle ou lors de la surveillance de l'achèvement d'une tâche spécifique.