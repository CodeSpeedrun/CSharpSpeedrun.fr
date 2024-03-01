# Notes sur les Fonctions Locales

Les fonctions locales permettent de définir des fonctions à l'intérieur d'une méthode, ce qui peut améliorer la clarté et la structure du code en regroupant du code associé dans une seule méthode.

## Problèmes rencontrés dans une méthode

```csharp
static async Task MethodeAvecProblemes(int parametre1, int parametre2)
{
    Console.WriteLine("Début");
    await Task.Run(() =>
    {
        // Appel d'une opération longue
        Thread.Sleep(6_000); // Exemple: simulation d'une opération longue de 6 secondes
        Console.WriteLine("Première étape terminée");
        // Appel d'une autre opération longue qui échoue en cas de paramètre hors limite
        Console.WriteLine("Erreur: paramètre invalide");
    });
}
```

Dans cet exemple, nous avons une méthode asynchrone `MethodeAvecProblemes` qui prend deux paramètres. Elle exécute deux tâches longues de manière asynchrone. Cependant, le deuxième appel échoue si le deuxième paramètre est en dehors de la plage autorisée. Comme la méthode est asynchrone, il n'y a aucune garantie que les vérifications seront exécutées avant l'exécution de la tâche.

## Correction des problèmes avec une fonction locale

```csharp
static async Task MethodeAvecProblemesCorriges(int parametre1, int parametre2)
{
    Console.WriteLine("Début");
    if (parametre2 < 0)
    {
        Console.WriteLine("Données invalides");
        return;
    }
    await ImplementationReelle();
    
    async Task ImplementationReelle()
    {
        await Task.Run(() =>
        {
            // Appel d'une opération longue
            Thread.Sleep(6_000); // Exemple: simulation d'une opération longue de 6 secondes
            Console.WriteLine("Première étape terminée");
            // Appel d'une autre opération longue qui échoue en cas de paramètre hors limite
        });
    }
}
```

Dans cette version corrigée, nous avons introduit une fonction locale `ImplementationReelle` pour encapsuler la partie de la logique qui nécessite la validation du deuxième paramètre. Cela améliore la lisibilité et la maintenabilité du code en séparant les préoccupations. Maintenant, la vérification du deuxième paramètre est effectuée avant l'exécution de la tâche longue, garantissant ainsi que les données en entrée sont valides.