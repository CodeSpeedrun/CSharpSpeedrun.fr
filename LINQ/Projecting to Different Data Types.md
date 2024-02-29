# Projections vers différents types de données

Lors de la projection vers des types anonymes en C#, il est également possible de projeter les résultats de votre requête LINQ vers un autre type de données concret. Cela permet d'avoir un typage statique en utilisant `IEnumerable<T>` comme ensemble de résultats.

## Utilisation de types concrets

Supposons que nous ayons un tableau de produits `ProduitInfo[]`, nous pouvons projeter les noms et les descriptions de ces produits dans une structure de données plus petite appelée `ProduitInfoReduit`.

### Exemple de Code

```csharp
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void ObtenirNomsEtDescriptionsTypés(ProduitInfo[] produits)
    {
        Console.WriteLine("Noms et descriptions :");
        IEnumerable<ProduitInfoReduit> nomsDesc =
            from p in produits
            select new ProduitInfoReduit
            { 
                Nom = p.Nom, 
                Description = p.Description 
            };
        foreach (ProduitInfoReduit item in nomsDesc)
        {
            Console.WriteLine($"Nom : {item.Nom}, Description : {item.Description}");
        }
    }

    static void Main()
    {
        // Exemple de données de produits
        ProduitInfo[] produits = new ProduitInfo[]
        {
            new ProduitInfo { Nom = "Produit A", Description = "Description du produit A" },
            new ProduitInfo { Nom = "Produit B", Description = "Description du produit B" }
        };

        // Appel de la méthode pour obtenir les noms et les descriptions des produits
        ObtenirNomsEtDescriptionsTypés(produits);
    }
}

// Classe représentant les informations d'un produit
class ProduitInfo
{
    public string Nom { get; set; }
    public string Description { get; set; }
}

// Classe représentant une version réduite des informations d'un produit
class ProduitInfoReduit
{
    public string Nom { get; set; }
    public string Description { get; set; }
}
```

### Explication

- Nous avons une méthode `ObtenirNomsEtDescriptionsTypés` qui prend un tableau de `ProduitInfo`.
- À l'intérieur de cette méthode, nous projetons les noms et les descriptions de chaque produit dans une nouvelle structure de données `ProduitInfoReduit`.
- Nous utilisons une requête LINQ pour parcourir chaque produit et créer une nouvelle instance de `ProduitInfoReduit` avec les mêmes valeurs de nom et de description.
- Nous itérons ensuite sur la séquence résultante et affichons les noms et les descriptions à la console.

Ce concept de projection vers des types concrets est utile lorsque vous avez besoin d'une représentation plus spécifique des données extraites à partir d'une source de données, en particulier lorsque vous travaillez avec des requêtes LINQ dans C#.