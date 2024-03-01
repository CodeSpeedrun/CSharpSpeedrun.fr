# Parallélisme des Tâches avec la Classe Parallel en C#

Le parallélisme des tâches est une technique essentielle pour exploiter efficacement les ressources de calcul disponibles. En utilisant la classe `Parallel` en C#, vous pouvez exécuter des tâches simultanément, améliorant ainsi les performances de votre application. Dans cet exemple, nous allons voir comment utiliser la classe `Parallel` pour traiter un texte et extraire des statistiques sur celui-ci.

```csharp
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Text;

string _leTexte = "";

TelechargerTexte();
Console.WriteLine("Téléchargement du texte...");
Console.ReadLine();

void TelechargerTexte()
{
    WebClient webClient = new WebClient();
    webClient.DownloadStringCompleted += (sender, e) =>
    {
        _leTexte = e.Result;
        Console.WriteLine("Téléchargement terminé.");
        ExtraireStatistiques();
    };

    webClient.DownloadStringAsync(new Uri("https://mon-site.com/mon-texte.txt"));
}

void ExtraireStatistiques()
{
    string[] mots = _leTexte.Split(new char[]
    { ' ', '\u000A', ',', '.', ';', ':', '-', '?', '/' },
    StringSplitOptions.RemoveEmptyEntries);

    string[] dixMotsFrequents = TrouverDixMotsFrequents(mots);
    string motLePlusLong = TrouverMotLePlusLong(mots);

    StringBuilder stats = new StringBuilder("Les dix mots les plus fréquents sont :\n");
    foreach (string mot in dixMotsFrequents)
    {
        stats.AppendLine(mot);
    }
    stats.AppendFormat("Le mot le plus long est : {0}", motLePlusLong);
    stats.AppendLine();
    Console.WriteLine(stats.ToString(), "Statistiques du Texte");
}

string[] TrouverDixMotsFrequents(string[] mots)
{
    var frequenceOrdre = from mot in mots
                         where mot.Length > 5
                         group mot by mot into g
                         orderby g.Count() descending
                         select g.Key;

    string[] motsFrequents = (frequenceOrdre.Take(10)).ToArray();
    return motsFrequents;
}

string TrouverMotLePlusLong(string[] mots)
{
    return (from m in mots orderby m.Length descending select m).FirstOrDefault();
}

void ExtraireStatistiques()
{
    string[] mots = _leTexte.Split(
        new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '?', '/' },
        StringSplitOptions.RemoveEmptyEntries);

    string[] dixMotsFrequents = null;
    string motLePlusLong = string.Empty;

    Parallel.Invoke(
        () =>
        {
            dixMotsFrequents = TrouverDixMotsFrequents(mots);
        },
        () =>
        {
            motLePlusLong = TrouverMotLePlusLong(mots);
        });

    StringBuilder stats = new StringBuilder();

    // Concaténation des statistiques
}
```

### Explication des Snippets de Code

- `TelechargerTexte()`: Cette méthode utilise un objet WebClient pour télécharger un texte à partir d'une URL de manière asynchrone. Une fois le téléchargement terminé, l'événement `DownloadStringCompleted` est déclenché, où le contenu du texte est assigné à la variable `_leTexte`.

- `ExtraireStatistiques()`: Cette méthode divise le contenu du texte en mots, puis utilise des méthodes pour trouver les dix mots les plus fréquents et le mot le plus long. Les résultats sont ensuite affichés à l'utilisateur.

- `TrouverDixMotsFrequents(string[] mots)`: Cette méthode utilise une requête LINQ pour regrouper les mots par fréquence, en ne conservant que ceux dont la longueur dépasse 5 caractères. Enfin, elle sélectionne les dix mots les plus fréquents.

- `TrouverMotLePlusLong(string[] mots)`: Cette méthode utilise une requête LINQ pour trier les mots par longueur de manière décroissante et renvoie le premier élément de la liste, c'est-à-dire le mot le plus long.

- `Parallel.Invoke()`: Cette méthode exécute les deux actions fournies en parallèle, permettant ainsi de rechercher les dix mots les plus fréquents et le mot le plus long simultanément pour améliorer les performances.

Ces snippets de code illustrent l'utilisation efficace de la classe `Parallel` en C# pour traiter des tâches en parallèle et améliorer les performances lors du traitement de grandes quantités de données.