# L'héritage en Programmation Orientée Objet (POO)

L'héritage est un concept fondamental en Programmation Orientée Objet (POO) qui facilite la réutilisation du code et favorise une structure hiérarchique entre les classes. Il permet à une nouvelle classe d'hériter des propriétés et du comportement d'une classe existante, établissant ainsi une relation souvent appelée la relation "est-un".

## Introduction à l'héritage

En POO, la réutilisation du code est réalisée grâce à l'héritage et au modèle de containment/delegation. L'héritage signifie une relation "est-un", où une classe (la classe dérivée ou enfant) hérite des attributs et des méthodes d'une autre classe (la classe de base ou parent).

### Types de Relations en POO
1. **Héritage** : Relation "est-un".
2. **Containment/Delegation** : Relation "a-un".

### Avantages de l'héritage
- Favorise la réutilisation du code.
- Améliore l'organisation et la maintenance du code.
- Facilite le polymorphisme et le binding dynamique.

## Concepts Clés et Terminologie

### Classe de Base (Superclasse ou Classe Parent)
- La classe existante qui sert de base aux classes dérivées.
- Contient les attributs et méthodes communs partagés par ses sous-classes.

### Classe Dérivée (Sous-classe ou Classe Enfant)
- Hérite des propriétés et du comportement de sa classe de base.
- Peut étendre la fonctionnalité en ajoutant de nouvelles méthodes ou en remplaçant celles existantes.

## Implémentation en C#

En C#, l'héritage est implémenté en utilisant la syntaxe `:nomclassebase`. Plongeons dans une implémentation d'exemple de l'héritage en C# :

```csharp
namespace ConceptsPOO
{
    // Classe de base représentant un 'Véhicule' générique.
    class Véhicule
    {
        // Propriétés et méthodes communes aux véhicules.
        public string Marque { get; set; }
        public string Modèle { get; set; }
        public void DémarrerMoteur()
        {
            Console.WriteLine("Moteur démarré !");
        }
    }

    // Classe dérivée 'Voiture' héritant de 'Véhicule'.
    class Voiture : Véhicule
    {
        // Propriétés et méthodes supplémentaires spécifiques aux voitures.
        public int NombrePortes { get; set; }
        public void Accélérer()
        {
            Console.WriteLine("La voiture accélère !");
        }
    }

    // Classe dérivée 'Camion' héritant de 'Véhicule'.
    class Camion : Véhicule
    {
        // Propriétés et méthodes supplémentaires spécifiques aux camions.
        public int CapacitéCharge { get; set; }
        public void ChargerCargo()
        {
            Console.WriteLine("Cargo chargé dans le camion !");
        }
    }

    class Programme
    {
        static void Main(string[] args)
        {
            // Création d'instances de classes dérivées.
            Voiture maVoiture = new Voiture();
            Camion monCamion = new Camion();

            // Accès aux membres hérités.
            maVoiture.DémarrerMoteur();
            maVoiture.Accélérer();

            monCamion.DémarrerMoteur();
            monCamion.ChargerCargo();
        }
    }
}
```

Dans l'exemple ci-dessus :
- `Véhicule` sert de classe de base avec des propriétés et des méthodes communes.
- `Voiture` et `Camion` sont des classes dérivées héritant de `Véhicule`, représentant des types spécifiques de véhicules.
- Chaque classe dérivée étend la fonctionnalité avec ses propres propriétés et méthodes.

## Conclusion

L'héritage est un mécanisme puissant en POO, permettant la réutilisation du code et établissant des relations hiérarchiques entre les classes. Comprendre comment utiliser efficacement l'héritage est crucial pour développer des systèmes logiciels modulaires et maintenables en C# et dans d'autres langages orientés objet.

---

# L'héritage en C#

L'héritage est un concept fondamental en programmation orientée objet (POO) qui permet à une classe (sous-classe/classe dérivée) d'hériter des propriétés et des comportements d'une autre classe (superclasse/classe de base). Il favorise la réutilisabilité du code et permet de créer des hiérarchies de classes.

## Exemple de Base

Considérons un scénario où nous avons une hiérarchie de véhicules. Nous commencerons par une classe de base `Véhicule` et dériverons une sous-classe `Voiture` à partir de celle-ci. De plus, nous introduirons une autre sous-classe `Camion` dérivée de `Voiture`.

### Classe Véhicule

```csharp
public class Véhicule
{
    protected string Fabricant { get; set; }
    protected int Année { get; set; }
    
    public Véhicule(string fabricant, int année)
    {
        Fabricant = fabricant;
        Année = année;
    }
}
```

La classe `Véhicule` représente les attributs de base partagés par tous les véhicules, tels que le fabricant et l'année.

### Classe Voiture

```csharp
public class Voiture : Véhicule
{
    protected int NumPlaces { get; set; }
    
    public Voiture(string fabricant, int année, int numPlaces) 
        : base(fabricant, année)
    {
        NumPlaces = numPlaces;
    }
}
```

