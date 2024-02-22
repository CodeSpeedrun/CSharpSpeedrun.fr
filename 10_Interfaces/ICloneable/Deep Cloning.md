# Un exemple de clonage plus élaboré

Cet exemple illustre le clonage d'objets en C#, qui permet de créer une copie d'un objet tout en préservant son état. Nous explorerons comment implémenter l'interface `ICloneable` et gérer le clonage pour les objets avec des références imbriquées.

## La classe PointDescription

La classe `PointMetadata` décrit un point avec un surnom et un identifiant unique (`PointID`). Cette classe est responsable de la conservation des métadonnées concernant un point.

```csharp
public class PointMetadata
{
    public string PetName { get; set; }
    public Guid PointID { get; set; }

    public PointMetadata()
    {
        PetName = "Sans-nom";
        PointID = Guid.NewGuid();
    }
}
```

## La classe Point

La classe `CustomPoint` représente un point dans un espace bidimensionnel. Elle implémente l'interface `ICloneable` pour prendre en charge le clonage.

```csharp
public class CustomPoint : ICloneable
{
    public int XCoordinate { get; set; }
    public int YCoordinate { get; set; }
    public PointMetadata Metadata { get; set; } = new PointMetadata();

    public CustomPoint(int x, int y, string petName)
    {
        XCoordinate = x;
        YCoordinate = y;
        Metadata.PetName = petName;
    }

    public CustomPoint(int x, int y)
    {
        XCoordinate = x;
        YCoordinate = y;
    }

    public CustomPoint() { }

    public override string ToString() =>
        $"X = {XCoordinate}; Y = {YCoordinate}; Nom = {Metadata.PetName};\nID = {Metadata.PointID}\n";

    public object Clone()
    {
        CustomPoint nouveauPoint = (CustomPoint)this.MemberwiseClone();
        nouveauPoint.Metadata = new PointMetadata
        {
            PetName = this.Metadata.PetName,
            PointID = this.Metadata.PointID
        };
        return nouveauPoint;
    }
}
```

## Clonage des objets

Nous démontrons le clonage en créant deux objets `CustomPoint` (`point1` et `point2`). Nous clonons `point1` pour créer `clonedPoint`.

```csharp
Console.WriteLine("***** Amusement avec le clonage d'objets *****\n");

CustomPoint point1 = new CustomPoint(100, 100, "Jane");
CustomPoint point2 = new CustomPoint(200, 200, "John");

Console.WriteLine("Points originaux:");
Console.WriteLine("point1: {0}", point1);
Console.WriteLine("point2: {0}", point2);

CustomPoint clonedPoint = (CustomPoint)point1.Clone();
Console.WriteLine("\nCloné point1 et stocké le nouveau CustomPoint dans clonedPoint");

Console.WriteLine("Cloné point1:");
Console.WriteLine("clonedPoint: {0}", clonedPoint);

Console.ReadLine();
```

## Conclusion

Le clonage d'objets est une technique utile pour créer des copies d'objets, surtout lorsqu'il s'agit de graphes d'objets complexes. En implémentant l'interface `ICloneable` et en gérant la logique de clonage, les développeurs peuvent garantir que les objets sont dupliqués avec précision, y compris toutes les références imbriquées.