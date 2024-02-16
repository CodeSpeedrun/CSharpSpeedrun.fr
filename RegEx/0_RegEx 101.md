## Qu'est-ce qu'une expression régulière (Regex) ?

Une expression régulière, souvent abrégée en "Regex", est un motif de caractères qui permet de rechercher et de manipuler des chaînes de texte de manière flexible. Les expressions régulières sont utilisées pour effectuer des opérations telles que la recherche de motifs spécifiques, le remplacement de texte, la validation de formats et bien plus encore.

#### Utilisation des expressions régulières en C#

En C#, les expressions régulières sont mises en œuvre via le namespace `System.Text.RegularExpressions`. Ce namespace fournit des classes et des méthodes pour travailler avec des expressions régulières, telles que `Regex`, `Match`, `MatchCollection`, et d'autres.

#### Structure d'une expression régulière

Une expression régulière est composée de divers éléments :

- **Caractères littéraux** : Ce sont les caractères normaux qui correspondent exactement à eux-mêmes dans la chaîne de texte.
  
  Exemple : `abc` correspondrait à la séquence de caractères "abc" dans la chaîne de texte.

- **Méta-caractères** : Ce sont des caractères spéciaux qui ont une signification particulière dans une expression régulière.

  Exemple : 
  - `.` correspond à n'importe quel caractère.
  - `*` correspond à zéro ou plusieurs occurrences du caractère précédent.

- **Classes de caractères** : Elles permettent de spécifier un ensemble de caractères possibles à une position donnée dans la chaîne.

  Exemple : `[a-zA-Z]` correspond à n'importe quelle lettre majuscule ou minuscule.

- **Modificateurs** : Ils permettent de spécifier des conditions supplémentaires, telles que la correspondance insensible à la casse ou la correspondance multiligne.

  Exemple : `(?i)` permet d'activer la correspondance insensible à la casse.

#### Méthodes courantes de la classe `Regex` en C#

- **`Regex.IsMatch(string input, string pattern)`** : Vérifie si une chaîne correspond à un motif donné.
- **`Regex.Match(string input, string pattern)`** : Recherche la première occurrence d'un motif dans une chaîne.
- **`Regex.Matches(string input, string pattern)`** : Recherche toutes les occurrences d'un motif dans une chaîne.
- **`Regex.Replace(string input, string pattern, string replacement)`** : Remplace les occurrences d'un motif dans une chaîne par une autre chaîne spécifiée.

#### Exemple détaillé

Le code fourni illustre l'utilisation de la méthode `Regex.Replace` pour nettoyer une chaîne de texte. Dans cet exemple :

```csharp
string txt = "Bonjour le monde, bienvenue chaleureuse@au C#SharpSpeedrun";
string result = Regex.Replace(txt, "[^a-zA-Z0-9_]+", " ");
Console.Write(result); 
```

- La chaîne de texte `txt` contient un mélange de lettres, chiffres et caractères spéciaux.
- L'expression régulière `[a-zA-Z0-9_]` spécifie les caractères alphanumériques (lettres majuscules et minuscules, chiffres) ainsi que le caractère de souligné.
- La méthode `Regex.Replace` est utilisée pour remplacer tous les caractères qui ne correspondent pas à cette expression régulière par un espace.
- Le résultat est affiché dans la console, montrant une version nettoyée de la chaîne de texte initiale.

Ce processus démontre comment les expressions régulières peuvent être utilisées pour filtrer et manipuler des données textuelles selon des critères spécifiques.