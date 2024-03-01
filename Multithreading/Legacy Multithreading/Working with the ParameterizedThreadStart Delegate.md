# Travail avec le délégué ParameterizedThreadStart

En C#, le délégué `ThreadStart` peut uniquement pointer vers des méthodes qui retournent `void` et n'ont aucun argument.

Si vous souhaitez passer des données à la méthode exécutée sur le thread secondaire, vous devez utiliser le type de délégué `ParameterizedThreadStart`.

```csharp
using System;
using System.Threading;

namespace AjoutAvecThreads
{
    class DonneesAjout
    {
        public int valeur1, valeur2;

        public DonneesAjout(int v1, int v2)
        {
            valeur1 = v1;
            valeur2 = v2;
        }

        public void Ajouter(object donnees)
        {
            if (donnees is DonneesAjout da)
            {
                Console.WriteLine("ID du thread dans Ajouter() : {0}",
                    Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("{0} + {1} donne {2}", da.valeur1, da.valeur2, da.valeur1 + da.valeur2);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Ajout avec des objets Thread *****");
            Console.WriteLine("ID du thread dans Main() : {0}",
                Thread.CurrentThread.ManagedThreadId);

            // Créer un objet DonneesAjout pour passer au thread secondaire.
            DonneesAjout donnees = new DonneesAjout(30, 40);
            Thread thread = new Thread(new ParameterizedThreadStart(Ajouter));
            thread.Start(donnees);
        }

        static void Ajouter(object data)
        {
            DonneesAjout donnees = (DonneesAjout)data;
            Console.WriteLine("ID du thread dans Ajouter() : {0}",
                Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("{0} + {1} donne {2}", donnees.valeur1, donnees.valeur2, donnees.valeur1 + donnees.valeur2);
        }
    }
}
```

Le code ci-dessus illustre comment utiliser le délégué `ParameterizedThreadStart` pour passer des données à une méthode exécutée sur un thread secondaire.

## Explications détaillées :

### Délégué ParameterizedThreadStart

Le délégué `ParameterizedThreadStart` est utilisé pour pointer vers des méthodes qui acceptent un paramètre de type `object`. Cela permet de passer des données à la méthode exécutée sur un thread secondaire.

### Classe DonneesAjout

La classe `DonneesAjout` est utilisée pour encapsuler les données à passer à la méthode exécutée sur le thread secondaire. Elle contient les champs `valeur1` et `valeur2` qui représentent les valeurs à ajouter.

### Méthode Ajouter

La méthode `Ajouter` est appelée sur le thread secondaire. Elle prend un objet en paramètre et le convertit en instance de `DonneesAjout`. Ensuite, elle effectue l'addition des valeurs `valeur1` et `valeur2` et affiche le résultat.

### Méthode Main

La méthode `Main` est le point d'entrée du programme. Elle crée une instance de `DonneesAjout` avec des valeurs initiales, puis crée un nouveau thread en utilisant le délégué `ParameterizedThreadStart` pour exécuter la méthode `Ajouter` avec les données spécifiées.

Ce code garantit que l'addition est effectuée sur un thread secondaire, évitant ainsi de bloquer le thread principal et améliorant la réactivité de l'application.