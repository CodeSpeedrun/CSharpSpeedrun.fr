# L'ombre en C#

En C#, l'ombre fait référence au concept de définir un membre dans une classe dérivée qui a le même nom qu'un membre dans la classe de base, "ombrant" ainsi le membre de la classe de base. Cela permet à la classe dérivée d'avoir sa propre implémentation du membre, cachant ainsi l'implémentation de la classe de base. L'ombre est l'opposé logique du remplacement de méthode.

Lorsqu'il s'agit d'héritage, surtout dans des scénarios où vous sous-classez à partir de classes que vous n'avez pas créées vous-même (par exemple, des bibliothèques tierces), l'ombre peut être utile.

## Scénario d'exemple

Supposons que vous ayez une classe de base appelée `Shape`, qui définit une méthode appelée `Draw()`.

```csharp
class Shape
{
    public void Draw()
    {
        Console.WriteLine("Dessiner une forme");
    }
}
```

Maintenant, disons que vous voulez créer une sous-classe appelée `ThreeDShape`, qui étend `Shape` mais fournit sa propre implémentation de la méthode `Draw()`.

```csharp
class ThreeDShape : Shape
{
    public new void Draw()
    {
        Console.WriteLine("Dessiner une forme en 3D");
    }
}
```

Dans cet exemple, `ThreeDShape` ombrage la méthode `Draw()` de sa classe de base, `Shape`, avec sa propre implémentation.

## Utilisation

L'ombre est particulièrement utile lorsque vous souhaitez étendre la fonctionnalité d'une classe de base mais que vous ne pouvez pas modifier la classe de base directement, comme lorsque vous travaillez avec des bibliothèques ou des frameworks tiers.

## Notes supplémentaires

- L'ombre peut être appliquée non seulement aux méthodes, mais aussi à d'autres types de membres hérités d'une classe de base, y compris les champs, les constantes, les membres statiques et les propriétés.
- Vous pouvez accéder à la méthode ombragée de la classe de base en convertissant une instance de la classe dérivée en type de classe de base.

```csharp
ThreeDShape threeDShape = new ThreeDShape();
threeDShape.Draw();  // Appelle la méthode Draw() de ThreeDShape
((Shape)threeDShape).Draw();  // Appelle la méthode Draw() de Shape
```

## Conclusion

L'ombre permet d'étendre et de personnaliser le comportement des classes dans une hiérarchie d'héritage, offrant ainsi souplesse et modularité dans la conception logicielle. Cependant, elle doit être utilisée judicieusement pour éviter la confusion et maintenir la lisibilité du code.