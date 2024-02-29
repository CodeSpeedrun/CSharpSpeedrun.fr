# Application des requêtes LINQ aux objets de collection

LINQ to Objects peut être utilisé sur n'importe quel type implémentant IEnumerable<T>.

## Recherche des voitures rapides dans une liste générique

```csharp
var voituresRapides = from v in mesVoitures where v.Vitesse > 55 select v;
```

Dans cet exemple, la requête LINQ récupère toutes les voitures dans la liste `mesVoitures` dont la vitesse est supérieure à 55.

## Recherche des voitures rapides de marque Audi

```csharp
var audiRapides = from v in mesVoitures where v.Vitesse > 90 && v.Marque == "Audi" select v;
```

Cette requête récupère les voitures de marque Audi avec une vitesse supérieure à 90.

## Application des requêtes LINQ aux collections non génériques

```csharp
ArrayList voituresListe = new ArrayList() {
    new Voiture{ Nom = "A4", Couleur = "Gris", Vitesse = 100, Marque = "Audi"},
    new Voiture{ Nom = "Q7", Couleur = "Noir", Vitesse = 85, Marque = "Audi"},
    new Voiture{ Nom = "Golf", Couleur = "Blanc", Vitesse = 60, Marque = "VW"},
    new Voiture{ Nom = "Civic", Couleur = "Rouge", Vitesse = 70, Marque = "Honda"},
    new Voiture{ Nom = "Fiesta", Couleur = "Bleu", Vitesse = 50, Marque = "Ford"}
};

var voituresEnum = voituresListe.OfType<Voiture>();

var voituresRapides = from v in voituresEnum where v.Vitesse > 55 select v;
```

Dans cet exemple, une collection non générique `ArrayList` contenant des objets `Voiture` est transformée en un type compatible avec IEnumerable<T> grâce à la méthode `OfType<T>`. Ensuite, une requête LINQ est appliquée pour récupérer les voitures ayant une vitesse supérieure à 55.

```csharp
foreach (var voiture in voituresRapides)
{
    Console.WriteLine($"Nom: {voiture.Nom}, Couleur: {voiture.Couleur}, Vitesse: {voiture.Vitesse}, Marque: {voiture.Marque}");
}
```

Cette boucle `foreach` parcourt les voitures rapides et affiche leurs détails.

```
Sortie attendue :
Nom: A4, Couleur: Gris, Vitesse: 100, Marque: Audi
Nom: Q7, Couleur: Noir, Vitesse: 85, Marque: Audi
Nom: Civic, Couleur: Rouge, Vitesse: 70, Marque: Honda
```

Cette sortie affiche les détails des voitures qui ont une vitesse supérieure à 55.
