# Structure (Type de valeur)

En C#, les structures (également connues sous le nom de types de valeur) sont des alternatives légères aux classes. Elles sont utilisées pour encapsuler de petits groupes de variables liées. Les structures sont particulièrement utiles lorsque vous souhaitez travailler efficacement avec des types de données simples.

## Définition

```csharp
struct Coordonnée
{
    // Champs de la structure.
    public int X;
    public int Y;
    
    // Incrémente à la fois les coordonnées X et Y de 1.
    public void Déplacer()
    {
        X++;
        Y++;
    }
}
```

## Caractéristiques

- **Légèreté :** Les structures consomment moins de mémoire que les classes car elles sont stockées sur la pile plutôt que sur le tas.
- **Encapsulation :** Comme les classes, les structures peuvent encapsuler des données et des comportements.
- **Type de valeur :** Les structures sont passées par valeur, ce qui signifie qu'elles sont copiées lorsqu'elles sont passées en tant qu'arguments à des méthodes.

## Utilisation

Les structures sont couramment utilisées pour représenter des types de données simples tels que des points, des rectangles et d'autres agrégats de données de petite taille. Voici un exemple de l'utilisation d'une structure représentant un point 2D :

```csharp
Coordonnée point = new Coordonnée();
point.X = 5;
point.Y = 10;
point.Déplacer(); // Déplace le point en (6, 11)
```

## Données Privées

Si vous devez inclure des données privées dans votre structure, vous pouvez le faire en utilisant des propriétés :

```csharp
struct Coordonnée
{
    private int x;
    private int y;

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    // Incrémente à la fois les coordonnées X et Y de 1.
    public void Déplacer()
    {
        X++;
        Y++;
    }
}
```

## Modificateur Ref

Le modificateur `ref` peut être utilisé avec les structures pour garantir qu'elles sont allouées sur la pile. Cela les empêche d'être assignées en tant que propriétés d'une autre classe.

```csharp
public class Conteneur
{
    public ref Coordonnée Coordonnée { get; }
    
    public Conteneur(ref Coordonnée coordonnée)
    {
        Coordonnée = ref coordonnée;
    }
}
```

Dans cet exemple, la propriété `Coordonnée` de la classe `Conteneur` est une référence à une structure `Coordonnée`, garantissant qu'elle est allouée sur la pile et ne peut pas être assignée en tant que propriété d'une autre classe.
 