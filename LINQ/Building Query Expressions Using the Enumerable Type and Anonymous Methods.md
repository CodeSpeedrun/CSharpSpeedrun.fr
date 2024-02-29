# Utilisation de l'expression de requête en utilisant le type Enumerable et les méthodes anonymes

Dans ce guide, nous explorerons comment construire des expressions de requête en utilisant le type Enumerable en C#, en utilisant des méthodes anonymes. Nous examinerons également comment utiliser des délégués Func<> pour filtrer, trier et sélectionner des données à partir d'une collection de jeux vidéo.

### Collection de jeux vidéo actuelle

Considérons une collection de jeux vidéo actuelle représentée par un tableau de chaînes de caractères :

```csharp
string[] jeuxVideoActuels = {"Uno", "Uncharted 3", "Bio Shock 2"};
```

### Filtrage, tri et sélection

Nous allons utiliser des délégués Func<> anonymes pour construire nos expressions de requête. Voici les délégués que nous utiliserons :

- `filtreRecherche` : un délégué qui retourne vrai si un jeu contient un espace.
- `elementAProcessus` : un délégué qui renvoie simplement la chaîne de caractères passée en entrée.

Voici comment nous définissons ces délégués :

```csharp
Func<string, bool> filtreRecherche 
    = delegate(string jeu) { return jeu.Contains(" "); };
Func<string, string> elementAProcessus 
    = delegate(string s) { return s; };
```

### Construction de l'expression de requête

Nous utilisons ensuite ces délégués pour filtrer, trier et sélectionner les jeux vidéo de notre collection :

```csharp
var sousEnsemble 
    = jeuxVideoActuels.Where(filtreRecherche).OrderBy(elementAProcessus).Select(elementAProcessus);
```

### Affichage des résultats

Enfin, nous affichons les résultats obtenus :

```csharp
foreach (var jeu in sousEnsemble)
{
    Console.WriteLine(jeu);
}
```

### Explication détaillée

#### Délégués Func<>

Les délégués Func<> sont des délégués génériques pré-définis dans .NET qui représentent une méthode qui prend un ou plusieurs arguments de type T et retourne un résultat de type TResult. Dans notre exemple, nous utilisons deux délégués Func<> : un pour filtrer les jeux vidéo et un pour traiter chaque élément.

#### Méthode Where()

La méthode `Where()` est une méthode d'extension de la classe Enumerable qui filtre une séquence d'éléments en fonction d'un prédicat spécifié. Dans notre exemple, nous utilisons `Where()` pour filtrer les jeux vidéo en fonction du délégué `searchFilter`.

#### Méthode OrderBy()

La méthode `OrderBy()` est une méthode d'extension de la classe Enumerable qui trie les éléments d'une séquence dans l'ordre croissant en fonction d'une clé spécifiée. Dans notre exemple, nous utilisons `OrderBy()` pour trier les jeux vidéo en fonction du délégué `itemToProcess`.

#### Méthode Select()

La méthode `Select()` est une méthode d'extension de la classe Enumerable qui projette chaque élément d'une séquence dans une nouvelle forme. Dans notre exemple, nous utilisons `Select()` pour sélectionner chaque jeu vidéo après avoir été traité par le délégué `itemToProcess`.

### Conclusion

En utilisant les délégués Func<> et les méthodes d'extension de la classe Enumerable, nous avons pu construire une expression de requête complexe pour filtrer, trier et sélectionner des éléments d'une collection de jeux vidéo. Cette approche offre une flexibilité et une expressivité accrues lors de la manipulation de données en C#.