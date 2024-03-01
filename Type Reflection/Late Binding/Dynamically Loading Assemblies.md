# Chargement Dynamique des Assemblages

Il arrive parfois que vous ayez besoin de charger des assemblages de manière dynamique et programmative, même s'ils ne sont pas référencés dans le manifeste.

```csharp
using System;
using System.Reflection;
using System.IO; // Pour la définition de FileNotFoundException.

Console.WriteLine("***** Visionneur d'Assemblages Externes *****");
string nomAssemblage = "";
Assembly assemblage = null;

do
{
    Console.WriteLine("\nEntrez le nom d'un assemblage à évaluer");
    Console.Write("ou entrez Q pour quitter : ");
    // Obtenez le nom de l'assemblage.
    nomAssemblage = Console.ReadLine();

    // L'utilisateur souhaite-t-il quitter ?
    if (nomAssemblage.Equals("Q", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }

    // Essayez de charger l'assemblage.
    try
    {
        assemblage = Assembly.LoadFrom(nomAssemblage);
        AfficherTypesDansAssemblage(assemblage);
    }
    catch
    {
        Console.WriteLine("Désolé, l'assemblage spécifié est introuvable.");
    }
} while (true);

static void AfficherTypesDansAssemblage(Assembly assemblage)
{
    Console.WriteLine("\n***** Types dans l'Assemblage *****");
    Console.WriteLine("->{0}", assemblage.FullName);
    Type[] types = assemblage.GetTypes();

    foreach (Type type in types)
    {
        Console.WriteLine("Type: {0}", type);
    }

    Console.WriteLine("");
}
```

## Explication du Code
Ce code permet de charger dynamiquement des assemblages à partir de fichiers DLL externes. L'utilisateur est invité à entrer le nom de l'assemblage à charger, puis le code tente de charger cet assemblage à l'aide de la méthode `Assembly.LoadFrom`. En cas d'erreur, une exception est capturée et un message approprié est affiché à l'utilisateur.

La méthode `AfficherTypesDansAssemblage` prend un objet `Assembly` en entrée et affiche les différents types contenus dans cet assemblage.

```csharp
using System;
using System.Linq;
using System.Reflection;

Console.WriteLine("***** L'Application Réflecteur d'Assemblage du Framework *****\n");

// Charger ExampleLibrary.dll
var nomAffiche = "ExampleLibrary, Version=1.0.0.0, Culture=\"\", PublicKeyToken=null";
Assembly assemblage = Assembly.Load(nomAffiche);
AfficherInfos(assemblage);
Console.WriteLine("Terminé !");
Console.ReadLine();

private static void AfficherInfos(Assembly assemblage)
{
    Console.WriteLine("***** Informations sur l'Assemblage *****");
    Console.WriteLine($"Nom de l'assemblage: {assemblage.GetName().Name}");
    Console.WriteLine($"Version de l'assemblage: {assemblage.GetName().Version}");
    Console.WriteLine($"Culture de l'assemblage: {assemblage.GetName().CultureInfo.DisplayName}");
    Console.WriteLine("\nVoici les énumérations publiques :");

    // Utilisez une requête LINQ pour trouver les énumérations publiques.
    Type[] types = assemblage.GetTypes();
    var enumsPublics =
        from e in types
        where e.IsEnum && e.IsPublic
        select e;

    foreach (var enumeration in enumsPublics)
    {
        Console.WriteLine(enumeration);
    }
}
```

## Explication du Code
Ce code charge l'assemblage "ExampleLibrary.dll" et affiche des informations sur cet assemblage telles que le nom, la version et la culture. Il utilise également LINQ pour trouver et afficher toutes les énumérations publiques présentes dans cet assemblage.

Le chargement d'assemblages de manière dynamique est une pratique courante dans le développement logiciel, car elle permet d'étendre les fonctionnalités d'une application sans avoir à recompiler le code source. Cela peut être utile dans des cas où des fonctionnalités supplémentaires doivent être chargées en fonction de conditions spécifiques ou de configurations utilisateur.