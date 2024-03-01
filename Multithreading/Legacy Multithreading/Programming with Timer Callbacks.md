# Programmation avec Rappels de Timer

Les rappels de timer sont souvent nécessaires dans le développement logiciel pour exécuter des tâches à intervalles réguliers. Cela peut être utile dans divers scénarios, comme la vérification périodique de nouveaux messages électroniques. Pour gérer de telles situations, on peut utiliser le type Timer de System.Threading en conjonction avec un délégué TimerCallback.

```csharp
using System;
using System.Threading;

Console.WriteLine("***** Utilisation du type Timer *****\n");
Console.ReadLine();

static void AfficherHeure(object state)
{
    Console.WriteLine("Il est actuellement : {0}",
    DateTime.Now.ToLongTimeString());
}
```

La méthode associée au délégué TimerCallback doit accepter un paramètre de type System.Object et retourner void. Ceci est impératif car le délégué TimerCallback ne peut être utilisé qu'avec des méthodes répondant à cette signature.

```csharp
// Création du délégué pour le type Timer.
TimerCallback callbackTemps = new TimerCallback(AfficherHeure);

// Configuration du timer.
Timer t = new Timer(
    callbackTemps, // Le délégué TimerCallback.
    null, // Les données à transmettre à la méthode appelée (null pour aucune donnée).
    0, // Délai avant le premier déclenchement (en millisecondes).
    2000); // Intervalle entre les déclenchements suivants (en millisecondes).
```

Si vous avez besoin de transmettre des informations supplémentaires à la méthode appelée, vous pouvez spécifier ces données lors de la création du Timer.

```csharp
// Configuration du timer avec des données supplémentaires.
Timer t = new Timer(callbackTemps, "Bonjour depuis C#", 0, 2000);
```

Vous pouvez ensuite récupérer ces données dans la méthode associée au délégué TimerCallback.

```csharp
static void AfficherHeure(object state)
{
    Console.WriteLine("Il est actuellement : {0}, Info : {1}",
    DateTime.Now.ToLongTimeString(), state.ToString());
}
```

## Explication des Codes

### Utilisation de TimerCallback

Le délégué TimerCallback est utilisé pour spécifier le type de méthode qui peut être invoquée par le Timer. Il doit correspondre à une méthode qui accepte un paramètre de type objet et ne retourne rien.

### Création du Timer

L'instanciation de la classe Timer nécessite la spécification de divers paramètres, notamment le délégué TimerCallback, les données à transmettre, le délai avant le premier déclenchement et l'intervalle entre les déclenchements suivants.

### Passage de Données Additionnelles

Si des informations supplémentaires doivent être transmises à la méthode appelée, elles peuvent être spécifiées lors de la création du Timer. Cela permet de personnaliser le comportement de la méthode en fonction du contexte d'exécution.

### Récupération des Données

La méthode associée au délégué TimerCallback peut récupérer les données transmises en les convertissant en chaîne de caractères à l'aide de la méthode ToString(). Cela permet d'accéder aux informations fournies lors de la création du Timer.

## Conclusion

Les rappels de Timer offrent une manière efficace d'exécuter des tâches de manière périodique dans une application C#. En utilisant le délégué TimerCallback et la classe Timer, vous avez un contrôle précis sur la fréquence et le moment d'exécution des méthodes associées, ce qui offre une grande flexibilité dans la gestion des opérations asynchrones.