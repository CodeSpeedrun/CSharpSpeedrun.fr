```csharp
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main()
        {
             Book myBook = new Book();
             Console.WriteLine(myBook.id);
        }
    }
 
    class Book
    {
        public int id = 523; // Public field 'id' with value 523
        private string title = "Harry Potter"; // Private field 'title' with value "Harry Potter"
    }
}
// Output: 523
```

Ce programme en C# démontre l'utilisation des différents modificateurs d'accès. Voici une explication détaillée :

- **public** : Il s'agit d'un modificateur d'accès qui rend l'élément accessible à toutes les classes dans l'application. Dans l'exemple donné, `id` est déclaré comme un champ public dans la classe `Book`, donc il est accessible dans la classe `Program`.

- **private** : Ce modificateur limite l'accès à l'élément uniquement à l'intérieur de la même classe. Ainsi, le champ `title` est déclaré comme privé dans la classe `Book`, ce qui signifie qu'il ne peut être accédé qu'à partir de cette classe.

- **protected** : Ce modificateur autorise l'accès à l'élément à l'intérieur de la même classe ou via l'héritage. Il n'est pas utilisé dans cet exemple, mais il est important de le mentionner.

- **internal** : Ce modificateur permet d'accéder au code uniquement à l'intérieur de son propre assembly. Dans cet exemple, aucun élément n'est déclaré avec le modificateur `internal`.

Dans le programme, un objet de la classe `Book` est créé dans la méthode `Main`, et son champ `id` est affiché dans la console. Comme `id` est déclaré comme public, il peut être accédé depuis la classe `Program`, ce qui permet d'afficher sa valeur (523) sans erreur.