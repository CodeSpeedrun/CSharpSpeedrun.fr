# Notes sur les Collections en C#

Les collections sont des structures de données essentielles en C# pour stocker et manipuler des ensembles d'objets. Contrairement aux tableaux simples, les collections offrent des fonctionnalités avancées telles que le redimensionnement dynamique et la sécurité des types. Dans le cadre du .NET Core, les bibliothèques de classes de base fournissent plusieurs espaces de noms contenant des classes de collections.

## Interfaces clés prises en charge par les classes de System.Collections

Les interfaces suivantes définissent des comportements essentiels pour les collections en C# :

- **ICollection** : Définit les caractéristiques générales (taille, énumération, sécurité des threads) pour tous les types de collections non génériques.
- **ICloneable** : Permet à un objet implémentant cette interface de retourner une copie de lui-même à l'appelant.
- **IDictionary** : Permet à un objet de collection non générique de représenter son contenu à l'aide de paires clé-valeur.
- **IEnumerable** : Retourne un objet implémentant l'interface IEnumerator pour l'itération.
- **IEnumerator** : Permet l'itération des éléments de la collection dans le style foreach.
- **IList** : Fournit des comportements pour ajouter, supprimer et indexer des éléments dans une liste séquentielle d'objets.

## Problèmes des Collections Non Génériques

Les collections non génériques peuvent entraîner des problèmes de performances et de sécurité des types. Elles sont souvent moins performantes car elles manipulent des objets de type `System.Object` et peuvent nécessiter des opérations de transfert de mémoire supplémentaires. De plus, elles ne sont pas sûres en termes de types, ce qui peut entraîner des erreurs de compilation ou d'exécution.

## Boîtes et Déboîtes

En C#, les types de données peuvent être de deux catégories : les types valeur et les types référence. Pour représenter un type valeur dans un type référence, on utilise un processus appelé "boxing". L'inverse de cette opération est appelé "unboxing".

```csharp
// Exemple de boxing
int monEntier = 25;
object boiteEntier = monEntier;

// Exemple d'unboxing
int deboiteEntier = (int)boiteEntier;
```

Implementation interne de la class ArrayList en .NET
```csharp
public class ArrayList : IList, ICloneable
{
public virtual int Add(object? value);
```
 











