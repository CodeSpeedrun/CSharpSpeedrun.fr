# Obtention de sous-ensembles de données

Pour obtenir un sous-ensemble spécifique à partir d'un conteneur, vous pouvez utiliser l'opérateur `où`. Lorsque vous le faites, le modèle général devient le code suivant :

```csharp
var resultat =
    from élément
    in conteneur
    where ExpressionBooléenne
    select élément;
```

Remarquez que l'opérateur `où` attend une expression qui se résout en un booléen. Par exemple, pour extraire du tableau `InfosProduit[]` uniquement les éléments ayant plus de 25 articles en stock, vous pourriez écrire le code suivant :

```csharp
using System;

class Program
{
    static void Main()
    {
        InfosProduit[] produits = {
            new InfosProduit("Produit A", 20),
            new InfosProduit("Produit B", 30),
            new InfosProduit("Produit C", 10),
            new InfosProduit("Produit D", 40)
        };

        ObtenirSurstock(produits);
    }

    static void ObtenirSurstock(InfosProduit[] produits)
    {
        Console.WriteLine("Les articles en surstock !");
        // Obtenir uniquement les articles où nous avons plus de
        // 25 en stock.
        var surstock =
            from p
            in produits
            where p.NombreEnStock > 25
            select p;

        foreach (var produit in surstock)
        {
            Console.WriteLine($"Nom: {produit.Nom}, Stock: {produit.NombreEnStock}");
        }
    }
}

class InfosProduit
{
    public string Nom { get; }
    public int NombreEnStock { get; }

    public InfosProduit(string nom, int nombreEnStock)
    {
        Nom = nom;
        NombreEnStock = nombreEnStock;
    }
}
```

Dans cet exemple, `InfosProduit` est une classe représentant les informations sur un produit, avec des propriétés comme `Nom` et `NombreEnStock`.

### Exemple : Obtenir uniquement les voitures BMW allant à au moins 100 MPH

```csharp
using System;

class Program
{
    static void Main()
    {
        Voiture[] voitures = {
            new Voiture("BMW", 120),
            new Voiture("Audi", 90),
            new Voiture("BMW", 110),
            new Voiture("Mercedes", 100)
        };

        ObtenirBMWRapides(voitures);
    }

    static void ObtenirBMWRapides(Voiture[] voitures)
    {
        Console.WriteLine("Les BMW rapides !");
        // Obtenir les BMW qui vont à au moins
        // 100 MPH.
        var seulementBMWRapides =
            from v
            in voitures
            where v.Marque == "BMW" && v.Vitesse >= 100
            select v;

        foreach (var voiture in seulementBMWRapides)
        {
            Console.WriteLine($"Marque: {voiture.Marque}, Vitesse: {voiture.Vitesse}");
        }
    }
}

class Voiture
{
    public string Marque { get; }
    public int Vitesse { get; }

    public Voiture(string marque, int vitesse)
    {
        Marque = marque;
        Vitesse = vitesse;
    }
}
```

Dans cet exemple, `Voiture` est une classe représentant une voiture, avec des propriétés comme `Marque` et `Vitesse`.