La classe `Voiture` hérite de `Véhicule` et ajoute des propriétés spécifiques comme le nombre de places.

### Classe Camion

```csharp
public class Camion : Voiture
{
    protected bool PossèdePorteCoulissante { get; set; }
    
    public Camion(string fabricant, int année, int numPlaces, bool possèdePorteCoulissante)
        : base(fabricant, année, numPlaces)
    {
        PossèdePorteCoulissante = possèdePorteCoulissante;
    }
}
```

La classe `Camion` étend davantage `Voiture` et inclut des fonctionnalités supplémentaires comme la présence ou non d'une porte coulissante.

## Concepts

 Clés

- **Héritage** : Le processus de création de nouvelles classes à partir de classes existantes.
- **Classe de Base** : Aussi appelée superclasse, c'est la classe à partir de laquelle d'autres classes héritent de propriétés et de comportements.
- **Classe Dérivée** : Aussi appelée sous-classe, c'est une classe qui hérite d'une autre classe.

## Avantages de l'Héritage

- **Réutilisabilité du Code** : Les classes héritées peuvent réutiliser le code de leurs classes de base.
- **Abstraction** : Permet d'abstraire les comportements et attributs communs dans une classe de base.
- **Polymorphisme** : Permet un comportement polymorphique où les classes dérivées peuvent être traitées comme des instances de leur classe de base.

## Conclusion

L'héritage est un mécanisme puissant en C# qui facilite l'organisation du code, la réutilisation et l'abstraction. En comprenant ses principes, les développeurs peuvent concevoir des systèmes orientés objet robustes et évolutifs.

---

# Héritage en C#

L'héritage est un concept fondamental en programmation orientée objet (POO) où une classe (sous-classe ou classe dérivée) hérite des propriétés et des comportements d'une autre classe (superclasse ou classe de base). Cela permet la réutilisation du code et la création de relations hiérarchiques entre les classes.

## Syntaxe de Base

En C#, la syntaxe pour l'héritage implique l'utilisation du symbole `:` suivi du nom de la classe de base.

```csharp
class ClasseDeBase
{
    // Membres de la classe de base
}

class ClasseDérivée : ClasseDeBase
{
    // Membres de la classe dérivée
}
```

## Le mot-clé `protected`

En C#, le mot-clé `protected` est un modificateur d'accès qui restreint l'accès aux membres (champs, méthodes, propriétés) à l'intérieur de la même classe ou des classes dérivées. Ce mot-clé est particulièrement utile pour implémenter l'encapsulation et faciliter la communication entre les classes de base et dérivées.

```csharp
partial class Employé
{
    // Membre protégé accessible aux classes dérivées
    protected string NomEmployé;

    // Exemple d'une méthode protégée
    protected void FaireActionProtégée()
    {
        // Détails de l'implémentation
    }
}
```

### Avantages et Considérations

- **Encapsulation** : Les membres protégés permettent un accès contrôlé à l'intérieur de la hiérarchie de classes, empêchant l'accès non autorisé depuis les classes externes.
- **Organisation du Code** : En exposant uniquement les membres nécessaires, l'accès protégé favorise une structure de classe plus propre et organisée.
- **Flexibilité** : Les classes dérivées peuvent utiliser les membres protégés pour étendre la fonctionnalité ou personnaliser le comportement sans modifier la classe de base.

### Exemple d'Utilisation

```csharp
class Manager : Employé
{
    public void AfficherNomEmployé()
    {
        Console.WriteLine($"Nom de l'employé : {NomEmployé}");
    }

    public void FaireActionManager()
    {
        // Accéder à une méthode protégée
        FaireActionProtégée();
    }
}
```

## Classes Scellées

En C#, une classe scellée est une classe qui ne peut pas être héritée par d'autres classes. Cela empêche la dérivation, ce qui signifie que la classe ne peut pas servir de classe de base pour une autre classe.

```csharp
sealed class ClasseUtilitaire
{
    // Membres de la classe utilitaire
}
```

### Cas d'Utilisation

- **Empêcher la Sous-classe** : Sceller une classe est utile lorsque vous voulez vous assurer que sa fonctionnalité ne peut pas être étendue ou modifiée.
- **Optimisation** : Des optimisations du compilateur peuvent être appliquées aux classes scellées, améliorant potentiellement les performances.

### Exemple

```csharp
sealed class UtilitaireMathématique
{
    public static int Ajouter(int a, int b)
    {
        return a + b;
    }
}

// Ne peut pas hériter d'une classe scellée
// class UtilitaireMathématiqueÉtendu : UtilitaireMathématique {} 
```

## Conclusion

L'héritage est un mécanisme puissant en C# qui facilite la réutilisation du code et l'organisation hiérarchique des classes. En utilisant des mots-clés comme `protected` et `sealed`, il est possible d'affiner les niveaux d'accès et les relations entre les classes, améliorant la maintenabilité et l'extensibilité de votre code.