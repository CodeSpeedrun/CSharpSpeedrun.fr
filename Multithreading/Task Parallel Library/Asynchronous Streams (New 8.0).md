# Les flux asynchrones 

Les flux asynchrones sont une fonctionnalité introduite en C# 8.0 permettant de gérer efficacement des opérations asynchrones produisant des séquences de données.

## Utilisation des flux asynchrones

Une méthode qui retourne un flux asynchrone :

- Est déclarée avec le modificateur async.
- Retourne un IAsyncEnumerable<T>.
- Contient des instructions yield return pour fournir des éléments successifs dans le flux asynchrone.

Voici un exemple de méthode qui génère une séquence asynchrone de nombres premiers :

```csharp
public static async IAsyncEnumerable<int> GenererNombresPremiersAsync()
{
    for (int nombre = 2; nombre < 100; nombre++)
    {
        if (EstNombrePremier(nombre))
        {
            await Task.Delay(50); // Simuler un calcul asynchrone
            yield return nombre;
        }
    }
}

private static bool EstNombrePremier(int nombre)
{
    if (nombre <= 1)
        return false;

    for (int i = 2; i <= Math.Sqrt(nombre); i++)
    {
        if (nombre % i == 0)
            return false;
    }

    return true;
}
```

Dans cet exemple, la méthode `GenererNombresPremiersAsync` est déclarée comme asynchrone et retourne un `IAsyncEnumerable<int>`, permettant de produire une séquence asynchrone de nombres premiers. La méthode utilise l'instruction `yield return` pour retourner chaque nombre premier de manière asynchrone, après avoir vérifié s'il est premier à l'aide de la méthode `EstNombrePremier`.

## Explication détaillée

### Modificateur async
Le modificateur `async` permet à une méthode de réaliser des opérations asynchrones sans bloquer le thread d'appel.

### IAsyncEnumerable<T>
`IAsyncEnumerable<T>` est une interface qui permet d'itérer de manière asynchrone sur une séquence d'éléments de type `T`.

### Utilisation de yield return
L'instruction `yield return` est utilisée pour retourner de manière paresseuse des éléments successifs dans la séquence asynchrone. Dans notre exemple, elle permet de retourner les nombres premiers un par un à mesure qu'ils sont générés.

### Appel asynchrone de la méthode
L'appel de la méthode `GenererNombresPremiersAsync` se fait de manière asynchrone à l'aide du mot-clé `await`, permettant au programme de continuer à s'exécuter pendant que la séquence de nombres premiers est générée de manière asynchrone.

En conclusion, les flux asynchrones sont utiles pour traiter efficacement des opérations asynchrones produisant des séquences de données, comme illustré dans cet exemple de génération de nombres premiers.