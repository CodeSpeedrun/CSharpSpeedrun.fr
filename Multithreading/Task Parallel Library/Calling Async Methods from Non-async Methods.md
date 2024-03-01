# Utilisation de Méthodes Asynchrones dans des Méthodes Non-Asynchrones

Dans le langage C#, il existe plusieurs méthodes pour appeler des méthodes asynchrones à partir de méthodes non-asynchrones. La première approche consiste à utiliser la propriété `Result` sur l'objet `Task<T>` ou à attendre les méthodes `Wait` sur `Task/Task<T>`.

Lorsqu'une méthode asynchrone retourne une valeur, elle doit renvoyer un objet de type `Task<T>`, tandis qu'une méthode asynchrone sans valeur de retour renvoie un objet de type `Task`. En cas d'échec de la méthode, une `AggregateException` est renvoyée.

Une autre approche consiste à utiliser la méthode `GetAwaiter().GetResult()`, qui permet d'obtenir le même résultat que le mot-clé `await` dans une méthode asynchrone et de propager les exceptions de la même manière que `async/await`. Il est cependant important de noter que ces méthodes sont marquées dans la documentation comme "non destinées à un usage externe".

### Exemple d'utilisation de la méthode `EffectuerTravailAsync()` :

```csharp
// Appel de la méthode EffectuerTravailAsync() avec utilisation de la propriété Result
Console.WriteLine(ObtenirResultatTravailAsync().Result);

// Appel de la méthode EffectuerTravailAsync() en utilisant GetAwaiter().GetResult()
Console.WriteLine(ObtenirResultatTravailAsync().GetAwaiter().GetResult());
```

Ces méthodes permettent de bloquer l'exécution jusqu'à ce qu'une méthode asynchrone renvoie une valeur de type `void`. Pour cela, il suffit d'appeler la méthode `Wait()` sur l'objet `Task`.

### Exemple d'utilisation de la méthode `EffectuerTravailSansRetourAsync()` :

```csharp
// Appel de la méthode EffectuerTravailSansRetourAsync() en attendant sa complétion
AttendreCompletionTravailSansRetourAsync().Wait();
```

Il est essentiel de comprendre que bien que ces méthodes fournissent un moyen de synchroniser l'exécution avec des méthodes asynchrones dans des contextes non asynchrones, elles doivent être utilisées avec précaution, car elles peuvent entraîner des problèmes de blocage dans les applications à interface utilisateur et dans d'autres scénarios.