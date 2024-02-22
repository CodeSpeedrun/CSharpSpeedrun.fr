# Conception des hiérarchies d'interfaces

Les hiérarchies d'interfaces sont essentielles pour le développement logiciel, vous permettant d'étendre les fonctionnalités des interfaces existantes sans perturber la base de code existante.

## Interface `IDrawable`

```csharp
public interface IDrawable
{
    void Draw();
}
```

L'interface `IDrawable` déclare une méthode `Draw()`, définissant le comportement de base pour tout objet dessinable.

## Interface `IAdvancedDraw`

```csharp
public interface IAdvancedDraw : IDrawable
{
    void DrawInCustomBox(int top, int left, int bottom, int right);
    void DrawFlipped();
}
```

L'interface `IAdvancedDraw` étend `IDrawable` et introduit des méthodes supplémentaires : `DrawInCustomBox()` et `DrawFlipped()`, fournissant des capacités de dessin plus avancées.

## Classe `CustomImageRenderer`

```csharp
public class CustomImageRenderer : IAdvancedDraw
{
    public void Draw()
    {
        Console.WriteLine("Dessin de base...");
    }

    public void DrawInCustomBox(int top, int left, int bottom, int right)
    {
        Console.WriteLine("Dessin dans une boîte personnalisée...");
    }

    public void DrawFlipped()
    {
        Console.WriteLine("Dessin retourné...");
    }
}
```

La classe `CustomImageRenderer` implémente l'interface `IAdvancedDraw`, offrant des implémentations concrètes pour chaque méthode, répondant aux besoins de rendu personnalisé.

## Exemple d'utilisation

```csharp
// Créer une instance de CustomImageRenderer
CustomImageRenderer renderer = new CustomImageRenderer();

// Appeler la méthode de dessin de base
renderer.Draw();

// Appeler la méthode pour dessiner dans une boîte personnalisée
renderer.DrawInCustomBox(30, 30, 300, 350);

// Appeler la méthode pour dessiner retourné
renderer.DrawFlipped();
```

Ici, nous démontrons l'utilisation de la classe `CustomImageRenderer` en invoquant ses méthodes de dessin. Ces méthodes exploitent les fonctionnalités définies dans l'interface `IAdvancedDraw`.

## Implémentation d'interface explicite

```csharp
// Accès explicite aux méthodes d'IAdvancedDraw
if (renderer is IAdvancedDraw advancedRenderer)
{
    advancedRenderer.DrawFlipped();
}
```

Ce code illustre comment accéder explicitement aux méthodes définies dans l'interface `IAdvancedDraw` à partir d'une instance de `CustomImageRenderer`.

## Conclusion

Les hiérarchies d'interfaces jouent un rôle crucial dans la conception logicielle, permettant la création de systèmes modulaires et extensibles. L'exemple présenté ici démontre comment les hiérarchies d'interfaces peuvent être utilisées pour développer des solutions de rendu flexibles, répondant à divers besoins d'application.