# Polymorphisme en C#

Le polymorphisme est un concept fondamental en programmation orientée objet (POO) qui permet à des objets de différents types d'être traités comme des objets d'un type de base commun. En C#, le polymorphisme est réalisé grâce au remplacement de méthode et à la surcharge de méthode.

## Remplacement de méthode et méthodes virtuelles

Le remplacement de méthode est une fonctionnalité qui permet à une sous-classe de fournir une implémentation spécifique d'une méthode déjà définie dans sa superclasse. Cela est réalisé en utilisant le mot-clé `override` en C#. Pour activer le remplacement de méthode, la méthode de la superclasse doit être déclarée comme `virtual`.

### Exemple :

```csharp
public class Employé
{
    // Une méthode virtuelle pouvant être remplacée par des classes dérivées.
    public virtual void DonnerBonus(float montant)
    {
        // Implémentation de base pour donner un bonus.
    }
}
```

Dans le code ci-dessus, la méthode `DonnerBonus` est déclarée comme `virtual` dans la classe `Employé`, ce qui indique qu'elle peut être remplacée par des sous-classes.

## Remplacement de méthode dans les classes dérivées

Lorsqu'une sous-classe souhaite fournir sa propre implémentation d'une méthode déjà définie dans sa superclasse, elle utilise le mot-clé `override`.

### Exemple :

```csharp
public class Vendeur : Employé
{
    // Remplace la méthode DonnerBonus pour fournir une implémentation spécifique pour les Vendeurs.
    public override void DonnerBonus(float montant)
    {
        // Implémentation personnalisée pour donner un bonus aux Vendeurs.
    }
}
```

Dans cet exemple, la classe `Vendeur` hérite de la classe `Employé` et remplace la méthode `DonnerBonus` pour fournir une implémentation différente spécifique aux vendeurs.

## Concepts supplémentaires

### Mot-clé Base

Le mot-clé `base` en C# est utilisé pour accéder aux membres de la classe de base depuis une classe dérivée. Il est souvent utilisé pour appeler le constructeur, les méthodes ou les propriétés de la classe de base.

### Exemple :

```csharp
public override void AfficherStatistiques()
{
    base.AfficherStatistiques(); // Appelle la méthode AfficherStatistiques de la classe de base.
    Console.WriteLine("Nombre de Ventes : {0}", NombreVentes);
}
```

Dans cet extrait, `base.AfficherStatistiques()` appelle la méthode `AfficherStatistiques` de la classe de base avant d'ajouter des fonctionnalités supplémentaires spécifiques à la classe `Vendeur`.

### Classes et méthodes abstraites

En plus de `virtual` et `override`, C# prend également en charge les classes et les méthodes `abstract`. Les méthodes abstraites sont déclarées sans implémentation et doivent être remplacées par des classes dérivées. Les classes abstraites ne peuvent pas être instanciées et sont souvent utilisées comme classes de base pour d'autres classes.

### Exemple :

```csharp
public abstract class Forme
{
    // Méthode abstraite pour calculer la superficie d'une forme.
    public abstract float CalculerSuperficie();
}
```

Dans le code ci-dessus, `Forme` est une classe abstraite avec une méthode abstraite `CalculerSuperficie()`. Toute classe héritant de `Forme` doit fournir une implémentation pour `CalculerSuperficie()`.

### Interfaces

Les interfaces en C# définissent un contrat que les classes peuvent implémenter. Elles ne contiennent que des signatures de méthode, des propriétés, des événements ou des indexeurs. Implémenter une interface garantit que la classe implémentant l'interface fournit des implémentations concrètes pour tous les membres de l'interface.

### Exemple :

```csharp
public interface IAffichable
{
    void Afficher();
}
```

Dans cet exemple, `IAffichable` est une interface avec une seule méthode `Afficher()`. Toute classe implémentant `IAffichable` doit fournir une implémentation pour la méthode `Afficher`.

## Conclusion

Le polymorphisme est un concept puissant en C# qui permet la réutilisation de code, la flexibilité et l'extensibilité en programmation orientée objet. En comprenant le remplacement de méthode, les méthodes virtuelles, les classes abstraites, les interfaces et les concepts connexes, les développeurs peuvent écrire un code plus maintenable et évolutif.