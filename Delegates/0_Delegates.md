# Mécanisme de rappel en C#

Les applications requièrent souvent qu'un objet puisse communiquer avec l'entité qui l'a créé en utilisant un mécanisme de rappel.

Les mécanismes de rappel sont particulièrement critiques dans les interfaces utilisateur graphiques, car les contrôles (comme un bouton) doivent invoquer des méthodes externes dans les circonstances appropriées (lorsque le bouton est cliqué, lorsque la souris entre dans la surface du bouton, etc.).

Un type de délégué est un objet sûr en termes de typage qui "pointe vers" une méthode ou une liste de méthodes pouvant être invoquées ultérieurement.

Le modèle IAsyncResult()/BeginInvoke() utilisé par les délégués a été remplacé par le modèle asynchrone basé sur les tâches.

En utilisant des rappels, les programmeurs peuvent configurer une fonction pour retourner (appeler en arrière) une autre fonction dans l'application.

Dans les cadres .NET Core, les rappels sont réalisés de manière sûre en termes de typage et orientée objet en utilisant des délégués.

Un délégué est un objet sûr en termes de typage qui pointe vers une autre méthode (ou éventuellement une liste de méthodes) dans l'application, qui peut être invoquée ultérieurement. Spécifiquement, un délégué maintient trois informations importantes :
- L'adresse de la méthode sur laquelle il effectue des appels
- Les paramètres (s'il y en a) de cette méthode
- Le type de retour (s'il y en a) de cette méthode

```csharp
// Exemple d'utilisation de délégués pour implémenter un mécanisme de rappel

using System;

// Déclaration d'un délégué
delegate void CallbackDelegate(string message);

class Program
{
    // Méthode qui utilisera le rappel
    static void PerformCallback(CallbackDelegate callback)
    {
        callback("Executing callback function.");
    }

    static void Main(string[] args)
    {
        // Création d'une instance de délégué avec une méthode cible
        CallbackDelegate callbackDelegate = new CallbackDelegate(DisplayMessage);

        // Utilisation du mécanisme de rappel
        PerformCallback(callbackDelegate);
    }

    // Méthode de rappel
    static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}
```

Dans cet exemple, un délégué `CallbackDelegate` est déclaré. La méthode `PerformCallback` prend en paramètre un délégué et l'exécute en passant un message en tant qu'argument. Dans la méthode `Main`, une instance du délégué est créée avec la méthode `DisplayMessage` comme méthode cible, puis cette instance est passée à `PerformCallback`. Lorsque le délégué est invoqué dans `PerformCallback`, il appelle la méthode `DisplayMessage`, qui affiche le message passé en argument.

```csharp
// Exemple d'utilisation de délégués multicast pour implémenter un mécanisme de rappel avec plusieurs abonnés

using System;

// Déclaration d'un délégué
delegate void CallbackDelegate(string message);

class Program
{
    // Méthode qui utilisera le rappel
    static void PerformCallback(CallbackDelegate callback)
    {
        callback("Executing callback function.");
    }

    static void Main(string[] args)
    {
        // Création d'instances de délégués avec différentes méthodes cibles
        CallbackDelegate callbackDelegate1 = new CallbackDelegate(DisplayMessage1);
        CallbackDelegate callbackDelegate2 = new CallbackDelegate(DisplayMessage2);

        // Combinaison des délégués multicast
        CallbackDelegate combinedDelegate = callbackDelegate1 + callbackDelegate2;

        // Utilisation du mécanisme de rappel avec un délégué multicast
        PerformCallback(combinedDelegate);
    }

    // Méthodes de rappel
    static void DisplayMessage1(string message)
    {
        Console.WriteLine($"Message from DisplayMessage1: {message}");
    }

    static void DisplayMessage2(string message)
    {
        Console.WriteLine($"Message from DisplayMessage2: {message}");
    }
}
```
Dans cet exemple, deux méthodes de rappel `DisplayMessage1` et `DisplayMessage2` sont définies. Deux instances de délégué sont créées, chacune avec une des méthodes de rappel comme méthode cible. Ensuite, ces deux délégués sont combinés en un seul délégué multicast à l'aide de l'opérateur `+`. Lorsque ce délégué multicast est passé à `PerformCallback`, les deux méthodes de rappel sont invoquées dans l'ordre dans lequel elles ont été combinées.

