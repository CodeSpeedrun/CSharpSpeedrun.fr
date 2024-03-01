# Travailler avec le délégué ThreadStart

```csharp
public class Imprimeur
{
    public void ImprimerNombres()
    {
        // Afficher les informations sur le thread.
        Console.WriteLine("-> {0} est en train d'exécuter ImprimerNombres()",
        Thread.CurrentThread.Name);
        // Afficher les nombres.
        Console.Write("Vos nombres : ");
        for(int i = 10; i < 20; i++)
        {
            Console.Write("{0}, ", i);
            Thread.Sleep(1500);
        }
        Console.WriteLine();
    }
}
```

Lorsque vous travaillez avec des threads en C#, vous pouvez utiliser le délégué `ThreadStart` pour démarrer l'exécution d'une méthode sur un thread séparé. Le délégué `ThreadStart` est conçu pour encapsuler une méthode ne prenant pas d'arguments et ne renvoyant pas de valeur. Dans cet exemple, nous avons une classe `Imprimeur` avec une méthode `ImprimerNombres()` qui affiche une séquence de nombres de 10 à 19 avec un délai de 1,5 seconde entre chaque nombre.

```csharp
using System;
using System.Threading;

class ProgrammePrincipal
{
    static void Main()
    {
        Console.WriteLine("***** L'application de gestion de threads *****\n");
        Console.Write("Combien de threads souhaitez-vous utiliser ? [1] ou [2] : ");
        string nombreDeThreads = Console.ReadLine();

        // Nommer le thread principal.
        Thread threadPrincipal = Thread.CurrentThread;
        threadPrincipal.Name = "Principal";

        // Afficher les informations sur le thread.
        Console.WriteLine("-> {0} est en train d'exécuter Main()", Thread.CurrentThread.Name);

        // Créer une instance de la classe Imprimeur.
        Imprimeur imprimeur = new Imprimeur();

        switch(nombreDeThreads)
        {
            case "2":
                // Créer un nouveau thread pour imprimer les nombres.
                Thread threadSecondaire = new Thread(new ThreadStart(imprimeur.ImprimerNombres));
                threadSecondaire.Name = "Secondaire";
                threadSecondaire.Start();
                break;
                
            case "1":
                imprimeur.ImprimerNombres();
                break;
                
            default:
                Console.WriteLine("Je ne comprends pas votre choix... vous obtiendrez 1 thread.");
                goto case "1";
        }

        // Effectuer des tâches supplémentaires.
        Console.WriteLine("Ceci est sur le thread principal, et nous avons fini.");
        Console.ReadLine();
    }
}
```

Dans la méthode `Main()`, nous donnons à l'utilisateur le choix d'exécuter le programme avec un ou deux threads. Selon le choix de l'utilisateur, nous instancions la classe `Imprimeur` et appelons la méthode `ImprimerNombres()` sur le thread principal ou sur un thread secondaire.

En utilisant le délégué `ThreadStart`, nous avons la flexibilité de contrôler l'exécution des méthodes sur des threads séparés, ce qui peut être utile pour des tâches telles que le traitement parallèle, l'exécution de tâches en arrière-plan ou la gestion des opérations longues sans bloquer l'interface utilisateur dans une application graphique.