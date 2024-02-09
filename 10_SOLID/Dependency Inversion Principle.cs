/* What is Dependency Inversion Principle?
DIP advocates that upper-level modules should not be dependent on low-level modules. In other words, both should depend upon abstractions, there should not be tight coupling among components of a software.
*/
 using System;

namespace CSharpSpeedrun.com
{
    public interface IBackupController
    {
        void PowerOn();
        void ShutDown();
    }

    public class XpressBackupSoftware : IBackupController
    {
        public void PowerOn()
        {
            Console.WriteLine("Backup started");
        }

        public void ShutDown()
        {
            Console.WriteLine("Backup stopped");
        }
    }

    public class BackupController
    {
        IBackupController _backupController;

        public BackupController(IBackupController backupController)
        {
            this._backupController = backupController;
        }

        public void PowerOn()
        {
            _backupController.PowerOn();
        }

        public void ShutDown()
        {
            _backupController.ShutDown();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BackupController bc = new BackupController(new XpressBackupSoftware());
            bc.PowerOn();
            bc.ShutDown();
        }
    }
}
/*
Backup started
Backup stopped
*/