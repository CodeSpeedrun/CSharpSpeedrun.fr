### Interfaces en tant que valeurs de retour
```csharp
// Définir une méthode qui recherche la première forme prenant en charge une interface spécifique dans un tableau de formes.
static ISharp TrouverPremièreFormeTranchante(Sharp[] listeFormes)
{
    foreach (Sharp forme in listeFormes)
    {
        // Vérifier si la forme actuelle implémente l'interface ISharp.
        if (forme is ISharp tranchant)
        {
            // Si trouvé, retourner la référence à la première forme correspondante.
            return tranchant;
        }
    }
    // Si aucune forme prenant en charge l'interface n'est trouvée, retourner null.
    return null;
}

// Méthode principale pour démontrer l'utilisation des interfaces.
static void Main(string[] args)
{
    Console.WriteLine("***** Amusement avec les Interfaces *****\n");

    // Créer un tableau de différentes formes.
    Sharp[] mesFormes = { new Polygon(), new Oval(), new Rectangle(), new Oval("Alice") };

    // Trouver la première forme prenant en charge l'interface ISharp.
    ISharp premierElementTranchant = TrouverPremièreFormeTranchante(mesFormes);

    // Pour éviter une NullReferenceException, utiliser l'opérateur de conditionnalité null lors de l'accès aux propriétés.
    Console.WriteLine("L'élément a {0} bords tranchants", premierElementTranchant?.Edges);
}
```

**Interfaces en tant que valeurs de retour**

Dans cet extrait de code, nous démontrons l'utilisation des interfaces en C#. Une interface définit un contrat pour les classes, spécifiant les méthodes, propriétés, événements ou indexeurs que les classes implémentant doivent fournir.

La méthode `TrouverPremièreFormeTranchante` accepte un tableau d'objets `Sharp` (`Sharp[] listeFormes`) et recherche la première forme qui implémente l'interface `ISharp`. Si elle est trouvée, elle retourne une référence vers cette forme. Sinon, elle retourne null.

**Concepts clés :**
- **Interfaces** : Les interfaces définissent un contrat que les classes peuvent implémenter, garantissant que certains membres sont fournis.
- **Polymorphisme** : En retournant des références d'interface, la méthode peut fonctionner sur différents types d'objets partageant une interface commune.
- **Boucle foreach** : Cette boucle itère à travers chaque élément dans le tableau de formes.
- **Opérateur is** : Vérifie si un objet est compatible avec un type ou une interface donnée.
- **Opérateur de conditionnalité null** : Assure un accès sécurisé aux propriétés ou méthodes des objets potentiellement nuls.

**Notes supplémentaires :**
- **Méthode Main** : C'est le point d'entrée du programme où la démonstration de l'utilisation de l'interface se produit.
- **Initialisation du tableau** : Diverses formes telles que `Polygon`, `Oval` et `Rectangle` sont instanciées et stockées dans le tableau `mesFormes`.
- **Accès aux propriétés** : La propriété `Edges` de la forme implémentant l'interface `ISharp` est accédée en utilisant l'opérateur de conditionnalité null (`?.`). Cela évite une `NullReferenceException` si `premierElementTranchant` est null.

En utilisant des interfaces, les développeurs peuvent écrire un code plus flexible et réutilisable, permettant un comportement polymorphe et améliorant la maintenabilité et l'extensibilité du code.