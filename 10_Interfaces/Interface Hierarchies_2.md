# Hiérarchies d'interfaces avec Implémentations par Défaut

Lorsqu'on travaille avec des hiérarchies d'interfaces en C#, il est courant de rencontrer des scénarios où les interfaces incluent des implémentations par défaut. Cela permet aux interfaces descendantes d'hériter de l'implémentation de l'interface de base ou de fournir leur propre implémentation par défaut. Explorons ce concept en profondeur.

## Définitions d'Interface
```csharp
public interface IRenderable
{
    void Render();
    int TimeToRender() => 5;
}

public interface IEnhancedRender : IRenderable
{
    void RenderInBoundingBox(int top, int left, int bottom, int right);
    void RenderUpsideDown();
    new int TimeToRender() => 15;
}
```

Dans l'extrait de code ci-dessus, nous avons deux interfaces :

- **IRenderable** : Cette interface définit une méthode `Render()` et une implémentation par défaut de `TimeToRender()`, qui renvoie 5.
- **IEnhancedRender** : Cette interface étend `IRenderable` et ajoute deux autres méthodes : `RenderInBoundingBox()` et `RenderUpsideDown()`. Elle remplace également l'implémentation par défaut de `TimeToRender()` pour renvoyer 15.

## Implémentation de Classe
```csharp
public class ImageRenderer : IEnhancedRender
{
    // Implémentation des méthodes de IEnhancedRender
    public void RenderInBoundingBox(int top, int left, int bottom, int right)
    {
        // Implémentation pour le rendu dans une boîte englobante spécifiée
    }

    public void RenderUpsideDown()
    {
        // Implémentation pour le rendu à l'envers
    }

    // Remplacement de l'implémentation par défaut de TimeToRender()
    public int TimeToRender() => 12;
}
```

Ici, nous avons une classe `ImageRenderer` qui implémente l'interface `IEnhancedRender`. Elle fournit des implémentations pour les méthodes `RenderInBoundingBox()` et `RenderUpsideDown()`, ainsi que remplace l'implémentation par défaut de `TimeToRender()`.

## Exemple d'Utilisation
```csharp
class Program
{
    static void Main(string[] args)
    {
        ImageRenderer myRenderer = new ImageRenderer();

        // Démonstration des appels de méthode
        Console.WriteLine("***** Appel de TimeToRender Implémenté *****");
        Console.WriteLine($"Temps de rendu : {myRenderer.TimeToRender()}");

        // Démonstration du polymorphisme
        IRenderable renderable = myRenderer;
        Console.WriteLine($"Temps de rendu (comme IRenderable) : {renderable.TimeToRender()}");

        IEnhancedRender enhancedRender = myRenderer;
        Console.WriteLine($"Temps de rendu (comme IEnhancedRender) : {enhancedRender.TimeToRender()}");
    }
}
```

Dans cet exemple, nous créons une instance de `ImageRenderer` et montrons comment appeler ses méthodes. Nous démontrons également le polymorphisme en traitant l'instance à la fois comme `IRenderable` et `IEnhancedRender`, montrant comment la méthode remplacée se comporte dans chaque contexte.

En utilisant les hiérarchies d'interfaces avec des implémentations par défaut, C# fournit un moyen flexible de structurer le code et de promouvoir la réutilisation du code tout en permettant la personnalisation à différents niveaux d'abstraction.