# Réflexion sur les Attributs en Utilisant la Liaison Anticipée

Lorsqu'un logiciel externe cherche à détecter la présence d'un attribut personnalisé, il peut le faire en utilisant soit la liaison anticipée, soit la liaison tardive.

```csharp
// Obtient le Type représentant un véhicule.
Type typeVehicule = typeof(Voiture);
// Récupère tous les attributs associés au véhicule.
object[] attributsPersonnalises = typeVehicule.GetCustomAttributes(false);
// Affiche la description.
foreach (DescriptionVehiculeAttribute attribut in attributsPersonnalises)
{
    // Traitement de l'attribut ici.
}
```

Dans cet exemple, nous utilisons la réflexion pour examiner les attributs personnalisés associés à un type de véhicule spécifique, ici une voiture. Cette approche permet à un programme de découvrir les caractéristiques spéciales d'un type donné à l'exécution.

## Explication du Code

### Obtention du Type
La méthode `typeof()` est utilisée pour obtenir un objet `Type` représentant le type spécifié, ici `Voiture`.

### Obtention des Attributs
La méthode `GetCustomAttributes()` permet de récupérer tous les attributs personnalisés appliqués au type spécifié. Le paramètre booléen indique si les attributs hérités doivent être inclus dans la recherche.

### Boucle de Traitement
La boucle `foreach` itère à travers tous les attributs personnalisés trouvés. Dans cet exemple, chaque attribut est typé en tant qu'instance de `DescriptionVehiculeAttribute` pour accéder à ses propriétés spécifiques.

## Liaison Anticipée vs Liaison Tardive
La liaison anticipée, comme illustrée dans cet exemple, se produit au moment de la compilation. Les types sont déterminés à ce moment-là, ce qui signifie que toute erreur dans le code sera détectée avant l'exécution.

La liaison tardive, en revanche, se produit à l'exécution. Cela permet une plus grande flexibilité mais peut aussi introduire des erreurs qui ne seront découvertes qu'au moment de l'exécution.

## Conclusion
La réflexion en C# permet d'examiner et de manipuler les types et les attributs à l'exécution. En utilisant la liaison anticipée, nous pouvons découvrir les attributs personnalisés d'un type donné et agir en conséquence dans notre programme. Cela ouvre la porte à des fonctionnalités avancées et à des conceptions flexibles dans le développement logiciel.