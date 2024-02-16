## Introduction
Dans ce tutoriel, nous allons parcourir le processus de création d'une application console en C# en utilisant .NET 5.0. Nous aborderons des sujets tels que la configuration d'une solution, la création d'un projet d'application console et la compréhension de la structure d'un programme C# simple.

## Configuration de la Solution et du Projet
Tout d'abord, créons une nouvelle solution nommée `AllProjects` et ajoutons un projet d'application console nommé `CSharpApp` à celle-ci.

```bash
dotnet new sln -n AllProjects
dotnet new console -lang c# -n CSharpApp -o .\CSharpApp -f net5.0
dotnet sln .\AllProjects.sln add .\CSharpApp
```

## Compréhension de la Structure du Programme
Plongeons dans la structure du programme C# créé dans `CSharpApp/Program.cs`.

```csharp
using System;

namespace CSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg => {0}", args[i]);
            }
        }
    }
}
```

### Méthode Main
La méthode `Main` sert de point d'entrée de l'application. Elle accepte un tableau de chaînes de caractères (`args`) en tant que paramètres, qui peuvent contenir des arguments de ligne de commande passés au programme.

```csharp
static void Main(string[] args)
{
    // Logique de l'application
}
```

### Arguments de Ligne de Commande
Le paramètre `args` permet d'accéder aux arguments de ligne de commande passés lors de l'exécution du programme. Ces arguments peuvent être utilisés à l'intérieur de la méthode `Main`, comme démontré dans l'extrait de code ci-dessus.

## Objet Application
La classe contenant la méthode `Main` sert d'objet d'application. Il est possible pour une application d'avoir plusieurs objets d'application, utiles pour des scénarios tels que les tests unitaires. La spécification de l'objet de démarrage peut être effectuée via le fichier de projet ou les propriétés du projet Visual Studio.

### Objet de Démarrage
Pour spécifier l'objet de démarrage, vous pouvez utiliser l'élément `<StartupObject>` dans le fichier de projet ou le menu déroulant Objet de Démarrage dans Visual Studio.

## Membres Statiques
Les membres statiques sont définis au niveau de la classe plutôt qu'au niveau de l'objet. Ils peuvent être invoqués sans avoir besoin de créer une nouvelle instance de classe.

### Variations de la Méthode Main
La méthode `Main` peut avoir des variations dans sa signature. Elle peut retourner un entier ou void et accepter des arguments de ligne de commande ou non.

#### Méthode Main avec Type de Retour Integer
```csharp
static int Main(string[] args)
{
    // Logique de l'application
    return 0; // Doit retourner une valeur avant de quitter
}
```

#### Méthode Main avec Type de Retour Void et Aucun Paramètre
```csharp
static void Main()
{
    // Logique de l'application
}
```

### Méthode Main Asynchrone et Gestion des Arguments de Ligne de Commande en C#
En C#, la méthode `Main()` peut maintenant être asynchrone, permettant ainsi des capacités de programmation asynchrones. La programmation asynchrone est couverte en détail dans le chapitre 15. Ici, nous présentons les quatre signatures supplémentaires pour la méthode `Main()` :

- `static Task Main()`
- `static Task<int> Main()`
- `static Task Main(string[])`
- `static Task<int> Main(string[])`

Il est à noter que à la fois la classe (`Programme`) et les méthodes `Main()` peuvent être supprimées. Cependant, notez que même si vous construisez une méthode `Main()` prototypée pour retourner `void`, la valeur `0` est automatiquement retournée.

### Accès aux Arguments de Ligne de Commande
Vous pouvez accéder aux arguments de ligne de commande en utilisant la méthode statique `GetCommandLineArgs()` du type `System.Environment`. Exemple :

```csharp
string[] lesArgs = Environment.GetCommandLineArgs();
foreach(string arg in lesArgs)
{
    Console.WriteLine("Arg: {0}", arg);
}
```

### Spécification des Drapeaux de Ligne de Commande
Pour des besoins de test, vous pouvez spécifier des drapeaux de ligne de commande possibles. Dans Visual Studio, vous pouvez le faire en :

1. Cliquant avec le bouton droit sur le nom du projet dans l'Explorateur de Solutions.
2. Sélectionnant Propriétés.
3. Accédant à l'onglet Déboguer sur le côté gauche.
4. Spécifiant les valeurs en utilisant la zone de texte "Arguments de l'application".

### Affichage des Détails de l'Environnement
Pour accéder et afficher les détails de l'environnement, vous pouvez utiliser des méthodes de la classe `Environment`. Exemple :

```csharp
static void AfficherDetailsEnvironnement()
{
    // Afficher les disques sur cette machine,
    foreach (string disque in Environment.GetLogicalDrives())
    {
        Console.WriteLine("Disque: {0}", disque);
    }
    Console.WriteLine("OS: {0}", Environment.OSVersion);
    Console.WriteLine("Nombre de processeurs: {0}", Environment.ProcessorCount);
    Console.WriteLine("Version .NET Core: {0}", Environment.Version);
}
```

### Utilisation de la Classe Console
La classe `Console` encapsule les manipulations d'entrée, de sortie et de flux d'erreur pour les applications basées sur la console. Exemple d'utilisation :

```csharp
Console.WriteLine("{0}, Numéro {0}, Numéro {0}", 7);
Console.WriteLine("Format c: {0:c}", 7777);
// Sortie: Format c: 7 777,00 €
```


 ## Conclusion
Comprendre la structure d'une application console en C# est essentiel pour créer des programmes robustes et efficaces. En saisissant des concepts tels que la méthode `Main` et l'objet d'application, vous pouvez créer et gérer efficacement des projets C#.
