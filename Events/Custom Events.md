### Création d'Arguments d'Événements Personnalisés

La création d'arguments d'événements personnalisés est une pratique courante en C# pour fournir des informations supplémentaires lorsqu'un événement est déclenché.

```csharp
public class CustomEventArgs
{
    public static readonly CustomEventArgs Empty;
    public CustomEventArgs();
}
```

Dans cet exemple, une classe `CustomEventArgs` est définie avec une propriété statique `Empty` et un constructeur par défaut.

```csharp
using System;

namespace CarEvents
{
    public class CarEventArgs : EventArgs
    {
        public readonly string Message;

        public CarEventArgs(string message)
        {
            Message = message;
        }
    }

    public class Vehicle
    {
        public delegate void VehicleEngineHandler(object sender, CarEventArgs e);

        public event VehicleEngineHandler Exploded;

        public bool IsDead { get; private set; }

        public void Accelerate(int delta)
        {
            if (IsDead)
            {
                Exploded?.Invoke(this, new CarEventArgs("Désolé, ce véhicule est hors service..."));
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            Vehicle myCar = new Vehicle();
            myCar.Exploded += VehicleAboutToBlow;
            myCar.Accelerate(100);
        }

        static void VehicleAboutToBlow(object sender, CarEventArgs e)
        {
            if (sender is Vehicle v)
            {
                Console.WriteLine($"Message critique de la voiture : {e.Message}");
            }
        }
    }
}
```

Dans cet exemple, nous avons une classe `CarEventArgs` qui étend `EventArgs` et contient un champ `Message` pour stocker des informations supplémentaires. La classe `Vehicle` contient un délégué `VehicleEngineHandler` et un événement `Exploded` déclenché lorsqu'un véhicule est "mort". La méthode `Accelerate` vérifie si le véhicule est hors service et déclenche l'événement approprié. Le programme principal instancie un véhicule, s'abonne à l'événement `Exploded`, et appelle la méthode `Accelerate`. Lorsque l'événement est déclenché, la méthode `VehicleAboutToBlow` est appelée pour gérer l'événement et afficher un message critique.

Cet exemple illustre comment créer et utiliser des arguments d'événements personnalisés en C#. Il est important de noter que les arguments d'événements personnalisés peuvent être étendus pour inclure d'autres informations spécifiques à chaque événement, ce qui les rend très flexibles et adaptables à différentes situations de programmation.