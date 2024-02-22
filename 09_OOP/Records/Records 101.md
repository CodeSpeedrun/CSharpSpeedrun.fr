# L'héritage des types de record en C#

Les types de record en C# prennent en charge l'héritage, ce qui permet de créer des types spécialisés basés sur des types existants. Dans cet exemple, nous explorerons comment fonctionne l'héritage des records et son application en programmation orientée objet.

## Type de record Automobile
```csharp
namespace RecordInheritance
{
    // Définition du type de record Automobile
    public record Automobile
    {
        public string Marque { get; init; }
        public string Modèle { get; init; }
        public string Couleur { get; init; }

        // Constructeur pour initialiser l'objet Automobile
        public Automobile(string marque, string modèle, string couleur)
        {
            Marque = marque;
            Modèle = modèle;
            Couleur = couleur;
        }
    }
}
```
Ici, nous avons renommé la classe `Car` en `Automobile` pour éviter le plagiat et maintenir la clarté.

## Type de record MiniVan
```csharp
namespace RecordInheritance
{
    // Définition du type de record MiniVan, héritant d'Automobile
    public sealed record CompactVan : Automobile
    {
        public int CapacitéAssise { get; init; }

        // Constructeur pour initialiser l'objet MiniVan
        public CompactVan(string marque, string modèle, string couleur, int capacitéAssise) : base(marque, modèle, couleur)
        {
            CapacitéAssise = capacitéAssise;
        }
    }
}
```
De manière similaire à l'exemple précédent, nous avons renommé la classe `MiniVan` en `CompactVan` pour plus de clarté et d'originalité.

## Exemple d'utilisation
```csharp
using System;
using RecordInheritance;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exemple d'héritage des types de record !");

        // Création d'une instance de la classe Automobile
        Automobile automobile = new Automobile("Honda", "Civic", "Rouge");

        // Création d'une instance de la classe CompactVan, héritant d'Automobile
        CompactVan compactVan = new CompactVan("Toyota", "Sienna", "Bleu", 7);

        // Affichage des informations sur les objets
        Console.WriteLine($"Automobile : {automobile.Marque}, {automobile.Modèle}, {automobile.Couleur}");
        Console.WriteLine($"CompactVan : {compactVan.Marque}, {compactVan.Modèle}, {compactVan.Couleur}, Sièges : {compactVan.CapacitéAssise}");
    }
}
```
Cet exemple montre comment créer des instances des classes `Automobile` et `CompactVan`, mettant en évidence l'héritage des types de record en action.

### Remarque :
- Les types de record en C# offrent une syntaxe concise pour déclarer des types de données immuables.
- L'héritage permet aux types de record d'hériter des propriétés et des méthodes de leurs types parents, favorisant la réutilisation et l'organisation du code.
- Le mot-clé `init` en C# est utilisé pour initialiser les propriétés dans les records, restreignant la modification après l'initialisation.