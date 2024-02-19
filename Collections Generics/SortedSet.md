# Utilisation de la classe SortedSet<T>

La classe `SortedSet<T>` est utile car elle garantit automatiquement que les éléments dans l'ensemble sont triés lors de l'insertion ou de la suppression d'éléments. Cependant, vous devez informer la classe `SortedSet<T>` exactement comment vous voulez qu'elle trie les objets, en passant en argument de constructeur un objet qui implémente l'interface générique `IComparer<T>`.

## Implémentation d'un comparateur personnalisé

Pour trier les éléments dans le `SortedSet<T>`, vous devez fournir une implémentation de l'interface `IComparer<T>`. Par exemple, supposons que nous ayons une classe `Personne` avec des propriétés telles que `Prénom`, `Nom` et `Âge`, et que nous voulons trier les personnes par âge.

```csharp
class TriPersonnesParAge : IComparer<Personne>
{
    public int Comparer(Personne premierePersonne, Personne deuxiemePersonne)
    {
        if (premierePersonne?.Age > deuxiemePersonne?.Age)
        {
            return 1;
        }
        if (premierePersonne?.Age < deuxiemePersonne?.Age)
        {
            return -1;
        }
        return 0;
    }
}
```

## Utilisation du SortedSet

Nous pouvons maintenant utiliser notre classe `SortedSet<T>` avec notre comparateur personnalisé pour trier les objets `Personne` par âge.

```csharp
static void UtiliserSortedSet()
{
    // Création de personnes avec différents âges.
    SortedSet<Personne> ensemblePersonnes = new SortedSet<Personne>(new TriPersonnesParAge())
    {
        new Personne {Prenom = "Homer", Nom = "Simpson", Age = 47},
        new Personne {Prenom = "Marge", Nom = "Simpson", Age = 45},
        new Personne {Prenom = "Lisa", Nom = "Simpson", Age = 9},
        new Personne {Prenom = "Bart", Nom = "Simpson", Age = 8}
    };
    
    // Les éléments sont maintenant triés par âge !
    foreach (Personne p in ensemblePersonnes)
    {
        Console.WriteLine(p);
    }
    Console.WriteLine();
    
    // Ajout de nouvelles personnes avec différents âges.
    ensemblePersonnes.Add(new Personne { Prenom = "Saku", Nom = "Jones", Age = 1 });
    ensemblePersonnes.Add(new Personne { Prenom = "Mikko", Nom = "Jones", Age = 32 });
    
    // Toujours trié par âge !
    foreach (Personne p in ensemblePersonnes)
    {
        Console.WriteLine(p);
    }
}
```

Dans cet exemple, nous avons utilisé la classe `SortedSet<T>` avec un comparateur personnalisé pour trier les objets `Personne` par âge. Les objets `Personne` sont ajoutés à l'ensemble, et ils sont automatiquement triés en fonction de leur âge grâce à la logique définie dans la classe `TriPersonnesParAge`.