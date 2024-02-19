Lorsque vous créez une application console .NET Core et utilisez des instructions `Console.WriteLine`, vous utilisez déjà les fonctionnalités de .NET Core. Voici pourquoi :

1. **Type de projet** : Lorsque vous créez une application console .NET Core, vous choisissez explicitement le framework .NET Core comme plateforme cible. Cela signifie que votre application est construite en utilisant le runtime et les bibliothèques .NET Core.

2. **Classe Console** : La classe `Console` elle-même fait partie du framework .NET Core. Elle fournit des fonctionnalités pour interagir avec la fenêtre de la console, notamment la lecture d'entrée, l'écriture de sortie, et plus encore. Lorsque vous utilisez `Console.WriteLine`, vous utilisez des fonctionnalités fournies par .NET Core.

3. **Packages NuGet** : Même si vous n'ajoutez pas explicitement de packages NuGet supplémentaires, le framework .NET Core lui-même est composé de différents packages qui fournissent des fonctionnalités pour différentes tâches. Ces packages sont inclus implicitement lorsque vous créez un projet .NET Core.

4. **Prise en charge multiplateforme** : Une des principales caractéristiques de .NET Core est sa prise en charge multiplateforme. Si vous exécutez votre application console sur différents systèmes d'exploitation tels que Windows, macOS ou Linux, et qu'elle se comporte de manière cohérente, cela indique que vous utilisez bien les fonctionnalités de .NET Core.

En résumé, si vous avez créé une application console .NET Core et utilisez des fonctionnalités de base telles que `Console.WriteLine`, vous exploitez déjà les capacités du framework .NET Core.