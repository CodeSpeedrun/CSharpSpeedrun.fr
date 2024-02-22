# Les Indexeurs en C#

Les indexeurs en C# permettent de concevoir des classes et des structures personnalisées pouvant être indexées comme un tableau standard en définissant une méthode indexeur.

## Utilisation d'un Indexeur Personnalisé

```csharp
PersonnesCollection mesPersonnes = new PersonnesCollection();
// Ajouter des objets avec la syntaxe de l'indexeur.
mesPersonnes[0] = new Personne("Homer", "Simpson", 40);
```

La méthode indexeur est ajoutée à la définition de classe existante, permettant un accès indexé aux éléments de la collection.

```csharp
using System;
using System.Collections;
using System.Collections.Generic;

public class Personne
{
    public string Nom { get; set; }
    public int Age { get; set; }
}

public class PersonnesCollection : IEnumerable
{
    private ArrayList listePersonnes = new ArrayList();

    public Personne this[int index]
    {
        get => (Personne)listePersonnes[index];
        set => listePersonnes.Insert(index, value);
    }

    public IEnumerator GetEnumerator()
    {
        return listePersonnes.GetEnumerator();
    }
}

class Program
{
    static void Main(string[] args)
    {
        PersonnesCollection personnes = new PersonnesCollection();

        personnes[0] = new Personne { Nom = "Alice", Age = 30 };
        personnes[1] = new Personne { Nom = "Bob", Age = 40 };
        personnes[2] = new Personne { Nom = "Charlie", Age = 25 };

        foreach (Personne p in personnes)
        {
            Console.WriteLine($"Nom: {p.Nom}, Age: {p.Age}");
        }
    }
}

```
Le code fourni définit une classe `PersonnesCollection` qui implémente l'interface non générique `IEnumerable` et fournit un indexeur pour accéder aux éléments par index. Bien que ce code puisse fonctionner, il n'est pas considéré comme une bonne pratique car il utilise la collection non générique `ArrayList`, qui n'est pas sûre au niveau des types et nécessite des conversions explicites.

Pour améliorer le code, vous devriez utiliser des collections génériques et implémenter l'interface `IEnumerable<T>` ainsi que sa méthode `GetEnumerator` pour garantir la sécurité des types et de meilleures performances. Voici comment vous pouvez refactoriser le code :

```csharp
using System.Collections;
using System.Collections.Generic;

public class PersonnesCollection : IEnumerable<Personne>
{
    private List<Personne> listePersonnes = new List<Personne>();

    public Personne this[int index]
    {
        get => listePersonnes[index];
        set => listePersonnes[index] = value;
    }

    public IEnumerator<Personne> GetEnumerator()
    {
        return listePersonnes.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
```

Dans cette version refactorisée :
- Nous utilisons une liste générique `List<Personne>` plutôt que `ArrayList` pour la sécurité des types.
- La classe implémente `IEnumerable<Personne>` pour en faire une collection générique.
- La méthode `GetEnumerator` est implémentée de manière explicite pour les interfaces génériques et non génériques, assurant que les instances de `PersonnesCollection` peuvent être itérées à l'aide de boucles foreach.

Cette approche garantit la sécurité des types et offre de meilleures performances par rapport à l'utilisation de collections non génériques avec des conversions explicites.
## Utilisation de Types Génériques

Bien que la création de méthodes indexeurs soit courante lors de la création de collections personnalisées, il est important de se rappeler que les types génériques offrent cette fonctionnalité nativement.

```csharp
List<Personne> mesPersonnes = new List<Personne>();
mesPersonnes.Add(new Personne("Lisa", "Simpson", 9));
mesPersonnes.Add(new Personne("Bart", "Simpson", 7));
// Modifier la première personne avec l'indexeur.
mesPersonnes[0] = new Personne("Maggie", "Simpson", 2);
```

Les types génériques tels que `List<T>` permettent un accès indexé et fournissent une alternative aux indexeurs personnalisés.

## Remarques Supplémentaires

- Les indexeurs personnalisés offrent un moyen flexible d'accéder aux éléments d'une classe ou d'une structure.
- Les types génériques comme `List<T>` simplifient souvent la manipulation de collections en fournissant des fonctionnalités d'indexation prédéfinies.
- Il est important de choisir la bonne approche en fonction des besoins spécifiques de votre application.