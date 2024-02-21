# Les délégués Action<> et Func<> Génériques

Lorsqu'il est nécessaire d'avoir un type de délégué personnalisé et unique pour un projet, il est parfois le cas que le nom exact du type de délégué soit sans importance. Dans de nombreux cas, vous souhaitez simplement "un délégué quelconque" qui prend un ensemble d'arguments et éventuellement renvoie une valeur autre que void. Dans ces cas, vous pouvez utiliser les types de délégués Action<> et Func<> intégrés au framework.

## Le délégué Action<>

Le délégué Action<> est utilisé pour pointer vers des méthodes qui ne retournent pas de valeur (void). Par exemple :

```csharp
static void AfficherMessage(string message, ConsoleColor couleurTexte, int nombreImpressions)
{
    // Implémentation de la méthode AfficherMessage
}
```

Plutôt que de créer manuellement un délégué personnalisé pour diriger le flux du programme vers la méthode `AfficherMessage()`, vous pouvez utiliser le délégué Action<> prédéfini, comme ceci :

```csharp
Console.WriteLine("***** Fun avec Action et Func *****");
// Utilisation du délégué Action<> pour pointer vers AfficherMessage.
Action<string, ConsoleColor, int> cibleAction = AfficherMessage;
cibleAction("Message Action!", ConsoleColor.Yellow, 5);
```

L'utilisation du délégué Action<> vous évite la peine de définir un type de délégué personnalisé. Cependant, rappelez-vous que le délégué Action<> ne peut pointer que vers des méthodes qui renvoient void.

## Le délégué Func<>

Si vous souhaitez pointer vers une méthode qui a une valeur de retour (et que vous ne souhaitez pas vous embêter à écrire le délégué personnalisé vous-même), vous pouvez utiliser le délégué Func<>. Contrairement à Action<>, Func<> renvoie une valeur. Par exemple :

```csharp
static int CalculerSomme(int a, int b)
{
    return a + b;
}
```

Utilisation de Func<> :

```csharp
// Utilisation du délégué Func<> pour pointer vers CalculerSomme.
Func<int, int, int> cibleFunc = CalculerSomme;
int resultat = cibleFunc(3, 5); // résultat sera égal à 8
```

L'utilisation des délégués Action<> et Func<> permet de simplifier le code en évitant la création de types de délégués personnalisés pour des cas simples où le nom du délégué est sans importance.