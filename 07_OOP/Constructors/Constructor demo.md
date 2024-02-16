### Chaining de constructeurs en C#

En C#, un constructeur peut appeler un autre constructeur, ce qui est connu sous le nom de "chaining" de constructeurs. Cette technique permet la réutilisation du code et offre une flexibilité accrue lors de l'initialisation des objets. Dans l'exemple de code fourni, `: this()` appelle le constructeur par défaut.

```csharp
 //file 1
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main()
        {
            // Création d'un employé en utilisant le constructeur paramétré
            Employee starEmployee = new Employee(1001, "Bill", "Gates");
        }
    }
 
    class Employee
    {
        public int id;
        public string firstName;
        public string lastName;

        // Constructeur paramétré appelant le constructeur par défaut
        public Employee(
            int employeeId,
            string employeeFirstName,
            string employeeLastName) : this()
        {
            id = employeeId;
            firstName = employeeFirstName;
            lastName = employeeLastName;

            Console.WriteLine("Paramètres ok");
        }

        // Constructeur par défaut
        public Employee()
        {
            Console.WriteLine("Constructeur par défaut activé");
        }
    }
}
/*
Constructeur par défaut activé
Paramètres ok
*/
```

Dans cet exemple :

- **Programme principal** (`Main()`): 
  - Le programme crée une instance de la classe `Employee` en passant des valeurs spécifiques au constructeur paramétré.
- **Classe `Employee`**:
  - Définit trois champs : `id`, `firstName`, `lastName`.
  - Contient deux constructeurs :
    - **Constructeur paramétré**: Prend trois paramètres et initialise les champs de l'instance avec ces valeurs. Il appelle ensuite le constructeur par défaut.
    - **Constructeur par défaut**: Initialise la classe avec des valeurs par défaut et affiche un message pour indiquer son activation.

Ce mécanisme de chaining de constructeurs permet de garantir que les initialisations communes sont gérées par le constructeur par défaut, évitant ainsi la duplication de code.