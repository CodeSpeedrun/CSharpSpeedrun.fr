### Accès et modification contrôlés avec validation

Les accesseurs et les mutateurs, également connus sous le nom de getters et de setters, sont couramment utilisés pour appliquer l'encapsulation en programmation orientée objet. Ils permettent un accès contrôlé aux membres privés d'une classe, ce qui permet de valider et de vérifier l'intégrité des données avant leur modification ou leur récupération. Cela garantit que l'état interne d'un objet reste cohérent et valide tout au long de sa durée de vie.

```csharp
// Créer une instance de la classe Employee.
Employee employee = new Employee();

// Erreur ! Impossible d'accéder directement aux membres privés
// depuis un objet !
employee._employeeName = "Anna";

// Définir une classe appelée Employee
class Employee
{
    // Données de champ. Ce champ est privé, ce qui signifie qu'il ne peut être accédé
    // qu'à l'intérieur de la classe elle-même.
    private string _employeeName;
    
    // Méthode d'accessibilité (également appelée "getter").
    // Cette méthode permet au code externe de récupérer la valeur du champ privé _employeeName.
    public string GetName() => _employeeName;
    
    // Méthode de mutation (également appelée "setter").
    // Cette méthode permet au code externe de modifier la valeur du champ privé _employeeName,
    // mais d'abord, elle effectue une vérification sur la valeur entrante avant l'assignation.
    public void SetName(string name)
    {
        // Effectuer une vérification sur la valeur entrante avant de faire l'assignation.
        if (name.Length > 13)
        {
            // Si la longueur du nom dépasse 13 caractères, afficher un message d'erreur.
            Console.WriteLine("Erreur ! La longueur du nom dépasse 13 caractères !");
        }
        else
        {
            // Sinon, attribuer le nom au champ _employeeName.
            _employeeName = name;
        }
    }
}
```

Dans le code fourni :

- Une classe `Employee` est définie avec un champ privé `_employeeName`. L'utilisation du modificateur d'accès privé garantit que ce champ n'est accessible que dans la classe `Employee` elle-même.
- `GetName()` est une méthode d'accès, également connue sous le nom de "getter", qui permet au code externe de récupérer la valeur de `_employeeName`.
- `SetName(string name)` est une méthode de mutation, également connue sous le nom de "setter", qui permet au code externe de modifier la valeur de `_employeeName`. Cependant, avant d'assigner une nouvelle valeur, il effectue une vérification pour s'assurer que la longueur du nom ne dépasse pas 15 caractères. Si c'est le cas, un message d'erreur est affiché ; sinon, le nouveau nom est attribué au champ `_employeeName`.