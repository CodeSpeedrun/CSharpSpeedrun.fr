# Utilisation d'un Discard autonome

Dans cette section, nous aborderons l'utilisation d'un jetable autonome en C#. Les jetables sont une fonctionnalité introduite dans C# 7.0 permettant de gérer proprement les valeurs non utilisées sans leur attribuer de nom explicite.

## Création d'un jetable avec un minuteur

```csharp
var jetable = new Timer(
    callbackMethode, // Le délégué TimerCallback.
    null, // Aucune donnée à transmettre à la méthode appelée.
    0, // Délai avant le démarrage (en millisecondes).
    2000); // Intervalle entre les appels (en millisecondes).
```

Dans cet exemple, nous créons un jetable avec un minuteur. Voici une explication détaillée des paramètres utilisés :

- `callbackMethode`: Il s'agit du délégué `TimerCallback` pointant vers la méthode à appeler à chaque intervalle de temps spécifié.
- `null`: Aucune donnée n'est transmise à la méthode appelée dans cet exemple.
- `0`: Cela indique le délai avant que le minuteur ne commence à s'exécuter. Dans cet exemple, le minuteur démarre immédiatement.
- `2000`: C'est l'intervalle entre les appels à la méthode spécifiée, mesuré en millisecondes. Dans cet exemple, la méthode sera appelée toutes les deux secondes.

## Avantages de l'utilisation d'un jetable autonome

L'utilisation d'un jetable autonome présente plusieurs avantages :
- **Clarté du code**: En utilisant un jetable, vous pouvez éviter de créer des variables inutiles, ce qui rend le code plus concis et lisible.
- **Gestion efficace de la mémoire**: Les objets créés en tant que jetables sont automatiquement collectés par le garbage collector lorsqu'ils ne sont plus référencés, ce qui contribue à une gestion efficace de la mémoire.

## Exemple d'utilisation d'un jetable

Considérons un exemple où un jetable est utilisé pour afficher des messages à intervalles réguliers :

```csharp
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        TimerCallback callback = new TimerCallback(AfficherMessage);
        var jetable = new Timer(callback, null, 0, 2000);

        Console.WriteLine("Appuyez sur une touche pour arrêter le minuteur...");
        Console.ReadKey();

        jetable.Dispose(); // Arrêter le minuteur et libérer les ressources
        Console.WriteLine("Minuteur arrêté.");
    }

    static void AfficherMessage(object state)
    {
        Console.WriteLine("Message affiché à l'instant: " + DateTime.Now);
    }
}
```

Dans cet exemple, la méthode `AfficherMessage` est appelée toutes les deux secondes pour afficher l'heure actuelle. Le programme continue à s'exécuter jusqu'à ce qu'une touche soit pressée, moment où le minuteur est arrêté et les ressources sont libérées.

## Conclusion

Les jetables autonomes sont des outils pratiques en C# pour gérer proprement les ressources et simplifier le code. En comprenant leur utilisation et leurs avantages, vous serez en mesure de développer des applications plus efficaces et plus propres en C#.