## Compréhension des Constructeurs et Membres Statiques dans les Interfaces C# 

En C# 8 et ultérieurement, les interfaces ont acquis la capacité d'avoir des membres statiques, offrant de nouvelles possibilités pour l'organisation du code et l'initialisation. Plongeons dans ce concept, explorant sa syntaxe, son utilisation et ses applications potentielles.

**1. Définition de l'Interface:**

Commencez par définir une interface nommée `IShape` qui sert de base pour différentes formes géométriques :

```csharp
public interface IShape
{
    double Area { get; }
    string Name { get; set; }

    // Méthodes abstraites (implémentation requise dans les classes implémentantes)
    double GetPerimeter();
}
```

Voici un aperçu :

- `IShape` définit deux propriétés :
    - `Area` : Calculée par chaque classe implémentante pour refléter sa forme spécifique.
    - `Name` : Stocke un nom descriptif pour la forme.
- `GetPerimeter()` est une méthode abstraite que chaque classe implémentante doit fournir une implémentation concrète, en fonction de sa forme.

**2. Ajout d'un Membre Statique:**

Introduisez une propriété statique nommée `DefaultMaterial` à `IShape`, permettant à toutes les classes implémentantes de partager le même matériau par défaut si désiré :

```csharp
public interface IShape
{
    // Membres existants...

    static string DefaultMaterial { get; set; }
}
```

Rappelez-vous que :

- Les membres statiques appartiennent à l'interface elle-même, pas aux instances des classes implémentantes.
- Ils sont accessibles en utilisant le nom de l'interface, comme vous le verrez plus tard.

**3. Initialisation du Membre Statique:**

Utilisez un constructeur statique (méthode sans paramètre nommée d'après l'interface avec `.ctor` ajouté) pour initialiser `DefaultMaterial` lorsque l'interface est utilisée pour la première fois :

```csharp
public interface IShape
{
    // Membres existants...

    static string DefaultMaterial { get; set; }

    static IShape()
    {
        DefaultMaterial = "Plastique"; // Définir le matériau par défaut
    }
}
```

Points clés :

- Le constructeur statique s'exécute une seule fois, généralement lorsque la première classe implémentante ou le premier membre statique est référencé.
- Il peut initialiser les membres statiques et effectuer d'autres tâches de configuration qui s'appliquent à toutes les implémentations.

**4. Implémentation de l'Interface:**

Créez une classe nommée `Square` qui implémente `IShape`, fournissant des implémentations concrètes pour ses méthodes abstraites et utilisant la propriété `DefaultMaterial` :

```csharp
public class Square : IShape
{
    private double sideLength;

    public Square(double sideLength)
    {
        this.sideLength = sideLength;
    }

    public double Area => sideLength * sideLength;

    public string Name { get; set; }

    public double GetPerimeter() => 4 * sideLength;

    public static void SetDefaultMaterial(string material)
    {
        IShape.DefaultMaterial = material; // Accéder et modifier le membre statique de l'interface
    }
}
```

Explications :

- `Square` implémente `IShape`, fournissant des implémentations concrètes pour `Area`, `Name` et `GetPerimeter`.
- Il exploite la propriété `DefaultMaterial` :
    - Le constructeur utilise le matériau par défaut actuel (`Plastique`).
    - La méthode statique `SetDefaultMaterial` permet de personnaliser le matériau par défaut pour toutes les instances de `Square` ultérieures.

**5. Accès et Modification des Membres Statiques:**

Utilisez le nom de l'interface pour accéder et modifier les membres statiques, comme illustré dans la méthode `Main` :

```csharp
static void Main(string[] args)
{
    Square square1 = new Square(5);
    square1.Name = "Mon Carré";

    Console.WriteLine($"Carré 1 : Surface = {square1.Area}, Nom = {square1.Name}, Matériau = {square1.DefaultMaterial}"); // Sortie : Carré 1 : Surface = 25, Nom = Mon Carré, Matériau = Plastique

    Square.SetDefaultMaterial("Bois"); // Modifier le matériau par défaut globalement

    Square square2 = new Square(7);
    square2.Name = "Autre Carré";

    Console.WriteLine($"Carré 2 : Surface = {square2.Area}, Nom = {square2.Name}, Matériau = {square2.DefaultMaterial}"); // Sortie : Carré 2 : Surface = 49, Nom = Autre Carré, Matériau = Bois
}
```

### Points clés :
- Les membres statiques sont accessibles en utilisant le nom de l'interface, pas les instances individuelles.
- Modifier un membre statique affecte toutes les classes implémentantes et les instances futures.