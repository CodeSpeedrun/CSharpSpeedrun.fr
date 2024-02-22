### Qu'est-ce que l'abstraction ?

L'abstraction de données est le processus qui consiste à ne montrer à l'utilisateur que les données essentielles. Par exemple, nous pouvons utiliser les freins d'une voiture ou d'un vélo sans savoir comment ils fonctionnent en interne.

#### Méthodes pour atteindre l'abstraction :

- **Classe abstraite et méthode abstraite :** Une classe abstraite décrit quelque chose d'abstrait, quelque chose de plus conceptuel qu'une chose tangible. Elle ne peut pas instancier d'objets, mais d'autres classes peuvent hériter de ses membres et créer des objets. De plus, une classe abstraite contient à la fois des méthodes abstraites et des méthodes régulières.
  
  - Remarque : La méthode abstraite ne contient aucun corps, le contenu est fourni par la classe enfant. Une classe qui hérite d'une classe abstraite est liée par un contrat pour implémenter toutes les méthodes abstraites.
  
  - Il ne peut être placé que dans une classe abstraite.

Le code fourni en exemple illustre le concept d'abstraction en utilisant C# :

```csharp
using System;

namespace CSharpSpeedrun
{
    abstract class Clock
    {
        public abstract void AlarmSound();

        public void ShutDown()
        {
            Console.WriteLine("Extinction en cours.");
        }
    }
    
    class AlarmClock : Clock // Classe enfant
    {
        public override void AlarmSound()
        {
            Console.WriteLine("Debout et brillant !");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock myAlarmClock = new AlarmClock();
            myAlarmClock.AlarmSound();
            myAlarmClock.ShutDown();  
        }
    }
}
```

Résultat de l'exécution :
```
Debout et brillant !
Extinction en cours.
```

Dans cet exemple, la classe `Clock` est abstraite, car elle contient une méthode abstraite `AlarmSound()`. La classe `AlarmClock` hérite de la classe abstraite `Clock` et implémente la méthode abstraite `AlarmSound()`. L'appel à `myAlarmClock.AlarmSound()` déclenche la méthode `AlarmSound()` de la classe `AlarmClock`, affichant ainsi "Debout et brillant !". L'appel à `myAlarmClock.ShutDown()` appelle la méthode `ShutDown()` de la classe `Clock`, affichant "Extinction en cours.".