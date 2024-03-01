# Réflexion sur les Paramètres et les Valeurs de Retour des Méthodes

La réflexion en C# permet d'explorer et de manipuler les métadonnées d'un programme à l'exécution. Parmi les aspects les plus importants de la réflexion, nous examinons ici comment lister les méthodes d'un type donné en détaillant les paramètres et les valeurs de retour.

## Listing des Méthodes avec Détails des Paramètres et des Valeurs de Retour

```csharp
static void AfficherInformationsMethodes(Type type)
{
    Console.WriteLine("***** Méthodes *****");
    MethodInfo[] methodes = type.GetMethods();
    foreach (MethodInfo methode in methodes)
    {
        // Obtenir le type de retour.
        string typeRetour = methode.ReturnType.FullName;
        string infosParam = "( ";
        // Obtenir les paramètres.
        foreach (ParameterInfo parametre in methode.GetParameters())
        {
            infosParam += string.Format("{0} {1} ", parametre.ParameterType, parametre.Name);
        }
        infosParam += " )";
        // Afficher la signature de la méthode.
        Console.WriteLine("->{0} {1} {2}", typeRetour, methode.Name, infosParam);
    }
    Console.WriteLine();
}
```

### Explications
- La méthode `AfficherInformationsMethodes` prend un objet de type `Type` en argument.
- Elle récupère toutes les méthodes du type spécifié à l'aide de `GetMethods()`.
- Pour chaque méthode, elle obtient le type de retour et les informations sur les paramètres à l'aide de `ReturnType` et `GetParameters()` respectivement.
- Ensuite, elle affiche la signature de la méthode, comprenant le type de retour, le nom de la méthode et les informations sur les paramètres.

## Listing des Méthodes sans Détails des Paramètres

```csharp
static void AfficherNomsMethodes(Type type)
{
    Console.WriteLine("***** Méthodes *****");
    var nomsMethodes = from m in type.GetMethods() select m;
    foreach (var nom in nomsMethodes)
    {
        Console.WriteLine("->{0}", nom);
    }
    Console.WriteLine();
}
```

### Explications
- La méthode `AfficherNomsMethodes` prend également un objet de type `Type` en argument.
- Elle récupère simplement les noms des méthodes du type spécifié à l'aide de `GetMethods()` et les affiche.

La réflexion en C# offre une puissante capacité à explorer et manipuler les structures des programmes dynamiquement. Ces exemples démontrent comment lister les méthodes d'un type donné en fournissant ou non des détails sur les paramètres et les valeurs de retour. Cette compréhension est cruciale pour interagir efficacement avec les bibliothèques et les frameworks .NET.
```
Dans ces exemples, nous avons utilisé des noms de méthodes et des données fictifs pour illustrer les concepts.