# Création de routines de conversion personnalisées

Les routines de conversion personnalisées permettent de contrôler explicitement ou implicitement le comportement des types lors d'une tentative de conversion.

## Conversion explicite

La conversion explicite est une conversion où vous spécifiez explicitement le type de conversion à effectuer. Dans l'exemple suivant, nous définissons une conversion explicite d'un rectangle en un carré.

```csharp
public struct Rectangle
{
    public int Height;
    public int Width;
}

public struct Square
{
    public int Length;

    // Conversion explicite d'un rectangle en un carré.
    public static explicit operator Square(Rectangle rectangle)
    {
        Square square = new Square { Length = rectangle.Height };
        return square;
    }
}
```

Dans cet exemple, la méthode `explicit operator Square(Rectangle rectangle)` permet de convertir explicitement un objet de type `Rectangle` en un objet de type `Square`. Nous utilisons la hauteur du rectangle pour définir la longueur du carré, car un carré possède des côtés égaux.

## Conversion implicite

La conversion implicite est une conversion qui est automatiquement effectuée par le compilateur. Dans l'exemple suivant, nous définissons une conversion implicite d'un entier en un carré.

```csharp
public struct Square
{
    public int Length;

    // Conversion implicite d'un entier en un carré.
    public static explicit operator Square(int sideLength)
    {
        Square square = new Square { Length = sideLength };
        return square;
    }
}
```

Dans cet exemple, la méthode `explicit operator Square(int sideLength)` permet de convertir implicitement un entier en un objet de type `Square`. Cette conversion est implicite car elle est automatiquement effectuée lorsque nous affectons un entier à une variable de type `Square`.

## Exemples supplémentaires

- Les conversions personnalisées sont souvent utilisées pour faciliter l'interopérabilité entre différents types dans un programme.
- Elles permettent également de définir des comportements spécifiques lors de la conversion entre des types.

### Conversion entre carré et entier

Parfois, nous pourrions avoir besoin de convertir un carré en un entier ou vice versa. Voici comment nous pouvons définir ces conversions :

```csharp
public struct Square
{
    public int Length;

    // Conversion explicite d'un carré en un entier.
    public static explicit operator int(Square square) => square.Length;

    // Conversion implicite d'un entier en un carré.
    public static explicit operator Square(int sideLength)
    {
        Square square = new Square { Length = sideLength };
        return square;
    }
}
```

Dans cet exemple, nous avons ajouté une méthode pour convertir un carré en un entier (`explicit operator int(Square square)`) et nous avons également modifié la méthode existante pour convertir un entier en un carré pour que la conversion soit implicite (`explicit operator Square(int sideLength)`).

Les conversions personnalisées offrent une flexibilité accrue dans la gestion des types et des conversions dans les programmes C#.