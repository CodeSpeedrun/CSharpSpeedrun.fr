```csharp
// Début des notes

// Méthode privée statique utilisant un dictionnaire pour stocker des objets Personne.
private static void UtiliserDictionnaire()
{
    // Peupler le dictionnaire en utilisant la méthode Add().
    Dictionary<string, Personne> personnesA = new Dictionary<string, Personne>();
    personnesA.Add("Homer", new Personne { Prenom = "Homer", Nom = "Simpson", Age = 47 });
    personnesA.Add("Marge", new Personne { Prenom = "Marge", Nom = "Simpson", Age = 45 });
    personnesA.Add("Lisa", new Personne { Prenom = "Lisa", Nom = "Simpson", Age = 9 });

    // Récupérer l'objet correspondant à la clé "Homer".
    Personne homer = personnesA["Homer"];
    Console.WriteLine(homer);

    // Peupler le dictionnaire en utilisant la syntaxe d'initialisation.
    Dictionary<string, Personne> personnesB = new Dictionary<string, Personne>()
    {
        { "Homer", new Personne { Prenom = "Homer", Nom = "Simpson", Age = 47 } },
        { "Marge", new Personne { Prenom = "Marge", Nom = "Simpson", Age = 45 } },
        { "Lisa", new Personne { Prenom = "Lisa", Nom = "Simpson", Age = 9 } }
    };

    // Récupérer l'objet correspondant à la clé "Lisa".
    Personne lisa = personnesB["Lisa"];
    Console.WriteLine(lisa);
}

// Peupler le dictionnaire en utilisant la syntaxe d'initialisation de dictionnaire.
Dictionary<string, Personne> personnesC = new Dictionary<string, Personne>()
{
    ["Homer"] = new Personne { Prenom = "Homer", Nom = "Simpson", Age = 47 },
};

// Fin des notes
```

Dans ce code, nous avons une méthode `UtiliserDictionnaire` qui illustre l'utilisation de dictionnaires en C#. Un dictionnaire est une collection qui stocke des paires clé-valeur, où chaque élément est associé à une clé unique.

- La première partie du code utilise la méthode `Add()` pour peupler un dictionnaire `personnesA` avec des objets `Personne`, où chaque objet est associé à un prénom comme clé. Ensuite, nous récupérons et affichons l'objet correspondant à la clé "Homer".

- Ensuite, nous utilisons la syntaxe d'initialisation de dictionnaire pour peupler un autre dictionnaire `personnesB` avec les mêmes objets `Personne`. Cette syntaxe permet une initialisation concise du dictionnaire en spécifiant les paires clé-valeur entre accolades.

- Enfin, nous utilisons une autre syntaxe d'initialisation de dictionnaire pour peupler un troisième dictionnaire `personnesC`, cette fois-ci avec une seule entrée pour "Homer". Cette syntaxe utilise des crochets pour spécifier la clé et l'assignation de valeur.

Ce code démontre différentes façons de peupler un dictionnaire en C# et d'accéder à ses éléments à l'aide des clés associées.