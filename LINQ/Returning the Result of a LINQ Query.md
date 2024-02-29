# Retourner le Résultat d'une Requête LINQ

Il est possible de définir un champ au sein d'une classe (ou structure) dont la valeur est le résultat d'une requête LINQ. Cependant, pour le faire, vous ne pouvez pas utiliser le typage implicite (car le mot-clé `var` ne peut pas être utilisé pour les champs), et la cible de la requête LINQ ne peut pas être des données au niveau de l'instance ; par conséquent, elle doit être statique. Compte tenu de ces limitations, vous aurez rarement besoin de rédiger du code comme celui-ci :

```csharp
class JeuxVideo
{
    private static string[] titresJeux =
    {"The Witcher 3", "Red Dead Redemption 2", "Cyberpunk 2077", "Assassin's Creed Valhalla", "Horizon Zero Dawn"};
    
    // On ne peut pas utiliser de typage implicite ici ! Il faut connaître le type du sous-ensemble !
    private IEnumerable<string> sousEnsemble =
    from j in titresJeux
    where j.Contains(" ")
    orderby j
    select j;
    
    public void AfficherJeuxAvecEspace()
    {
        foreach (var jeu in sousEnsemble)
        {
            Console.WriteLine($"Jeu avec espace dans le titre : {jeu}");
        }
    }
    
    static IEnumerable<string> ObtenirJeuxAvecMotClef()
    {
        string[] genres = {"Action-RPG", "Open-world", "FPS", "RPG", "Sandbox"};
        
        // Remarque : le sous-ensemble est un objet compatible IEnumerable<string>.
        IEnumerable<string> jeuxAvecMotClef = from genre in genres
                                                where genre.Contains("-")
                                                select genre;
        return jeuxAvecMotClef;
    }
}
```
Dans cet exemple, nous avons une classe nommée `JeuxVideo`. À l'intérieur, nous avons un tableau statique `titresJeux` contenant des noms de jeux vidéo populaires. Ensuite, nous avons un champ `sousEnsemble` qui est une liste de jeux vidéo dont le titre contient un espace, triée par ordre alphabétique. La méthode `AfficherJeuxAvecEspace` parcourt cette liste et imprime chaque jeu.

La méthode statique `ObtenirJeuxAvecMotClef` retourne une liste de genres de jeux vidéo qui contiennent un tiret ("-"). Cette méthode est statique car elle est appelée à partir d'une méthode statique dans la même classe.

Ces exemples illustrent comment utiliser LINQ pour filtrer et sélectionner des éléments dans un tableau en fonction de certains critères. Les résultats sont ensuite retournés pour une utilisation ultérieure.

Dans cet exemple, nous avons une classe nommée `JeuxVideo`. À l'intérieur, nous avons un tableau statique `titresJeux` contenant des noms de jeux vidéo populaires. Ensuite, nous avons un champ `sousEnsemble` qui est une liste de jeux vidéo dont le titre contient un espace, triée par ordre alphabétique. La méthode `AfficherJeuxAvecEspace` parcourt cette liste et imprime chaque jeu.

La méthode statique `ObtenirJeuxAvecMotClef` retourne une liste de genres de jeux vidéo qui contiennent un tiret ("-"). Cette méthode est statique car elle est appelée à partir d'une méthode statique dans la même classe.

Ces exemples illustrent comment utiliser LINQ pour filtrer et sélectionner des éléments dans un tableau en fonction de certains critères. Les résultats sont ensuite retournés pour une utilisation ultérieure.