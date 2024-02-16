## Notes de développement en C# avec .NET 5 et Visual Studio 2019

Ces notes couvrent la configuration de votre environnement pour le développement en C# avec .NET 5 et Visual Studio 2019. Nous passerons en revue les outils essentiels, la création de projets et comment exécuter votre application.

### Prérequis :
- **SDK .NET 5 :** Cela inclut le runtime nécessaire pour exécuter les applications .NET. Téléchargez et installez-le depuis [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).
- **Visual Studio 2019 :** Choisissez les charges de travail en fonction de vos besoins de développement (expliqué plus tard).

### Vérification de votre configuration :
- Ouvrez une invite de commande et exécutez `dotnet --version`. Cela devrait afficher la version installée du SDK .NET.
- Utilisez `dotnet --info` pour voir des informations détaillées sur les installations .NET.
- `dotnet --list-runtimes` et `dotnet --list-sdks` montrent respectivement les runtimes et SDK disponibles.

### Compréhension des runtimes :
- **Microsoft.AspNetCore.App :** Utilisé pour construire des applications web ASP.NET Core.
- **Microsoft.NETCore.App :** Le runtime de base pour les applications .NET Core.
- **Microsoft.WindowsDesktop.App :** Cible les applications de bureau WinForms et WPF.

### Installation des charges de travail de Visual Studio 2019 :
Pendant l'installation, choisissez les charges de travail suivantes :
- **Développement .NET pour bureau :** Pour les applications WinForms et WPF.
- **Développement ASP.NET et web :** Pour les applications web utilisant ASP.NET Core.
- **Stockage et traitement de données :** Pour travailler avec des bases de données et d'autres sources de données.
- **Développement .NET Core multiplateforme :** Pour créer des applications qui s'exécutent sur différentes plateformes.

### Outils supplémentaires :
Sur l'onglet "Composants individuels", sélectionnez :
- **Concepteur de classes :** Outil visuel pour concevoir des classes et leurs relations.
- **Git pour Windows :** Système de contrôle de version pour gérer les modifications de code.
- **Extension GitHub pour Visual Studio :** Intègre les services GitHub dans Visual Studio.

### Configuration de l'interface utilisateur de la console :
- Utilisez `Console.Title` pour définir le titre de la fenêtre de la console (par exemple, `Console.Title = "Mon application géniale";`).
- Changez les couleurs du texte et de l'arrière-plan avec `Console.ForegroundColor` et `Console.BackgroundColor`.

### Création d'un projet .NET Core :
1. Ouvrez Visual Studio et créez un nouveau projet.
2. Sélectionnez "Application console" sous ".NET Core".
3. Dans le fichier du projet (`*.csproj`), vous verrez `<TargetFramework>netcoreapp3.1</TargetFramework>`. Cela spécifie la version du runtime (3.1 dans ce cas).

### Versions du framework cible :
| Version       | Version du langage C# | Par défaut |
| ------------- | --------------------- | ---------- |
| .NET 5.x      | C# 9.0                | Oui        |
| .NET Core 3.x | C# 8.0                | Oui        |
| .NET Core 2.x | C# 7.3                | Non        |

### Exécution de votre application :
- **Visual Studio :** Appuyez sur Ctrl+F5 pour exécuter l'application dans l'IDE.
- **Ligne de commande :** Ouvrez une invite de commande dans le répertoire de votre projet et tapez `dotnet run`.

### Concepteur de types visuels :
1. Cliquez avec le bouton droit sur votre projet, sélectionnez "Ajouter" -> "Nouvel élément".
2. Choisissez "Diagramme de classes" et ajoutez-le à votre projet.
3. Cela vous permet de concevoir visuellement des classes et leurs relations.

### Ressources supplémentaires :
- Documentation officielle de .NET de Microsoft : [https://docs.microsoft.com/en-us/dotnet/](https://docs.microsoft.com/en-us/dotnet/)
- Documentation de Visual Studio : [https://docs.microsoft.com/en-us/visualstudio/](https://docs.microsoft.com/en-us/visualstudio/)
- Tutoriels d'apprentissage de C# : [https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/)

### N'oubliez pas :
- Ces notes fournissent un point de départ de base. Explorez d'autres ressources pour des sujets plus avancés et des fonctionnalités supplémentaires.
- Adaptez les étapes fournies en fonction de vos objectifs de développement spécifiques et du type de projet choisi.