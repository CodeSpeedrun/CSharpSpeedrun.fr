# Compréhension des types Record en C#

Les types Record en C# sont une forme spécialisée de classe qui offre une sémantique de valeur pour l'égalité ainsi que l'immutabilité. Ce document explorera le concept des types Record, leur utilisation, et comment ils diffèrent des classes traditionnelles.

## Introduction aux Types Record

Les types Record en C# sont des types de référence qui offrent des méthodes synthétisées pour la sémantique de valeur, les rendant particulièrement utiles pour les scénarios où l'immutabilité et les comparaisons d'égalité sont essentielles. Ils simplifient le processus de création de structures de données immuables en fournissant des implémentations par défaut pour la comparaison d'égalité et l'immutabilité.

## Structure de base d'un Type Record

```csharp
record CarInfo
{
    public string Make { get; init; }
    public string Model { get; init; }
    public string Color { get; init; }

    public CarInfo() {}
    public CarInfo(string make, string model, string color)
    {
        Make = make;
        Model = model;
        Color = color;
    }
}
```

Dans cet exemple, `CarInfo` est un type Record représentant des informations sur une voiture. Il se compose de propriétés pour la marque, le modèle et la couleur de la voiture, toutes initialisées en utilisant l'accesseur `init` pour garantir l'immutabilité. Le type Record comprend également des constructeurs pour créer des instances avec et sans paramètres.

## Principales Caractéristiques des Types Record

### Immutabilité
Les types Record sont immuables par défaut, ce qui signifie qu'une fois créés, leurs propriétés ne peuvent pas être modifiées. Cela est réalisé en utilisant l'accesseur `init` pour les setters de propriété, comme démontré dans le type Record `CarInfo`.

### Sémantique de Valeur
Les types Record fournissent une sémantique de valeur pour la comparaison d'égalité. Cela signifie que deux instances de type Record sont considérées comme égales si toutes leurs propriétés ont les mêmes valeurs. Les méthodes de comparaison d'égalité (`Equals`, `GetHashCode`, `==`, et `!=`) sont automatiquement générées en fonction des propriétés du type Record.

### Commodité
Les types Record éliminent le besoin d'implémentation manuelle des méthodes de comparaison d'égalité et d'application d'immutabilité, ce qui peut être fastidieux et propice aux erreurs lors de l'utilisation de classes traditionnelles. Ils offrent une manière concise et pratique de définir des structures de données immuables.

## Utilisation des Types Record

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        CarInfo car1 = new CarInfo("Toyota", "Camry", "Red");
        CarInfo car2 = new CarInfo("Toyota", "Camry", "Red");

        // Comparaison d'égalité
        if (car1 == car2)
        {
            Console.WriteLine("Les voitures sont égales.");
        }
        else
        {
            Console.WriteLine("Les voitures ne sont pas égales.");
        }
    }
}
```

Dans cet exemple d'utilisation, deux instances de `CarInfo` sont créées avec des valeurs de propriétés identiques. La comparaison d'égalité entre `car1` et `car2` démontre la sémantique de valeur fournie par les types Record.

## Conclusion

Les types Record en C# offrent un mécanisme puissant pour créer des structures de données immuables avec un support intégré pour la sémantique de valeur. Ils simplifient le processus de définition de classes avec des propriétés immuables et des comparaisons d'égalité, offrant une solution plus concise et pratique par rapport aux classes traditionnelles.