## Encapsulation en C#

L'encapsulation est un concept fondamental en programmation orientée objet qui met l'accent sur la capacité de cacher les détails d'implémentation inutiles à l'utilisateur d'un objet. Elle favorise la protection des données et empêche l'accès direct à l'état interne d'un objet, améliorant ainsi la fiabilité et la maintenabilité du code.

### Importance de l'Encapsulation

L'encapsulation garantit que l'état interne d'un objet est protégé contre un accès, une manipulation ou une corruption non intentionnels ou non autorisés. En cachant les détails d'implémentation, elle fournit une interface propre pour interagir avec les objets, favorisant la modularité et l'abstraction.

### Exemple : Classe de Lecteur de Base de Données

Considérons une classe hypothétique `DatabaseReader` avec les méthodes `Open()` et `Close()` :

```csharp
class DatabaseReader
{
    public void Open()
    {
        // Code pour ouvrir la connexion à la base de données
    }

    public void Close()
    {
        // Code pour fermer la connexion à la base de données
    }
}
```

### Protection des Données

Pour protéger l'état d'un objet, il est essentiel de spécifier les données en utilisant des modificateurs d'accès tels que `private`, `internal` ou `protected`. Ces modificateurs contrôlent la visibilité et l'accessibilité des membres au sein d'une classe.

### Champ Public vs. Données Privées

L'utilisation de champs publics peut entraîner une corruption des données et violer les principes d'encapsulation. Par exemple :

```csharp
class Book
{
    public int NumberOfPages;
}

Book novel = new Book();
novel.NumberOfPages = 300;
```

Ici, `NumberOfPages` est directement accessible et peut être modifié sans aucune restriction, ce qui peut entraîner des problèmes potentiels.

### Techniques d'Encapsulation

Il existe deux techniques principales pour encapsuler les données en C# :

1. **Méthodes d'Accesseur et de Mutateur :**
Ce sont des méthodes publiques qui fournissent un accès contrôlé aux données privées. Elles permettent à l'utilisateur de récupérer (`get`) ou de modifier (`set`) la valeur d'un champ privé de manière indirecte.

```csharp
class Book
{
    private int numberOfPages;

    public int GetNumberOfPages()
    {
        return numberOfPages;
    }

    public void SetNumberOfPages(int pages)
    {
        // Optionnel : Ajouter ici la logique de validation
        numberOfPages = pages;
    }
}
```

2. **Propriétés :**

   Les propriétés sont une manière plus concise de définir des méthodes d'accesseur et de mutateur en C#. Elles encapsulent un champ privé et l'exposent via une syntaxe de get/set.

   ```csharp
   class Book
   {
       private int numberOfPages;

       public int NumberOfPages
       {
           get { return numberOfPages; }
           set
           {
               // Optionnel : Ajouter ici la logique de validation
               numberOfPages = value;
           }
       }
   }
   ```

### Programmation en Boîte Noire

L'encapsulation facilite également la programmation en boîte noire, où les fonctionnements internes d'un objet sont cachés aux utilisateurs externes. Cela permet des changements dans l'implémentation sans affecter le code client.

### Conclusion

L'encapsulation est un pilier de la programmation orientée objet, favorisant la protection des données, la modularité et la maintenabilité du code. En cachant les détails d'implémentation et en fournissant un accès contrôlé aux données, elle permet un développement logiciel robuste et évolutif en C#.