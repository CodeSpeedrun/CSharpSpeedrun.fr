# Appels asynchrones avec `async/await`

Lorsque vous utilisez les mots-clés `async` et `await`, le compilateur génère une quantité importante de code de gestion des threads pour vous, en utilisant de nombreux membres des espaces de noms `System.Threading` et `System.Threading.Tasks`.

Le modificateur async permet au runtime .NET Core de créer un nouveau thread d'exécution pour gérer la tâche en cours.

Lorsque vous appelez une méthode asynchrone, le mot-clé await met automatiquement en pause le thread actuel jusqu'à ce que la tâche soit terminée, libérant ainsi le thread appelant pour qu'il puisse continuer son travail.

```csharp
using System;
using System.Threading;
using System.Threading.Tasks;

Console.WriteLine("Exploration des appels asynchrones ===>");
Console.WriteLine(EffectuerTravail());
Console.WriteLine("Terminé");
Console.ReadLine();

static string EffectuerTravail()
{
    Thread.Sleep(5_000);
    return "Travail terminé !";
}

static async Task<string> EffectuerTravailAsync()
{
    return await Task.Run(() =>
    {
        Thread.Sleep(3_000);
        return "Travail asynchrone terminé !";
    });
}
```

Remarquez le mot-clé await avant le nom de la méthode appelée de manière asynchrone. Il est crucial de noter que si vous utilisez le modificateur async sans avoir au moins un appel de méthode centrée sur await à l'intérieur, vous obtiendrez un avertissement du compilateur indiquant que votre méthode est synchronisée.

L'implémentation de EffectuerTravailAsync() retourne directement un objet Task<T>, qui est la valeur de retour de Task.Run(). La méthode Run() prend un délégué Func<> ou Action<>. Dans cet exemple, nous utilisons une expression lambda pour simplifier la création de la tâche asynchrone. Fondamentalement, la méthode EffectuerTravailAsync() dit : "Quand vous m'appelez, je vais exécuter une nouvelle tâche. Cette tâche mettra en pause le thread appelant pendant trois secondes, puis retournera une chaîne indiquant que le travail asynchrone est terminé."

En utilisant async/await, vous pouvez rendre votre code plus efficace en permettant au runtime .NET de gérer les threads de manière plus optimale, ce qui est particulièrement utile dans les applications nécessitant une réponse rapide aux événements.