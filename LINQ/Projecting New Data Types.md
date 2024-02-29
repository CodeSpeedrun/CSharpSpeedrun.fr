# Projection de nouveaux types de données

Il est également possible de projeter de nouvelles formes de données à partir d'une source de données existante. Supposons que vous souhaitiez prendre le paramètre entrant ProductInfo[] et obtenir un ensemble de résultats qui ne tient compte que du nom et de la description de chaque élément.

```csharp
// Définition d'une méthode pour obtenir les noms et descriptions des produits
static void ObtenirNomsEtDescriptions(ProduitInfo[] produits)
{
    Console.WriteLine("Noms et descriptions:");
    var nomsDescriptions =
        from produit in produits
        select new { produit.Nom, produit.Description };

    // Parcours et affichage des résultats
    foreach (var element in nomsDescriptions)
    {
        // Affichage du nom et de la description de chaque produit
        Console.WriteLine($"Nom: {element.Nom}, Description: {element.Description}");
    }
}
```

Lorsque vous devez retourner des données projetées à un appelant, une approche consiste à transformer le résultat de la requête en un objet System.Array en utilisant la méthode d'extension ToArray(). Ainsi, si vous deviez mettre à jour votre expression de requête comme suit :

```csharp
// La valeur de retour est désormais un Array.
static Array ObtenirSous-ensembleProjete(ProduitInfo[] produits)
{
    var nomsDescriptions =
        from produit in produits
        select new { produit.Nom, produit.Description };

    // Mappage de l'ensemble d'objets anonymes vers un objet Array
    return nomsDescriptions.ToArray();
}
```

## Explications et Exemples Additionnels

### Méthode `ObtenirNomsEtDescriptions`

Cette méthode prend un tableau de `ProduitInfo` en entrée et projette le nom et la description de chaque produit dans une nouvelle séquence d'objets anonymes. Elle utilise une requête LINQ pour effectuer cette projection. Ensuite, elle parcourt cette séquence et affiche chaque paire nom-description.

### Méthode `ObtenirSous-ensembleProjete`

Cette méthode effectue une opération similaire à `ObtenirNomsEtDescriptions`, mais plutôt que d'afficher les résultats, elle retourne un tableau (`Array`) contenant les objets anonymes projetés. Cela peut être utile lorsque vous avez besoin de manipuler les résultats dans d'autres parties de votre programme.

### Avantages de la Projection de Données

La projection de données permet de sélectionner uniquement les informations pertinentes d'une source de données, ce qui peut améliorer les performances en réduisant la quantité de données transférées et en minimisant le coût de traitement.

### Utilisation de la Projection dans les Bases de Données

La projection est une opération courante dans les bases de données relationnelles. Par exemple, dans SQL, vous pouvez sélectionner des colonnes spécifiques d'une table en utilisant la clause SELECT.

### Autres Fonctionnalités LINQ

LINQ (Language Integrated Query) offre une variété d'opérations pour manipuler les données, notamment la filtration, le tri, et le regroupement. Combinées avec la projection, ces fonctionnalités offrent un moyen puissant de travailler avec les données dans les applications .NET.