# Utilisation des Génériques en C#

Les génériques sont une fonctionnalité clé en C# qui permettent de créer des classes et des méthodes réutilisables, tout en fournissant un haut niveau de sécurité de type et de performances. Dans cette note, nous explorerons les avantages des génériques, leur syntaxe, ainsi que leur utilisation dans les collections.

## Avantages des Génériques

Les conteneurs génériques sont souvent préférés à leurs homologues non génériques car ils offrent généralement une meilleure sécurité de type et des avantages en termes de performances. Lorsque vous utilisez des classes de collection génériques, vous rectifiez tous les problèmes précédents, y compris les pénalités de boxing/déboxing et le manque de sécurité de type.

## Sécurité de Type et Performances

Les génériques fournissent de meilleures performances car ils n'entraînent pas de pénalités de boxing ou de déboxing lors du stockage de types de valeur. De plus, ils sont sécurisés au niveau du type car ils ne peuvent contenir que le type spécifié.

## Syntaxe des Génériques

Dans la syntaxe des génériques en C#, `<T>` est souvent utilisé comme un espace réservé. Par exemple, `IEnumerable<T>` peut être lu comme "IEnumerable de T" ou "IEnumerable de type T". En outre, `TKey` ou `K` est utilisé pour les clés et `TValue` ou `V` est utilisé pour les valeurs.

## Initialisation des Collections

L'initialisation des collections peut se faire de manière concise en utilisant la syntaxe d'initialisation des collections. Par exemple, pour initialiser une liste générique d'entiers, vous pouvez utiliser :

```csharp
List<int> maListe = new List<int> { 0, 1, 2, 3, 4, 5 };
```

## Exemple Complet

Considérons un exemple complet où nous utilisons des génériques pour créer une file d'attente de personnes :

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Création d'une file d'attente de personnes
        Queue<Personne> fileAttente = new Queue<Personne>();
        
        // Enfilement de quelques personnes
        fileAttente.Enqueue(new Personne { Nom = "Dupont", Prenom = "Jean" });
        fileAttente.Enqueue(new Personne { Nom = "Martin", Prenom = "Alice" });
        
        // Défilement de la première personne
        Personne premierePersonne = fileAttente.Dequeue();
        
        Console.WriteLine("La première personne dans la file d'attente est : " + premierePersonne.Prenom + " " + premierePersonne.Nom);
    }
}

class Personne
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
}
```

Dans cet exemple, nous utilisons la classe `Queue<T>` générique pour créer une file d'attente de personnes (`Personne`). Nous ajoutons ensuite des personnes à la file d'attente en utilisant la méthode `Enqueue`, puis nous défilons la première personne en utilisant la méthode `Dequeue`.


 
# Notes on Collection Initialization in C#

Les simples appels les désignent comme des espaces réservés. Vous pouvez lire le symbole <T> comme "de type T." Ainsi, vous pouvez lire IEnumerable<T> comme "IEnumerable de T" ou, autrement dit, "IEnumerable de type T."

TKey ou K est utilisé pour les clés, et TValue ou V est utilisé pour les valeurs.

## Compréhension de la syntaxe d'initialisation de collections

### Initialisation d'un tableau standard
```csharp
int[] tableauEntiers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
```
Cela initialise un tableau d'entiers avec des valeurs de 0 à 9.

### Initialisation d'une liste générique d'entiers
```csharp
List<int> listeGenerique = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
```
Ceci initialise une liste générique d'entiers avec les mêmes valeurs que le tableau précédent.

### Initialisation d'une liste de Points
```csharp
List<Point> listePoints = new List<Point>
{
    new Point { X = 2, Y = 2 },
    // Ajoutez ici d'autres points si nécessaire
};
```
Ceci initialise une liste de points avec un point ayant une coordonnée X de 2 et une coordonnée Y de 2.

### Copie de données dans un nouveau tableau
```csharp
Personne[] tableauPersonnes = personnes.ToArray();
```
Ceci copie les données d'une collection de personnes dans un nouveau tableau de personnes.

### Création d'une file d'attente de personnes
```csharp
Queue<Personne> filePersonnes = new Queue<Personne>();
filePersonnes.Enqueue(new Personne {Prenom = "Homer", Nom = "Simpson", Age = 47});
```
Ceci crée une file d'attente de personnes avec une personne ayant le prénom "Homer", le nom "Simpson" et l'âge 47.

Ces exemples illustrent différentes méthodes d'initialisation de collections en C#. Il est essentiel de comprendre ces concepts lors de la manipulation de données dans des programmes C#.