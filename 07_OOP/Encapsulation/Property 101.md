## Encapsulation des Données de Champ dans .NET Core en Utilisant les Propriétés

Dans les langages .NET Core, les propriétés sont préférées aux méthodes traditionnelles `get` et `set` pour encapsuler les données de champ. Les propriétés offrent une manière plus concise et expressive d'imposer l'encapsulation des données et de maintenir le contrôle sur l'accès aux champs de classe.

### Syntaxe de Base des Propriétés

Les propriétés en C# se composent d'un accesseur (getter) et d'un mutateur (setter), qui permettent respectivement d'accéder en lecture et en écriture aux données encapsulées. Voici un exemple d'une propriété encapsulant l'identifiant d'un employé :

```csharp
public int EmployeeId // Déclaration de la propriété
{
    get { return _employeeId; } // Getter
    set { _employeeId = value; } // Setter
}
```

Dans cet exemple :
- `EmployeeId` est le nom de la propriété.
- `_employeeId` est le champ sous-jacent stockant les données.
- `get` récupère la valeur de `_employeeId`.
- `set` définit la valeur de `_employeeId` à la valeur entrante (`value`).

### Mot-Clé Contextuel : `value`

Le mot-clé `value` représente la valeur entrante utilisée pour attribuer la propriété par l'appelant. C'est un mot-clé contextuel, utilisé spécifiquement dans l'accesseur `set` d'une propriété. Son type est inféré à partir du type de propriété.

```csharp
public int Age
{
    get { return _employeeAge; }
    set { _employeeAge = value; } // 'value' représente la valeur entrante
}
```

### Membres de Corps d'Expression

En C# 6 et ultérieur, les propriétés peuvent être écrites sous forme de membres de corps d'expression, offrant une syntaxe plus concise pour les méthodes getter et setter simples.

```csharp
public int Age
{
    get => _employeeAge;
    set => _employeeAge = value;
}
```

### Propriétés en Lecture Seule

Pour créer une propriété en lecture seule, omettez le bloc setter. Cela garantit que la propriété ne peut être définie que dans la classe elle-même.

```csharp
public string SocialSecurityNumber { get; private set; }
```

Dans cet exemple, `SocialSecurityNumber` peut être accédé publiquement en lecture mais ne peut être défini que dans la classe.

### Modificateurs d'Accès

Les propriétés peuvent avoir différents modificateurs d'accès pour leur getter et leur setter, permettant un contrôle précis de l'accessibilité.

```csharp
public int EmployeeId
{
    get { return _employeeId; } // Getter public
    private set { _employeeId = value; } // Setter privé
}
```

Dans ce cas, `EmployeeId` peut être lu de n'importe où, mais il ne peut être défini que dans la classe elle-même.

## Aperçu des Propriétés et Champs en C#

### Introduction
En C#, les propriétés et les champs sont des composants cruciaux pour encapsuler des données au sein de classes. Ils permettent un accès contrôlé à l'état interne d'un objet, permettant l'application de règles métier et maintenant l'intégrité des données du programme.

### Propriété Statique
```csharp
// Une propriété statique.
public static double TauxInteret
{
    get { return _tauxInteretActuel; }
    set { _tauxInteretActuel = value; }
}
```
Les propriétés statiques sont accessibles à travers la classe elle-même plutôt qu'une instance de la classe. Elles sont couramment utilisées pour des valeurs partagées entre toutes les instances de la classe, telles que les paramètres de configuration ou les constantes.

### Propriétés Automatiques
```csharp
class Voiture
{
    // Propriétés automatiques ! Pas besoin de définir des champs de sauvegarde.
    public string NomAnimal { get; set; }

    // Le champ de sauvegarde int caché est défini à zéro !
    public int NombreDeVoitures { get; set; }

    // Le champ de sauvegarde Car caché est défini à null !
    public Voiture MonAuto { get; set; }
}
```
Les propriétés automatiques fournissent une syntaxe concise pour définir des propriétés sans déclarer explicitement les champs de sauvegarde. Le compilateur génère automatiquement le champ de sauvegarde et les méthodes get/set.

### Initialisation des Propriétés Automatiques
```csharp
class Voiture
{
    // Le champ de sauvegarde caché est défini à 1.
    public int NombreDeVoitures { get; set; } = 1;
    
    // Le champ de sauvegarde caché est défini à un nouvel objet Car.
    public Voiture MonAuto { get; set; } = new Voiture();
}
```
Les propriétés automatiques peuvent être initialisées directement au point de déclaration, simplifiant ainsi l'initialisation des objets.

### Setters Uniquement pour l'Initialisation (C# 9.0)
```csharp
class PointLectureSeuleApresCreation
{
    public int X { get; init; }
}
```
Introduits dans C# 9.0, les setters uniquement pour l'initialisation permettent aux propriétés d'être définies lors de l'initialisation mais deviennent en lecture seule après la construction. Cette fonctionnalité est particulièrement utile pour créer des objets immuables.

### Champs en Lecture Seule
```csharp
class MaClasseMath
{
    // Les champs en lecture seule peuvent être assignés dans les constructeurs.
    public readonly double PI;

    public MaClasseMath()
    {
        PI = 3.14;
    }
}
```
Les champs en lecture seule ne peuvent être assignés qu'à l'intérieur des constructeurs et sont immuables une fois initialisés. Ils sont utiles pour les valeurs qui ne doivent pas changer après la construction de l'objet.

### Champs Statiques en Lecture Seule
```csharp
class MaClasseMath
{
    // Champ statique en lecture seule.
    public static readonly double PI;
}
```
Les champs statiques en lecture seule sont partagés entre toutes les instances de la classe et sont initialisés une fois avant que toute instance de la classe ne soit créée. Ils doivent être explicitement marqués comme statiques.

### Conclusion
Comprendre les propriétés et les champs en

 C# est fondamental pour développer un code robuste et maintenable. Que ce soit pour appliquer des règles métier, créer des objets immuables ou gérer des données partagées, les propriétés et les champs fournissent des outils puissants pour gérer l'état de vos objets.