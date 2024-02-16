## Portée en C#

En C#, une portée est créée en utilisant des accolades `{}`. Vous avez rencontré cette syntaxe dans divers contextes tels que les espaces de noms, les classes et les méthodes.

### Exemple :
```csharp
using System;

namespace ExemplePortee
{
    class Programme
    {
        static void Main()
        {
            // Ceci est la portée de la méthode Main
            int x = 10; // La variable 'x' est déclarée dans la portée de la méthode Main
            {
                // Ceci est une portée interne
                int y = 20; // La variable 'y' est déclarée dans ce bloc interne
                Console.WriteLine(x + y); // Accès aux variables de la portée externe et interne
            } // Fin de la portée interne
            // 'y' n'est pas accessible ici; elle est hors de portée
            Console.WriteLine(x); // La variable 'x' est accessible ici
        } // Fin de la portée de la méthode Main
    } // Fin de la portée de la classe Programme
} // Fin de la portée du namespace
```

### Explication :
- **Accolades `{}`** : En C#, les accolades définissent le début et la fin d'une portée.
- **Portée de Namespace** : Les accolades définissent la portée d'un namespace. Tout ce qui se trouve entre les accolades appartient à ce namespace.
- **Portée de Classe** : De même, les accolades définissent la portée d'une classe. Tous les membres et méthodes entre les accolades appartiennent à cette classe.
- **Portée de Méthode** : Les accolades d'une méthode définissent la portée de cette méthode. Les variables déclarées dans la méthode ne sont accessibles que dans la portée de la méthode.
- **Portée des Variables** : Les variables déclarées dans une portée sont accessibles uniquement dans cette portée ou dans ses portées imbriquées. Une fois que la portée se termine, les variables ne sont plus accessibles.
- **Portées Emboîtées** : Les portées peuvent être imbriquées les unes dans les autres. Les portées internes ont accès aux variables déclarées dans les portées externes, mais pas inversement.

### Informations Additionnelles :
- **Résolution de Portée** : Comprendre la portée est crucial pour éviter les conflits de noms et gérer efficacement les durées de vie des variables.
- **Portée Globale** : Les variables déclarées en dehors de toute méthode ou classe ont une portée globale et peuvent être accessibles de n'importe où dans le fichier.
- **Portée Locale** : Les variables déclarées dans une méthode ou un bloc ont une portée locale et ne sont accessibles que dans cette méthode ou ce bloc.
- **Hiérarchie de Portée** : La hiérarchie des portées détermine la visibilité et l'accessibilité des variables et des membres.
- **Portée et Gestion de la Mémoire** : Gérer correctement la portée des variables aide à une utilisation efficace de la mémoire et empêche les fuites de mémoire.