## Polymorphisme en C#

Le polymorphisme est un concept fondamental en programmation orientée objet qui permet à des objets de types différents d'être traités comme des objets d'un type de base commun. Cette caractéristique capture la capacité d'un langage à traiter des objets liés de manière similaire.

### Membres virtuels vs Méthodes abstraites

#### Membres virtuels
Un membre virtuel dans une classe de base définit une implémentation par défaut pouvant être modifiée (surclassée) par une classe dérivée. Cela permet aux classes dérivées de fournir leur propre implémentation tout en utilisant le comportement de la classe de base selon les besoins.

#### Méthodes abstraites
Une méthode abstraite, en revanche, est un membre dans une classe de base qui ne fournit pas d'implémentation par défaut mais fournit une signature. Lorsqu'une classe dérive d'une classe de base définissant une méthode abstraite, elle doit fournir sa propre implémentation. Les méthodes abstraites obligent les classes dérivées à implémenter la méthode, garantissant ainsi la cohérence du comportement à travers différents types dérivés.

### Exemple de code

Considérez le fragment de code C# suivant, qui démontre le polymorphisme en instruisant un tableau de types dérivés de `Shape` à se rendre en utilisant la méthode `Draw()` :

```csharp
Shape[] shapes = new Shape[3];
shapes[0] = new Hexagon();
shapes[1] = new Circle();
shapes[2] = new Hexagon();

foreach (Shape shape in shapes)
{
    // Utiliser l'interface polymorphe !
    shape.Draw();
}
```

Dans cet exemple :
- `Shape` est une classe de base représentant une forme géométrique.
- `Hexagon` et `Circle` sont des classes dérivées héritant de `Shape`.
- Chaque forme dans le tableau `shapes` est traitée uniformément grâce au polymorphisme, malgré les types différents.

### Détails de l'implémentation

1. **Classe de base Shape** : Cette classe sert de base pour différentes formes géométriques et définit une méthode virtuelle `Draw()`.

   ```csharp
   public abstract class Shape
   {
       // Méthode virtuelle
       public virtual void Draw()
       {
           Console.WriteLine("Dessiner une forme.");
       }
   }
   ```

2. **Classes dérivées** : `Hexagon` et `Circle` sont dérivées de `Shape` et fournissent leurs propres implémentations de la méthode `Draw()`.

   ```csharp
   public class Hexagon : Shape
   {
       public override void Draw()
       {
           Console.WriteLine("Dessiner un hexagone.");
       }
   }

   public class Circle : Shape
   {
       public override void Draw()
       {
           Console.WriteLine("Dessiner un cercle.");
       }
   }
   ```

3. **Utilisation polymorphe** : Dans le code principal, un tableau d'objets `Shape` est créé et rempli avec des instances de `Hexagon` et de `Circle`. La boucle `foreach` itère à travers chaque forme dans le tableau et invoque la méthode `Draw()`, qui appelle dynamiquement l'implémentation appropriée en fonction du type réel de chaque forme.

### Conclusion

Le polymorphisme améliore la flexibilité et l'extensibilité du code en permettant à différents objets d'être traités uniformément via une interface commune. Les membres virtuels et les méthodes abstraites jouent un rôle clé dans la création de comportements polymorphes dans les langages de programmation orientés objet tels que C#. Comprendre ces concepts est essentiel pour développer des systèmes logiciels robustes et maintenables.