# L'Annulation des Opérations async/await

Lorsque vous travaillez avec des opérations asynchrones dans C#, il est crucial d'avoir la possibilité d'annuler ces opérations si nécessaire. Cette note examine comment annuler des opérations async/await en utilisant des CancellationToken, en mettant l'accent sur la gestion de l'annulation dans le traitement des images.

## Méthode de Traitement d'Image

```csharp
private async Task TraiterImage(string cheminImage,
string répertoireSortie, CancellationToken jetonAnnulation)
{
string nomFichier = Path.GetFileName(cheminImage);
using (Bitmap image = new Bitmap(cheminImage))
{
try
{
await Task.Run(() =>
{
Dispatcher?.Invoke(() =>
{
this.Title = $"Traitement en cours : {nomFichier}";
});
image.RotateFlip(RotateFlipType.Rotate180FlipNone);
image.Save(Path.Combine(répertoireSortie, nomFichier));
}
, jetonAnnulation);
}
catch (OperationCanceledException ex)
{
Console.WriteLine(ex);
throw;
}
}
}
```

La méthode `TraiterImage` prend en charge le traitement asynchrone d'une image. Voici une explication détaillée de chaque partie de la méthode :

- `cheminImage`: Le chemin du fichier image à traiter.
- `répertoireSortie`: Le répertoire où l'image traitée sera sauvegardée.
- `jetonAnnulation`: Le jeton d'annulation qui permet d'annuler l'opération si nécessaire.
- `Bitmap`: La classe Bitmap est utilisée pour manipuler l'image.
- `Task.Run`: Cette méthode est utilisée pour exécuter de manière asynchrone le traitement de l'image.
- `Dispatcher?.Invoke`: Cela permet de mettre à jour l'interface utilisateur avec le titre de la fenêtre pendant le traitement de l'image.
- `RotateFlip`: Cette méthode permet de faire pivoter l'image.
- `Save`: Utilisé pour enregistrer l'image traitée dans le répertoire de sortie spécifié.
- `OperationCanceledException`: Capture une exception si l'opération est annulée.

## Utilisation de CancellationToken

Pour annuler une opération asynchrone, on utilise un CancellationToken. Voici comment l'utiliser dans un exemple pratique :

```csharp
private CancellationTokenSource _sourceAnnulation;

private async Task AnnulerTraitement()
{
    _sourceAnnulation?.Cancel();
}

private async Task GérerTraitementImageAsync(string fichier, string répertoire)
{
    _sourceAnnulation = new CancellationTokenSource();
    CancellationToken jetonAnnulation = _sourceAnnulation.Token;

    try
    {
        await TraiterImage(fichier, répertoire, jetonAnnulation);
    }
    catch (OperationCanceledException)
    {
        Console.WriteLine("Traitement annulé.");
    }
}
```

Dans cet exemple, la méthode `AnnulerTraitement` est appelée pour annuler l'opération de traitement en cours. Cela déclenche l'exception `OperationCanceledException`, permettant ainsi de gérer proprement l'annulation de l'opération.

Ces notes offrent une perspective détaillée sur l'annulation des opérations async/await en C#. En comprenant ces concepts et en les appliquant correctement, les développeurs peuvent améliorer la réactivité et l'efficacité de leurs applications tout en garantissant une meilleure expérience utilisateur.