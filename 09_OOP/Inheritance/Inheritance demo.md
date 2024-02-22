```csharp
using System;

namespace CSharpSpeedrun
{
    class Book // parent class
    {
        public string title = "Sapiens"; // title field initialized with default value
    }

    class EBook : Book // child class inheriting from Book
    {
        public string format = "Pdf"; // additional field specific to EBook
    }

    class Program
    {
        static void Main(string[] args)
        {
            EBook myEBook = new EBook(); // creating an instance of EBook
            Console.WriteLine(myEBook.title + ", format = " + myEBook.format); // printing title and format
        }
    }
}
// Output: Sapiens, format = Pdf
```

Dans ce code, nous illustrons l'implémentation de l'héritage en C#. Nous avons deux classes, `Book` (livre) et `EBook` (livre électronique). La classe `EBook` hérite de la classe `Book`, ce qui signifie qu'elle hérite de toutes ses propriétés et méthodes publiques.

Dans la classe `Book`, nous avons un champ `title` (titre) initialisé avec la valeur par défaut "Sapiens". Puisque le titre est une caractéristique commune à tous les types de livres, il est logique de le définir dans la classe parente.

La classe `EBook` ajoute un champ supplémentaire `format`, qui spécifie le format du livre électronique. Lorsque nous créons une instance de `EBook` dans la méthode `Main`, nous avons accès à la fois au titre défini dans la classe `Book` et au format spécifique de l'e-book.

Le résultat de l'exécution affiche le titre du livre ("Sapiens") suivi du format ("Pdf") du livre électronique.

Ce code illustre les principes fondamentaux de l'héritage en programmation orientée objet, où les classes peuvent hériter des propriétés et des comportements d'autres classes, permettant une réutilisation efficace du code et une meilleure organisation des concepts.