# Compréhension de la Liaison Tardive

La liaison tardive est une technique permettant de créer une instance d'un type donné et d'inviter ses membres au moment de l'exécution sans avoir de connaissance codée en dur de son existence.

La classe System.Activator est essentielle au processus de liaison tardive dans .NET Core.

```csharp
// Ce programme chargera une bibliothèque externe,
// et créera un objet en utilisant la liaison tardive.
Console.WriteLine("***** Exploration de la Liaison Tardive *****");

// Tentative de chargement d'une copie locale de CarLibrary.
Assembly assembly = null;
try
{
    assembly = Assembly.LoadFrom("BibliotecaVoiture");
}
catch(FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
    return;
}

if(assembly != null)
{
    CreerObjetAvecLiaisonTardive(assembly);
}

Console.ReadLine();

static void CreerObjetAvecLiaisonTardive(Assembly asm)
{
    try
    {
        // Obtenir les métadonnées pour le type VoitureCompacte.
        Type voitureCompacteType = asm.GetType("BibliotecaVoiture.VoitureCompacte");

        // Créer une instance de VoitureCompacte à la volée.
        object obj = Activator.CreateInstance(voitureCompacteType);
        Console.WriteLine("Création d'une {0} en utilisant la liaison tardive!", obj);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
```

Explication du code :

- Le code commence par essayer de charger une bibliothèque externe appelée "BibliotecaVoiture" à l'aide de `Assembly.LoadFrom()`.
- En cas de succès, il appelle une méthode `CreerObjetAvecLiaisonTardive` pour créer un objet en utilisant la liaison tardive.
- Dans `CreerObjetAvecLiaisonTardive`, le type VoitureCompacte est obtenu à partir des métadonnées de la bibliothèque externe à l'aide de `asm.GetType("BibliotecaVoiture.VoitureCompacte")`.
- Ensuite, une instance de VoitureCompacte est créée dynamiquement à l'aide de `Activator.CreateInstance(voitureCompacteType)`.

La liaison tardive est utile dans les scénarios où le type exact à utiliser n'est connu qu'au moment de l'exécution, comme lors du chargement de plugins ou d'extensions externes.

## Avantages de la Liaison Tardive

La liaison tardive offre plusieurs avantages, notamment :

1. **Flexibilité** : Elle permet de créer des instances de types dont les détails sont inconnus au moment de la compilation.
2. **Extensibilité** : Elle facilite l'ajout de nouvelles fonctionnalités à une application sans avoir à recompiler le code existant.
3. **Modularité** : Elle favorise la séparation des préoccupations en permettant à différents modules de s'interfacer de manière dynamique.

## Utilisation de la Liaison Tardive

La liaison tardive est couramment utilisée dans les domaines suivants :

- **Extensions de logiciels** : Pour charger des modules complémentaires ou des plugins à la volée.
- **Interopérabilité** : Pour communiquer avec des composants externes, tels que des bibliothèques COM ou des services web.
- **Tests unitaires** : Pour simuler des comportements spécifiques dans des cas de test sans modifier le code source.

## Considérations de Sécurité

Bien que puissante, la liaison tardive peut présenter des risques de sécurité, notamment en raison de la possibilité d'exécuter du code arbitraire à partir de types chargés dynamiquement. Il est donc important de mettre en place des mécanismes de sécurité appropriés, tels que la vérification des autorisations d'accès et la validation des données.

## Exemple Pratique

Supposons que nous ayons une application qui permet aux utilisateurs de charger des modules d'extension pour ajouter de nouvelles fonctionnalités. Utiliser la liaison tardive nous permettrait de charger ces modules dynamiquement à l'exécution, sans avoir besoin de les incorporer dans le code source principal.

```csharp
// Exemple d'utilisation de la liaison tardive pour charger un module d'extension.
public void ChargerModuleExtension(string cheminModule)
{
    Assembly assemblyExtension = Assembly.LoadFrom(cheminModule);
    Type typeExtension = assemblyExtension.GetType("ModuleExtension.ClasseExtension");
    dynamic instanceExtension = Activator.CreateInstance(typeExtension);
    instanceExtension.Initialiser();
}
```

Dans cet exemple, `ChargerModuleExtension` charge dynamiquement une bibliothèque d'extension, obtient le type de la classe d'extension, crée une instance de cette classe à la volée à l'aide de la liaison tardive, puis appelle une méthode d'initialisation sur cette instance.

La liaison tardive est donc un outil puissant pour rendre les applications plus dynamiques et extensibles, mais elle doit être utilisée avec précaution pour éviter les vulnérabilités de sécurité potentielles.