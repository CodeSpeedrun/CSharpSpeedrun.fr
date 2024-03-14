# Guide Complet de .NET Core

La plateforme .NET permet à divers langages de programmation (C#, VB.NET, F#) d'interagir et d'utiliser des API puissantes. Ce guide explique les concepts clés de .NET Core, y compris son environnement d'exécution, ses bibliothèques de base, ses assemblages, et plus encore.

## Principaux Éléments de Construction:

* **Environnement d'Exécution .NET Core:** Combine le CoreCLR et CoreFX pour fournir des fonctionnalités de base et des types de base pour les applications .NET Core.
* **Système de Types Commun (CTS):** Définit un ensemble de types de données standard et des règles pour tous les langages compatibles, assurant l'interopérabilité entre langages.
* **Spécification de Langage Commun (CLS):** Un ensemble de directives pour les développeurs de compilateurs afin de garantir que leurs langages s'intègrent parfaitement avec l'écosystème .NET.
* **.NET Standard:** Définit une surface d'API unifiée à laquelle différentes implémentations (comme .NET Core et .NET Framework) peuvent adhérer, permettant le partage de code entre les plateformes.

## Compréhension du Code Géré et des Assemblages:

* **Code Géré:** Code spécifiquement conçu pour s'exécuter dans l'environnement d'exécution .NET Core.
* **Code Non Géré:** Code qui ne peut pas être directement hébergé par l'environnement d'exécution .NET Core (par exemple, du code C++).
* **Assemblages:** Unités binaires contenant du code géré, y compris des instructions, des métadonnées et un manifeste (décrivant l'assemblage lui-même).
* **CIL (Common Intermediate Language):** Une représentation intermédiaire du code (également connue sous le nom de IL ou MSIL) qui est indépendante de la plateforme et compilée en code machine par le compilateur JIT (Just-In-Time).

## Compilation et Exécution du Code:

* **Compilateur JIT:** Traduit le code CIL en code machine natif pour la plateforme spécifique pendant l'exécution, optimisant les performances.
* **Métadonnées:** Informations intégrées dans les assemblages décrivant les types, les méthodes et d'autres détails, utilisées par l'environnement d'exécution pour la réflexion et les opérations dynamiques.

## Concepts et Utilitaires Essentiels:

* **Délégués:** Des pointeurs de fonction sécurisés permettant aux objets de référencer les méthodes d'autres objets, permettant des mécanismes de rappel et de gestion d'événements.
* **Réflexion:** Capacité à inspecter et manipuler des types à l'exécution en utilisant des espaces de noms comme `System.Reflection` et `System.Reflection.Emit`.
* **Espaces de Noms:** Regroupements logiques de types associés au sein des assemblages, améliorant l'organisation et la clarté du code.
* **Packages NuGet:** Un système de gestion de paquets pour ajouter des bibliothèques externes et des outils à des projets.
* **ildasm.exe:** Un utilitaire pour désassembler les assemblages en texte lisible par l'homme, révélant le code CIL, les métadonnées et le manifeste.

## Notes Additionnelles:

* .NET Core offre une bibliothèque de classes de base plus légère par rapport au .NET Framework, mais .NET Standard permet le partage de code entre eux.
* Comprendre ces concepts est crucial pour développer des applications robustes et efficaces dans l'écosystème .NET Core.