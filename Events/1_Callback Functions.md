# Les méthodes de rappel

Les méthodes de rappel sont un concept essentiel en programmation C#. Elles permettent à une classe d'appeler une méthode d'une autre classe lorsque certains événements se produisent. Cela est souvent utilisé dans les applications basées sur des événements où des actions doivent être déclenchées en réponse à des événements spécifiques.

## Introduction

Les méthodes de rappel sont largement utilisées dans les applications C# pour implémenter des modèles de conception tels que l'Observateur ou le Gestionnaire d'événements. Elles permettent une communication asynchrone entre les objets et facilitent la conception de systèmes modulaires et extensibles.

## Syntaxe

La syntaxe de base pour définir une méthode de rappel est la suivante :

```csharp
public delegate void CallbackMethod(string message);

public class Notificateur
{
    public event CallbackMethod OnNotification;

    public void TriggerNotification(string message)
    {
        // Vérification si un rappel est associé à l'événement
        if (OnNotification != null)
        {
            // Appel du rappel
            OnNotification(message);
        }
    }
}

public class Consommateur
{
    public void GérerNotification(string message)
    {
        Console.WriteLine("Notification reçue : " + message);
    }
}
```

## Explication

- `CallbackMethod` est un délégué qui définit la signature des méthodes de rappel. Dans cet exemple, il s'agit d'une méthode prenant une chaîne en paramètre et ne renvoyant rien (`void`).
  
- `Notificateur` est une classe qui déclenche des notifications via l'événement `OnNotification`. Cette classe fournit également une méthode `TriggerNotification` pour déclencher l'événement.

- `Consommateur` est une classe qui contient la méthode `GérerNotification`, qui sera appelée lorsqu'une notification est reçue.

## Utilisation

```csharp
public static void Main(string[] args)
{
    Notificateur notificateur = new Notificateur();
    Consommateur consommateur = new Consommateur();

    // Association de la méthode de rappel à l'événement
    notificateur.OnNotification += consommateur.GérerNotification;

    // Déclenchement de la notification
    notificateur.TriggerNotification("Hello, world!");
}
```

Dans cet exemple, une instance de `Notificateur` est créée ainsi qu'une instance de `Consommateur`. Ensuite, la méthode `GérerNotification` de l'instance `Consommateur` est associée à l'événement `OnNotification` de l'instance `Notificateur`. Lorsque la méthode `TriggerNotification` est appelée, l'événement est déclenché, ce qui à son tour appelle la méthode de rappel associée.

## Conclusion

Les méthodes de rappel sont un outil puissant en C# pour implémenter des interactions asynchrones entre les objets. Elles permettent une conception modulaire et extensible des applications, en facilitant la gestion des événements et des actions associées. Maîtriser les méthodes de rappel est donc essentiel pour tout développeur C# souhaitant créer des applications robustes et évolutives.


Bien sûr, voici le code complet incluant les exemples et les explications :

```csharp
using System;

// Déclaration du délégué pour les méthodes de rappel
public delegate void CallbackMethod(string message);

// Classe Notificateur qui déclenche des notifications
public class Notificateur
{
    // Événement pour les notifications
    public event CallbackMethod OnNotification;

    // Méthode pour déclencher une notification
    public void TriggerNotification(string message)
    {
        // Vérification si un rappel est associé à l'événement
        if (OnNotification != null)
        {
            // Appel du rappel
            OnNotification(message);
        }
    }
}

// Classe Consommateur qui gère les notifications
public class Consommateur
{
    // Méthode pour gérer les notifications
    public void GérerNotification(string message)
    {
        Console.WriteLine("Notification reçue : " + message);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Création d'une instance de Notificateur et de Consommateur
        Notificateur notificateur = new Notificateur();
        Consommateur consommateur = new Consommateur();

        // Association de la méthode de rappel à l'événement
        notificateur.OnNotification += consommateur.GérerNotification;

        // Déclenchement de la notification
        notificateur.TriggerNotification("Hello, world!");
    }
}

/* 
Notification reçue : Hello, world!
*/
```

