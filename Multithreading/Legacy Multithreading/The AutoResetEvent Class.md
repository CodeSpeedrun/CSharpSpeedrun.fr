# La Classe AutoResetEvent

Une manière simple et sûre de permettre à un thread d'attendre qu'un autre ait terminé est d'utiliser la classe AutoResetEvent.

```csharp
AutoResetEvent _attendre = new AutoResetEvent(false);
Console.WriteLine("***** Exemple d'addition avec des objets Thread *****");
Console.WriteLine("ID du thread principal : {0}", Thread.CurrentThread.ManagedThreadId);
ParametresAddition parametres = new ParametresAddition(15, 25);
Thread threadAddition = new Thread(new ParameterizedThreadStart(EffectuerAddition));
threadAddition.Start(parametres);
// Attendre ici jusqu'à ce que vous soyez notifié !
_attendre.WaitOne();
Console.WriteLine("Le thread d'addition a terminé !");
```

La méthode `EffectuerAddition` est appelée dans un thread séparé pour effectuer une opération d'addition.

```csharp
void EffectuerAddition(object data)
{
    if (data is ParametresAddition parametres)
    {
        Console.WriteLine("ID du thread d'addition : {0}", Thread.CurrentThread.ManagedThreadId);
        Console.WriteLine("{0} + {1} égale {2}", parametres.Nombre1, parametres.Nombre2, parametres.Nombre1 + parametres.Nombre2);
        // Indiquer au thread principal que nous avons terminé.
        _attendre.Set();
    }
}
```

### Explications Détaillées :

- **Création de l'AutoResetEvent :** Un objet `_attendre` de la classe AutoResetEvent est instancié avec une valeur booléenne initiale de `false`, indiquant que l'événement n'est pas encore signalé.

- **Démarrage du Thread :** Un nouveau thread est créé pour exécuter la méthode `EffectuerAddition`. Ce thread prend en paramètre une instance de la classe `ParametresAddition` contenant les valeurs à additionner.

- **Attente du Signal :** Après le démarrage du thread, le thread principal attend jusqu'à ce qu'il soit notifié par l'AutoResetEvent `_attendre`. La méthode `WaitOne()` bloque le thread en attendant le signal.

- **Exécution de la Méthode `EffectuerAddition` :** Dans le thread nouvellement créé, la méthode `EffectuerAddition` est exécutée. Elle récupère les paramètres d'addition de l'objet `data` et effectue l'opération d'addition.

- **Notification de la Fin :** Une fois l'addition terminée, la méthode `EffectuerAddition` signale au thread principal que son travail est terminé en appelant la méthode `Set()` sur l'AutoResetEvent `_attendre`. Cela débloque le thread principal qui attendait.

En utilisant l'AutoResetEvent de cette manière, vous pouvez synchroniser efficacement l'exécution de threads dans votre application C#.