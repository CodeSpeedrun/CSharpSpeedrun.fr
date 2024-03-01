# La programmation parallèle asynchrone en C#

La bibliothèque System.Threading.Tasks permet de construire un code parallèle finement granulaire et évolutif sans avoir à travailler directement avec les threads ou le pool de threads.

## Utilisation du mot-clé async/await

Les méthodes (ainsi que les expressions lambda ou les méthodes anonymes) peuvent être marquées avec le mot-clé async pour permettre à la méthode d'effectuer un travail de manière non bloquante.
- Les méthodes (ainsi que les expressions lambda ou les méthodes anonymes) marquées avec le mot-clé async s'exécuteront de manière synchrone jusqu'à ce que le mot-clé await soit rencontré.
- Une seule méthode asynchrone peut comporter plusieurs contextes d'attente (await).
- Lorsque l'expression await est rencontrée, le thread appelant est suspendu jusqu'à ce que la tâche attendue soit terminée. Pendant ce temps, le contrôle est renvoyé à l'appelant de la méthode.
- Le mot-clé await masquera l'objet Task retourné, donnant l'impression de retourner directement la valeur de retour sous-jacente. Les méthodes sans valeur de retour renvoient simplement void.
- La vérification des paramètres et d'autres manipulations d'erreurs doivent être effectuées dans la section principale de la méthode, la partie asynchrone étant déplacée vers une fonction privée.
- Pour les variables de pile, ValueTask est plus efficace que l'objet Task, qui pourrait provoquer des opérations de boxing et unboxing.
- Comme convention de nommage, les méthodes qui doivent être appelées de manière asynchrone doivent être marquées avec le suffixe Async.

## Exemple d'utilisation du mot-clé async/await

Considérons un exemple simple où une méthode asynchrone est utilisée pour effectuer une opération de calcul longue sans bloquer le thread principal :

```csharp
public async Task<int> CalculateAsync(int x, int y)
{
    // Le calcul long est effectué de manière asynchrone ici
    await Task.Delay(1000); // Simulation d'une opération longue
    
    // Le résultat du calcul est retourné
    return x + y;
}
```

Dans cet exemple, la méthode `CalculateAsync` est marquée avec le mot-clé `async`, ce qui lui permet d'utiliser le mot-clé `await` pour attendre de manière asynchrone l'achèvement d'une tâche. Ici, la tâche simulée est un délai de 1000 millisecondes pour représenter une opération longue.

L'appel de cette méthode se ferait de la manière suivante :

```csharp
int result = await CalculateAsync(3, 5);
Console.WriteLine("Result: " + result); // Affiche "Result: 8" après environ 1 seconde
```

L'utilisation de `await` permet à l'application de continuer à fonctionner de manière asynchrone sans bloquer le thread principal, ce qui est crucial pour les applications interactives et réactives.

## Conclusion

En utilisant les mots-clés `async` et `await` en conjonction avec la bibliothèque `System.Threading.Tasks`, les développeurs peuvent créer des applications réactives et évolutives tout en maintenant un code lisible et maintenable.