Ce code comprend une classe `Notificateur` qui déclenche des notifications via un événement `OnNotification`, ainsi qu'une classe `Consommateur` qui gère ces notifications en implémentant une méthode `GérerNotification`. Dans la méthode `Main`, une instance de `Notificateur` est créée ainsi qu'une instance de `Consommateur`. Ensuite, la méthode `GérerNotification` de l'instance `Consommateur` est associée à l'événement `OnNotification` de l'instance `Notificateur`. Lorsque la méthode `TriggerNotification` est appelée, l'événement est déclenché, ce qui à son tour appelle la méthode de rappel associée.

Ce modèle permet une communication asynchrone entre les objets, ce qui est utile dans de nombreuses situations de programmation, notamment dans les applications basées sur des événements.

## Alternatives
Oui, il existe plusieurs alternatives et techniques pour implémenter des mécanismes similaires à celui des méthodes de rappel en C#. Voici quelques-unes :

### 1. Utilisation de Lambdas
Au lieu de définir explicitement un délégué pour la méthode de rappel, vous pouvez utiliser des expressions lambda pour définir la méthode à exécuter lors de l'événement.

Exemple :

```csharp
notificateur.OnNotification += (message) => Console.WriteLine("Notification reçue : " + message);
```

### 2. Utilisation de Delegates Prédéfinis
Au lieu de définir un délégué personnalisé, vous pouvez utiliser des délégués prédéfinis tels que `Action<T>` ou `Func<T, TResult>` pour définir la signature de la méthode de rappel.

Exemple :

```csharp
public class Notificateur
{
    public event Action<string> OnNotification;

    public void TriggerNotification(string message)
    {
        if (OnNotification != null)
        {
            OnNotification(message);
        }
    }
}
```

### 3. Utilisation de la Programmation Orientée Événements
Dans les versions plus récentes de C#, vous pouvez utiliser la programmation orientée événements avec les mots-clés `event` et `delegate`. Cela simplifie la syntaxe et rend le code plus lisible.

Exemple :

```csharp
public class Notificateur
{
    public event EventHandler<string> OnNotification;

    public void TriggerNotification(string message)
    {
        OnNotification?.Invoke(this, message);
    }
}
```

### 4. Utilisation de Bibliothèques Externes
Dans des cas plus complexes, vous pouvez utiliser des bibliothèques externes comme Reactive Extensions (Rx) pour une gestion avancée des événements et des abonnements.

Exemple :

```csharp
var subscription = notificateur.OnNotification.Subscribe(message => Console.WriteLine("Notification reçue : " + message));
```

Ces alternatives offrent différentes façons de réaliser la même fonctionnalité avec des avantages spécifiques en termes de lisibilité, performances ou expressivité du code. Le choix dépend souvent du contexte et des besoins spécifiques du projet.


## EventHandler<>
Voici comment vous pourriez implémenter la version utilisant la Programmation Orientée Événements en C# :

```csharp
using System;

public class Notificateur
{
    // Déclaration de l'événement avec le délégué EventHandler<T>
    public event EventHandler<string> OnNotification;

    // Méthode pour déclencher une notification
    public void TriggerNotification(string message)
    {
        // Vérification si un rappel est associé à l'événement
        OnNotification?.Invoke(this, message);
    }
}

public class Consommateur
{
    // Méthode pour gérer les notifications
    public void GérerNotification(object sender, string message)
    {
        Console.WriteLine("Notification reçue : " + message);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Création d'une instance de Notificateur et de Consommateur
        Notificateur notificateur = new Notificateur();
        Consommateur consommateur = new Consommateur();

        // Association de la méthode de rappel à l'événement
        notificateur.OnNotification += consommateur.GérerNotification;

        // Déclenchement de la notification
        notificateur.TriggerNotification("Hello, world!");
    }
}
```

Dans cette implémentation :

- La classe `Notificateur` utilise un événement de type `EventHandler<T>` où `T` est le type du paramètre à passer avec l'événement.
- La méthode `TriggerNotification` déclenche l'événement en appelant `OnNotification?.Invoke(this, message)`. L'opérateur de nullabilité `?.` est utilisé pour éviter une exception si aucun abonnement n'est présent.
- La classe `Consommateur` contient une méthode `GérerNotification` qui correspond à la signature du délégué `EventHandler<T>`. Cette méthode est appelée lors de la notification.

Cette approche simplifie la syntaxe en utilisant des délégués prédéfinis et des événements, rendant le code plus lisible et plus conforme aux conventions de la Programmation Orientée Événements en C#.