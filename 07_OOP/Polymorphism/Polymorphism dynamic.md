### l'implémentation de la polymorphisme dynamique

```csharp
using System;

namespace CSharpSpeedrun
{
    // Définition de la classe de base "Vehicle"
    class Vehicle  //parent
    {
        // Méthode virtuelle ActivateWiper, qui peut être redéfinie dans les classes dérivées
        public virtual void ActivateWiper() 
        {
            Console.WriteLine("Activation du balai d'essuie-glace générique");
        }
    }

    // Définition de la classe dérivée "Car", qui hérite de la classe de base "Vehicle"
    class Car : Vehicle  //child
    {
        // Redéfinition de la méthode ActivateWiper spécifique à la classe "Car"
        public override void ActivateWiper() 
        {
            Console.WriteLine("Activation du balai d'essuie-glace de la voiture");
        }
    }

    // Classe principale "Program" contenant la méthode d'entrée principale "Main"
    class Program
    {
        // Méthode d'entrée principale
        static void Main(string[] args)
        {
            // Création d'une instance de la classe de base "Vehicle"
            Vehicle  myVehicle = new Vehicle();
            // Création d'une instance de la classe dérivée "Car"
            Car myCar = new Car();
            // Appel de la méthode ActivateWiper de l'instance de Vehicle
            myVehicle.ActivateWiper(); 
            // Appel de la méthode ActivateWiper de l'instance de Car, qui a sa propre implémentation
            myCar.ActivateWiper(); 
        }
    }
}
// Résultat attendu :
// Activation du balai d'essuie-glace générique
// Activation du balai d'essuie-glace de la voiture
```

Ce code illustre l'implémentation de la polymorphisme dynamique en C#. Le polymorphisme dynamique permet à une méthode d'être redéfinie dans une classe dérivée avec une implémentation spécifique à cette classe, tout en étant appelée à travers une référence de la classe de base.

- **Classe de base (`Vehicle`)** : Une classe de base qui définit une méthode virtuelle que les classes dérivées peuvent redéfinir.
- **Classe dérivée (`Car`)** : Une classe qui hérite de la classe de base et redéfinit la méthode virtuelle avec une implémentation spécifique.
- **Méthode virtuelle (`ActivateWiper`)** : Une méthode de la classe de base qui peut être redéfinie dans les classes dérivées.
- **Redéfinition (`override`)** : Le mot-clé utilisé pour indiquer qu'une méthode redéfinit une méthode virtuelle de la classe de base.
- **Polymorphisme dynamique** : Capacité d'une méthode à être appelée par le biais d'une référence de la classe de base et à exécuter l'implémentation appropriée selon le type réel de l'objet.

Lorsque vous appelez la méthode `ActivateWiper()` sur une référence de type `Vehicle`, le comportement dépend du type réel de l'objet. Dans le premier cas, où `myVehicle` est une instance de la classe de base `Vehicle`, la méthode `ActivateWiper()` de cette classe est appelée, produisant le message "Activation du balai d'essuie-glace générique". Dans le second cas, où `myCar` est une instance de la classe dérivée `Car`, la méthode `ActivateWiper()` redéfinie dans la classe `Car` est appelée, affichant "Activation du balai d'essuie-glace de la voiture".