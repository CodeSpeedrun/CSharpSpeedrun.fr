# Classes vs Records vs Structs en C#

En C#, il existe plusieurs façons de définir des types de données personnalisés : les classes, les enregistrements (records), et les structures (structs). Chacun a ses cas d'utilisation, avantages et limitations. Comprendre les différences entre eux est crucial pour écrire un code efficace et maintenable.

## Classes

Les classes sont des types de référence et sont le moyen le plus couramment utilisé pour définir des types de données personnalisés en C#. Elles sont flexibles et peuvent contenir des champs, des propriétés, des méthodes, des événements, des indexeurs, des constructeurs, et même des types imbriqués.

```csharp
public class Personne
{
    public string Nom { get; set; }
    public int Âge { get; set; }

    public void AfficherInfos()
    {
        Console.WriteLine($"Nom : {Nom}, Âge : {Âge}");
    }
}
```

### Utilisation :

```csharp
var personne = new Personne { Nom = "Jean", Âge = 30 };
personne.AfficherInfos();
```

#### Avantages :
- Support de l'héritage et du polymorphisme.
- Flexibilité dans la définition du comportement à travers les méthodes et propriétés.
- Peut implémenter des interfaces.

#### Inconvénients :
- Consomme plus de mémoire en raison de leur nature de types de référence.
- Performances plus lentes par rapport aux structs.

## Enregistrements (Records)

Les enregistrements ont été introduits dans C# 9.0 et sont des types de référence immuables. Ils sont principalement utilisés pour modéliser des données immuables et bénéficient d'une sémantique d'égalité basée sur la valeur intégrée.

```csharp
public record Point(int X, int Y);
```

### Utilisation :

```csharp
var point1 = new Point(1, 2);
var point2 = new Point(1, 2);

Console.WriteLine(point1.Equals(point2)); // true
```

#### Avantages :
- Syntaxe concise pour définir des données immuables.
- Comparaison d'égalité basée sur la valeur intégrée.
- Utilisation efficace de la mémoire pour les petites structures de données immuables.

#### Inconvénients :
- L'immutabilité peut ne pas toujours être souhaitable.
- Personnalisation limitée par rapport aux classes.

## Structures (Structs)

Les structs sont des types de valeur en C# et sont couramment utilisés pour de petits objets légers qui sont fréquemment copiés, tels que des coordonnées, des couleurs, et d'autres types de données simples.

```csharp
public struct Rectangle
{
    public int Largeur { get; set; }
    public int Hauteur { get; set; }

    public int Surface() => Largeur * Hauteur;
}
```

### Utilisation :

```csharp
var rect = new Rectangle { Largeur = 5, Hauteur = 10 };
Console.WriteLine(rect.Surface()); // 50
```

#### Avantages :
- Meilleures performances par rapport aux classes en raison de leur nature de types de valeur.
- Convient pour les données petites et fréquemment copiées.
- L'allocation de pile peut conduire à une meilleure utilisation de la mémoire dans certains scénarios.

#### Inconvénients :
- Support limité pour l'héritage et le polymorphisme.
- La mise en boîte et la démise en boîte peuvent se produire lorsqu'elles sont utilisées dans certains contextes.

## Conclusion

Le choix entre les classes, les enregistrements et les structs dépend des exigences spécifiques de votre application. Les classes offrent une flexibilité et un support pour des scénarios complexes, tandis que les enregistrements sont idéaux pour la modélisation de données immuables. Les structs offrent de meilleures performances et une meilleure efficacité mémoire pour les données petites et fréquemment copiées. Comprendre les forces et les faiblesses de chacun vous permet de prendre des décisions éclairées lors de la conception de vos applications C#.