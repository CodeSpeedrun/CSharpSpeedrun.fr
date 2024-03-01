# Annulation d'une Requête PLINQ

L'annulation d'une requête PLINQ en C# est essentielle pour gérer les opérations longues ou potentiellement bloquantes de manière efficace. Voici comment procéder :

```csharp
// Création du jeton d'annulation
CancellationTokenSource _tokenAnnulation = new CancellationTokenSource();

// Boucle pour permettre à l'utilisateur de démarrer ou d'annuler le traitement
do
{
    Console.WriteLine("Appuyez sur n'importe quelle touche pour commencer le traitement");
    Console.ReadKey();
    Console.WriteLine("Traitement en cours...");

    // Démarrage du traitement dans une tâche parallèle
    Task.Factory.StartNew(TraitementDonneesEntieres);

    // Demande à l'utilisateur s'il souhaite quitter
    Console.Write("Appuyez sur Q pour quitter : ");
    string reponse = Console.ReadLine();

    // Si l'utilisateur souhaite quitter, annuler le jeton
    if (reponse.Equals("Q", StringComparison.OrdinalIgnoreCase))
    {
        _tokenAnnulation.Cancel();
        break;
    }
} while (true);
```

Ce code présente un modèle simple pour démarrer ou annuler un traitement en utilisant un jeton d'annulation `_tokenAnnulation`. L'utilisateur est invité à appuyer sur une touche pour démarrer le traitement, et s'il souhaite quitter, il peut appuyer sur 'Q', ce qui déclenchera l'annulation.

```csharp
// Méthode pour traiter les données entières
void TraitementDonneesEntieres()
{
    // Génération d'un tableau de données entières
    int[] donnees = Enumerable.Range(1, 10_000_000).ToArray();

    // Requête PLINQ pour trouver les multiples de 5
    int[] multiplesDeCinq = null;
    try
    {
        multiplesDeCinq = (from num in donnees.AsParallel().WithCancellation(_tokenAnnulation.Token)
                           where num % 5 == 0
                           orderby num descending
                           select num).ToArray();

        // Affichage du nombre de résultats trouvés
        Console.WriteLine();
        Console.WriteLine($"Nombre de multiples de 5 trouvés : {multiplesDeCinq.Count()}");
    }
    catch (OperationCanceledException ex)
    {
        // Gestion de l'annulation
        Console.WriteLine("Traitement annulé.");
    }
}
```

La méthode `TraitementDonneesEntieres` effectue le traitement réel des données. Dans cet exemple, nous recherchons les multiples de 5 dans un grand tableau d'entiers. La requête PLINQ est utilisée pour paralléliser la recherche, ce qui permet un traitement plus rapide des données. Si l'annulation est demandée pendant ce traitement, une exception `OperationCanceledException` est déclenchée et gérée pour interrompre le traitement de manière propre.

Ce modèle peut être adapté et étendu pour gérer différents types de traitements et de conditions d'annulation, offrant ainsi une flexibilité et une robustesse accrues dans la gestion des opérations asynchrones en C#.