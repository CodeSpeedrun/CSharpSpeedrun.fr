# Comprendre les constructeurs en C#

En C#, les constructeurs sont des méthodes spéciales à l'intérieur d'une classe qui vous permettent d'initialiser l'état d'un objet au moment de sa création. Ils sont essentiels pour configurer les valeurs initiales des champs et des propriétés dans un objet.

## Constructeur de base

```csharp
class Véhicule
{
    // Champs représentant l'état du véhicule.
    public string Modèle;
    public int VitesseActuelle;

    // Un constructeur par défaut personnalisé.
    public Véhicule()
    {
        Modèle = "Toyota";
        VitesseActuelle = 0;
    }
}
```

Dans l'exemple ci-dessus, la classe `Véhicule` contient un constructeur `Véhicule()` sans paramètres. Ce constructeur initialise le `Modèle` à "Toyota" et la `VitesseActuelle` à 0 chaque fois qu'une nouvelle instance de `Véhicule` est créée sans spécifier de valeurs.

## Surcharge de constructeur

```csharp
class Moto
{
    // Champs représentant l'état de la moto.
    public string NomConducteur;
    public int IntensitéConducteur;

    // Constructeur avec des arguments facultatifs.
    public Moto(int intensité = 0, string nom = "")
    {
        IntensitéConducteur = intensité;
        NomConducteur = nom;
    }
}
```

La classe `Moto` démontre la surcharge de constructeur en fournissant un constructeur avec des paramètres facultatifs. Cela permet une flexibilité lors de la création d'instances de `Moto`, car les paramètres peuvent être fournis dans n'importe quel ordre ou omis complètement.

### Exemple d'utilisation :

```csharp
static void CréerMotos()
{
    // Création d'instances de Moto avec différents paramètres.
    Moto m1 = new Moto(); // NomConducteur = "", IntensitéConducteur = 0
    Moto m2 = new Moto(nom: "Tiny"); // NomConducteur = "Tiny", IntensitéConducteur = 0
    Moto m3 = new Moto(7); // NomConducteur = "", IntensitéConducteur = 7
}
```

Dans la méthode `CréerMotos()`, des instances de `Moto` sont créées avec différentes combinaisons de paramètres. Cela démontre comment la surcharge de constructeur permet diverses façons d'initialiser l'état de l'objet.

# Classe Moto

La classe `Moto` représente un objet de moto avec des propriétés liées au nom du conducteur et au niveau d'intensité. Cette classe illustre l'utilisation d'un constructeur statique et de paramètres facultatifs dans le constructeur.

## Constructeur

### Unique Constructeur avec Arguments Facultatifs

La classe `Moto` a un seul constructeur qui accepte deux arguments facultatifs : `intensité` (un entier représentant le niveau d'intensité du conducteur) et `nom` (une chaîne représentant le nom du conducteur). Si aucun argument n'est fourni, des valeurs par défaut sont utilisées.

```csharp
public Moto(int intensité = 0, string nom = "")
{
    // Implémentation du constructeur
}
```