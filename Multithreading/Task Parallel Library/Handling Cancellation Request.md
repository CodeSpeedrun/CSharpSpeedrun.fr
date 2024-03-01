# Gestion de la Demande d'Annulation

Dans cette section, nous explorons la manière de gérer la demande d'annulation dans les applications C# en utilisant les CancellationToken.

## Déclaration des Variables

Au sein de la fenêtre principale de notre application, nous initialisons une variable au niveau de la fenêtre pour encapsuler le CancellationTokenSource, qui nous permettra de solliciter une annulation ultérieurement.

```csharp
public partial class FenetrePrincipale : Window
{
    // Déclaration d'une nouvelle variable pour le CancellationTokenSource.
    private CancellationTokenSource _tokenAnnulation = new CancellationTokenSource();
    ...
}
```

## Configuration des Options Parallèles

Nous utilisons une instance de ParallelOptions pour spécifier les options de parallélisme, y compris le CancellationToken à utiliser pour la demande d'annulation et le nombre maximal de degrés de parallélisme.

```csharp
ParallelOptions optionsParalleles = new ParallelOptions();
optionsParalleles.CancellationToken = _tokenAnnulation.Token;
optionsParalleles.MaxDegreeOfParallelism = Environment.ProcessorCount;
```

## Traitement des Fichiers en Parallèle

Nous utilisons la méthode Parallel.ForEach pour traiter les fichiers en parallèle, en fournissant les options parallèles que nous avons précédemment configurées.

```csharp
string[] fichiers = Directory.GetFiles(@".\ImagesTest", "*.jpg", SearchOption.AllDirectories);
string repertoireSortie = @".\ImagesModifiees";
Directory.CreateDirectory(repertoireSortie);

try
{
    Parallel.ForEach(fichiers, optionsParalleles, fichierCourant =>
    {
        optionsParalleles.CancellationToken.ThrowIfCancellationRequested();
        string nomFichier = Path.GetFileName(fichierCourant);
        Dispatcher?.Invoke(() =>
        {
            this.Title = $"Traitement de {nomFichier} sur le thread {Thread.CurrentThread.ManagedThreadId}";
        });

        using (Bitmap image = new Bitmap(fichierCourant))
        {
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            image.Save(Path.Combine(repertoireSortie, nomFichier));
        }
    });

    Dispatcher?.Invoke(() => this.Title = "Traitement terminé !");
}
catch (OperationCanceledException ex)
{
    Dispatcher?.Invoke(() => this.Title = ex.Message);
}
```

Dans cet exemple, nous parcourons chaque fichier trouvé dans le répertoire spécifié, et pour chaque fichier, nous vérifions s'il y a une demande d'annulation en utilisant CancellationToken.ThrowIfCancellationRequested(). Si une demande d'annulation est détectée, une OperationCanceledException est déclenchée.

Nous utilisons Dispatcher pour mettre à jour le titre de la fenêtre avec le nom du fichier en cours de traitement et pour indiquer lorsque le traitement est terminé. La méthode Invoke est utilisée pour garantir que ces mises à jour sont effectuées sur le thread de l'interface utilisateur.

Après avoir traité tous les fichiers, si aucun problème d'annulation n'est survenu, le titre de la fenêtre est mis à jour pour indiquer que le traitement est terminé. Sinon, si une annulation a été demandée, le titre de la fenêtre est mis à jour pour afficher le message d'erreur associé à l'exception.