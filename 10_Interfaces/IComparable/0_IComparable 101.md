# L'Interface IComparable
L'interface `IComparable` spécifie un comportement qui permet à un objet d'être trié en fonction d'une clé spécifiée.

## Définition Formelle
```csharp
// Cette interface permet à un objet de spécifier sa relation avec d'autres objets similaires.
public interface IComparable
{
    int CompareTo(object o);
}
```

La version générique de cette interface (`IComparable<T>`) offre une manière plus sûre en termes de type pour gérer les comparaisons entre les objets.

## Exemple d'Implémentation
```csharp
namespace ComparableVehicle
{
    public class Vehicle : IComparable
    {
        // Propriétés
        public string Name { get; set; }
        public int CurrentSpeed { get; set; }
        public int VehicleID { get; set; }

        // Constructeur
        public Vehicle(string name, int speed, int id)
        {
            Name = name;
            CurrentSpeed = speed;
            VehicleID = id;
        }

        // Implémentation de la méthode CompareTo
        int IComparable.CompareTo(object obj)
        {
            if (obj is Vehicle otherVehicle)
            {
                return this.VehicleID.CompareTo(otherVehicle.VehicleID);
            }
            throw new ArgumentException("Le paramètre n'est pas un véhicule !");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Amusement avec le Tri d'Objets *****\n");

            // Création d'un tableau d'objets Vehicle.
            Vehicle[] myVehicles = new Vehicle[5];
            myVehicles[0] = new Vehicle("Voiture A", 80, 1);
            myVehicles[1] = new Vehicle("Voiture B", 40, 2);

            // Affichage du tableau actuel.
            Console.WriteLine("Voici l'ensemble non trié de véhicules :");
            foreach (Vehicle v in myVehicles)
            {
                Console.WriteLine("{0} {1}", v.VehicleID, v.Name);
            }

            // Tri à l'aide de IComparable !
            Array.Sort(myVehicles);

            // Affichage du tableau trié.
            Console.WriteLine("\nVoici l'ensemble trié de véhicules :");
            foreach (Vehicle v in myVehicles)
            {
                Console.WriteLine("{0} {1}", v.VehicleID, v.Name);
            }
        }
    }
}
```

Dans cette implémentation :
- La classe `Vehicle` représente un véhicule générique avec des propriétés telles que Name, CurrentSpeed et VehicleID.
- La méthode `IComparable.CompareTo` est implémentée pour comparer les véhicules en fonction de leur VehicleID.
- Dans la méthode `Main`, un tableau d'objets `Vehicle` est créé et trié à l'aide de la méthode `Array.Sort`.

Cela permet aux types personnalisés comme `Vehicle` d'être triés dans des tableaux en utilisant l'interface `IComparable`.