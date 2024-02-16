# Aperçu des Membres de System.Array

La classe `System.Array` en C# offre plusieurs méthodes et propriétés pour manipuler les tableaux de manière efficace. Voici quelques-uns des principaux membres de la classe `System.Array` ainsi que leur signification et leur utilisation.

## Méthodes

### Clear()
- `Clear()` est une méthode statique qui définit une plage d'éléments dans le tableau sur des valeurs vides.
- Pour les types numériques, cela définit les éléments à 0, pour les références d'objets, cela les définit sur null, et pour les booléens, cela les définit sur false.
- **Exemple**:
  ```csharp
  int[] numbers = { 1, 2, 3, 4, 5 };
  Array.Clear(numbers, 0, numbers.Length);
  ```

### CopyTo()
- La méthode `CopyTo()` copie des éléments du tableau source dans le tableau de destination.
- **Exemple**:
  ```csharp
  int[] source = { 1, 2, 3 };
  int[] destination = new int[3];
  source.CopyTo(destination, 0);
  ```

### Reverse()
- `Reverse()` est une méthode statique qui inverse le contenu d'un tableau unidimensionnel.
- **Exemple**:
  ```csharp
  int[] numbers = { 1, 2, 3, 4, 5 };
  Array.Reverse(numbers);
  ```

### Sort()
- `Sort()` est une méthode statique qui trie un tableau unidimensionnel de types intrinsèques.
- Elle utilise le comparateur par défaut pour le type, ou vous pouvez fournir un comparateur personnalisé si les éléments implémentent l'interface `IComparer`.
- **Exemple**:
  ```csharp
  int[] numbers = { 5, 3, 1, 4, 2 };
  Array.Sort(numbers);
  ```

## Propriétés

### Length
La propriété `Length` renvoie le nombre d'éléments dans le tableau.
**Exemple**:
  ```csharp
  int[] numbers = { 1, 2, 3, 4, 5 };
  int length = numbers.Length;
  ```

### Rank
La propriété `Rank` renvoie le nombre de dimensions du tableau actuel.
**Exemple**:
  ```csharp
  int[] numbers = { 1, 2, 3, 4, 5 };
  int rank = numbers.Rank;
  ```

## Indexation et Tranchage

### Indexation
L'indexation dans les tableaux C# permet d'accéder aux éléments individuels par leur position.
**Exemple**:
  ```csharp
  string[] gothicBands = { "Type O Negative", "Sisters of Mercy", "Bauhaus", "The Cure" };
  int idx = 2;
  Console.WriteLine(gothicBands[idx]); // Sortie: Bauhaus
  ```

### Tranchage
- Le tranchage permet de créer des sous-tableaux en spécifiant une plage d'indices.
**Exemples**:
- Sélectionner les trois premiers éléments:
```csharp
var firstThree = gothicBands[0..3]; // Sortie: {"Type O Negative", "Sisters of Mercy", "Bauhaus"}
```
- Sélectionner tous les éléments sauf le dernier:
```csharp
var allButLast = gothicBands[..^1]; // Sortie: {"Type O Negative", "Sisters of Mercy", "Bauhaus"}
```
- Sélectionner tous les éléments:
```csharp
var all = gothicBands[..]; // Sortie: {"Type O Negative", "Sisters of Mercy", "Bauhaus", "The Cure"}
```
- Sélectionner les deux premiers éléments:
```csharp
var firstTwo = gothicBands[0..^2]; // Sortie: {"Type O Negative", "Sisters of Mercy"}
```
  