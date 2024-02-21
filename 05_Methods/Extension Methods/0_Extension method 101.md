# Compréhension des Méthodes d'Extension

Lorsque vous modifiez directement la définition d'une classe existante, vous courez le risque de rompre la compatibilité ascendante avec les anciens codes qui l'utilisent.

Une façon d'assurer la compatibilité ascendante est de créer une nouvelle classe dérivée de la classe parente existante ; cependant, cela crée alors deux classes à maintenir.

En utilisant les méthodes d'extension, vous pouvez modifier des types sans sous-classer et sans modifier directement le type.

Les méthodes d'extension doivent être définies dans une classe statique (voir Chapitre 5) ; par conséquent, chaque méthode d'extension doit être déclarée avec le mot-clé static.

```csharp
namespace MesMethodesExtension
{
    public static class MesExtensions
    {
        // Cette méthode permet à n'importe quel objet d'afficher l'assembly
        // dans lequel elle est définie.
        public static void AfficherAssemblyDefinissant(this object obj)
        {
            // Implémentation pour afficher l'assembly
            Console.WriteLine(obj.GetType().Assembly);
        }
    }
}
```

Pour utiliser les méthodes d'extension dans la classe, vous devez importer explicitement l'espace de noms MesMethodesExtension, comme nous l'avons fait dans les déclarations en haut du fichier pour exercer les exemples.

## Invocation des Méthodes d'Extension

Les méthodes d'extension ne sont disponibles que dans les espaces de noms qui les définissent ou les importent.

```csharp
using MesMethodesExtension;

class Program
{
    static void Main()
    {
        int monEntier = 12345678;
        monEntier.AfficherAssemblyDefinissant();
    }
}
```

Dans cet exemple, nous avons créé une méthode d'extension appelée `AfficherAssemblyDefinissant` qui affiche l'assembly dans lequel elle est définie. Nous avons ensuite invoqué cette méthode sur un entier pour afficher l'assembly dans lequel le type entier est défini.
