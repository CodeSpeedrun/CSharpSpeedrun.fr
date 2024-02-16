```csharp
/* Qu'est-ce que le principe d'inversion de dépendance ?
Le principe d'inversion de dépendance (DIP) préconise que les modules de niveau supérieur ne doivent pas dépendre des modules de niveau inférieur. En d'autres termes, les deux devraient dépendre d'abstractions, il ne devrait pas y avoir de couplage fort entre les composants d'un logiciel.
*/

using System;

namespace CSharpSpeedrun.com
{
    // Déclaration d'une interface pour un contrôleur de sauvegarde
    public interface IBackupController
    {
        void PowerOn(); // Méthode pour démarrer la sauvegarde
        void ShutDown(); // Méthode pour arrêter la sauvegarde
    }

    // Implémentation d'une classe de logiciel de sauvegarde Xpress qui implémente l'interface IBackupController
    public class XpressBackupSoftware : IBackupController
    {
        // Implémentation de la méthode PowerOn de l'interface IBackupController
        public void PowerOn()
        {
            Console.WriteLine("La sauvegarde a démarré");
        }

        // Implémentation de la méthode ShutDown de l'interface IBackupController
        public void ShutDown()
        {
            Console.WriteLine("La sauvegarde s'est arrêtée");
        }
    }

    // Classe de contrôleur de sauvegarde qui utilise le principe d'inversion de dépendance
    public class BackupController
    {
        // Attribut pour stocker l'instance d'un contrôleur de sauvegarde
        private IBackupController _backupController;

        // Constructeur prenant une instance de IBackupController comme argument
        public BackupController(IBackupController backupController)
        {
            this._backupController = backupController;
        }

        // Méthode pour démarrer la sauvegarde en utilisant l'instance de IBackupController
        public void PowerOn()
        {
            _backupController.PowerOn();
        }

        // Méthode pour arrêter la sauvegarde en utilisant l'instance de IBackupController
        public void ShutDown()
        {
            _backupController.ShutDown();
        }
    }

    // Classe principale du programme
    class Program
    {
        // Méthode principale du programme
        static void Main(string[] args)
        {
            // Création d'une instance de BackupController en lui passant une instance de XpressBackupSoftware
            BackupController bc = new BackupController(new XpressBackupSoftware());
            
            // Démarrage de la sauvegarde
            bc.PowerOn();
            
            // Arrêt de la sauvegarde
            bc.ShutDown();
        }
    }
}
/*
La sauvegarde a démarré
La sauvegarde s'est arrêtée
*/
```
Ce code illustre le principe d'inversion de dépendance (DIP) en utilisant un exemple de contrôleur de sauvegarde. Le DIP consiste à réduire le couplage entre les modules en s'assurant que les modules de niveau supérieur ne dépendent pas directement des modules de niveau inférieur, mais plutôt des abstractions. Dans cet exemple, la classe `BackupController` dépend de l'interface `IBackupController`, ce qui lui permet d'utiliser n'importe quelle implémentation de cette interface, tel que `XpressBackupSoftware`. Cela rend le code plus flexible et facilite la substitution de différentes implémentations de contrôleurs de sauvegarde sans modifier le code client.

