```csharp
// Importation des espaces de noms requis pour utiliser des tâches asynchrones
using System;
using System.Threading.Tasks;

namespace CSharpSpeedrun
{
    // Définition de la classe principale du programme
    class Program
    {
        // Méthode principale du programme
        static void Main(string[] args)
        {
            // Création d'une nouvelle tâche pour exécuter la méthode app1
            Task task1 = new Task(app1);
            // Démarrage de la tâche
            task1.Start();
            // Affichage d'un message dans la console indiquant que le thread principal a terminé
            Console.WriteLine("Le thread principal a terminé");
        }

        // Méthode représentant le travail à effectuer dans la tâche
        static void app1()
        {
            // Boucle pour afficher les nombres de 10 à 12
            for (int i = 10; i <= 12; i++)
            {
                // Affichage du nombre actuel dans la console
                Console.WriteLine(i);
            }
            // Affichage d'un message indiquant que le travail de la méthode app1 est terminé
            Console.WriteLine("Le thread de app1 a terminé");
        }
    }
}
/*
Le thread principal a terminé
10
11
12
Le thread de app1 a terminé
*/
```

### Explications détaillées :

1. **Utilisation de l'espace de noms `System.Threading.Tasks`** :
   - Cet espace de noms permet de travailler avec des tâches asynchrones, ce qui est utile pour effectuer des opérations concurrentes de manière efficace.

2. **Définition de la classe `Program`** :
   - La classe `Program` est la classe principale du programme. C'est à partir de cette classe que le programme démarre son exécution.

3. **Méthode `Main`** :
   - La méthode `Main` est la méthode principale du programme. C'est le point d'entrée du programme où l'exécution commence.
   - Dans cette méthode, une nouvelle tâche (`task1`) est créée pour exécuter la méthode `app1`.
   - La tâche est ensuite démarrée à l'aide de la méthode `Start()`.

4. **Méthode `app1`** :
   - La méthode `app1` est une méthode qui représente le travail à effectuer dans la tâche asynchrone.
   - Elle contient une boucle `for` qui affiche les nombres de 10 à 12 dans la console.
   - Après avoir affiché les nombres, un message indiquant la fin du travail de la méthode est affiché.

5. **Affichage dans la console** :
   - Après le démarrage de la tâche dans la méthode `Main`, un message est affiché indiquant que le thread principal a terminé.
   - Ensuite, les nombres de 10 à 12 sont affichés dans la console par la tâche exécutée par la méthode `app1`.
   - Enfin, un message indiquant la fin du travail de la méthode `app1` est affiché.

Cette structure de programme illustre l'utilisation de tâches asynchrones pour exécuter des opérations de manière concurrente, ce qui permet d'améliorer l'efficacité et la réactivité des applications.

