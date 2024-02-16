# Types imbriqués en C#

En C#, il est possible de définir un type (tel qu'une énumération, une classe, une interface, une structure ou un délégué) directement dans la portée d'une autre classe ou structure. Cette fonctionnalité est connue sous le nom de types imbriqués.

## Définition des types imbriqués

Les types imbriqués peuvent être définis à l'intérieur des accolades `{}` d'une classe ou structure externe. Ces types imbriqués peuvent avoir différents modificateurs d'accès, tels que `public`, `private`, `protected` ou `internal`, définissant leur visibilité et leur accessibilité.

```csharp
public class ClasseExterne
{
    // Définition d'une classe imbriquée publique.
    public class ClasseInternePublique {}
    
    // Exemple d'utilisation de la classe interne publique.
    ClasseExterne.ClasseInternePublique interne = new ClasseExterne.ClasseInternePublique();
}
```

## Accès aux types imbriqués

Les types imbriqués peuvent être accédés en utilisant leur nom entièrement qualifié, qui inclut le nom de la classe externe suivi d'un point (`.`) puis le nom du type imbriqué.

```csharp
ClasseExterne.ClasseInternePublique interne = new ClasseExterne.ClasseInternePublique();
```

## Visibilité des types imbriqués

La visibilité d'un type imbriqué détermine où il peut être accédé. Par exemple, un type imbriqué public peut être accédé par n'importe quel code ayant accès à la classe externe, tandis qu'un type imbriqué privé n'est accessible qu'à l'intérieur de la classe conteneur.

## Avantages des types imbriqués

### Encapsulation

Les types imbriqués permettent d'encapsuler des fonctionnalités connexes au sein d'une seule classe ou structure. Cela aide à organiser le code et à réduire l'encombrement de l'espace de noms.

### Masquage d'informations

En rendant certains types imbriqués privés, vous pouvez masquer les détails d'implémentation et ne rendre accessible que la fonctionnalité nécessaire à l'extérieur.

### Amélioration de la lisibilité

Les types imbriqués peuvent améliorer la lisibilité du code en regroupant des types connexes, ce qui facilite la compréhension des relations entre eux pour les développeurs.

## Exemples

### Classes imbriquées

```csharp
public class ClasseExterne
{
    // Classe imbriquée pour représenter un point dans l'espace 2D.
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    
    // Exemple d'utilisation :
    Point origine = new Point { X = 0, Y = 0 };
}
```

### Énumérations imbriquées

```csharp
public class ClasseExterne
{
    // Énumération imbriquée pour représenter les jours de la semaine.
    public enum JoursDeLaSemaine
    {
        Lundi,
        Mardi,
        Mercredi,
        Jeudi,
        Vendredi,
        Samedi,
        Dimanche
    }
    
    // Exemple d'utilisation :
    JoursDeLaSemaine aujourdHui = JoursDeLaSemaine.Lundi;
}
```

### Interfaces imbriquées

```csharp
public class ClasseExterne
{
    // Interface imbriquée pour représenter une forme.
    public interface IForme
    {
        double CalculerSurface();
    }
    
    // Classe imbriquée implémentant l'interface IForme.
    public class Cercle : IForme
    {
        public double Rayon { get; set; }
        
        public double CalculerSurface()
        {
            return Math.PI * Math.Pow(Rayon, 2);
        }
    }
    
    // Exemple d'utilisation :
    IForme forme = new Cercle { Rayon = 5 };
    double surface = forme.CalculerSurface();
}
```

## Conclusion

Les types imbriqués sont une fonctionnalité puissante en C# qui permet une meilleure organisation, encapsulation et lisibilité du code. En imbriquant des types les uns dans les autres, vous pouvez créer des solutions logicielles plus modulaires et maintenables.