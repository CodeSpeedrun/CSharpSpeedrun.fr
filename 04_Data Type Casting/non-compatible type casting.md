### Qu'est-ce que la conversion de types non compatible?

Parfois, nous ne pouvons pas utiliser la conversion implicite ou explicite car les types de données sont trop différents. Par exemple, le compilateur générera une erreur lors de la conversion de types de données de chaîne (string) en entier (int).

```csharp
namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
           string myLuckyText = "938473"; 
           int myLuckyInt = Convert.ToInt32(myLuckyText); 
           Console.WriteLine(myLuckyInt);
        }
    }
}
```

#### Détails et explication :

Dans l'exemple ci-dessus, nous avons une chaîne de caractères (`string`) contenant un numéro `"938473"`. Nous essayons de le convertir en un type entier (`int`). Cependant, il n'est pas possible d'effectuer une conversion implicite ou explicite car les types sont fondamentalement différents. 

#### Méthodes de conversion de type en C# :

- **Conversion implicite :** Ce type de conversion est effectué automatiquement par le compilateur lorsque aucun risque de perte de données n'est possible. Par exemple, conversion de `int` en `float`.

- **Conversion explicite :** Ce type de conversion est effectué en utilisant des opérateurs de casting explicites. Par exemple, `(float)intVariable`.

- **Méthodes de conversion :** C# fournit également diverses méthodes de conversion pour convertir des types de données. Dans l'exemple ci-dessus, nous utilisons `Convert.ToInt32()` pour convertir une chaîne en un entier.

#### Gestion d'exceptions :

Dans cet exemple, la méthode `Convert.ToInt32()` peut générer une exception si la chaîne fournie ne représente pas un nombre valide. Il est important de gérer ces exceptions dans le code, par exemple en utilisant des blocs `try-catch` pour capturer et gérer les erreurs éventuelles.

#### Exemple supplémentaire :

```csharp
string numberAsString = "123";
int number;
if (int.TryParse(numberAsString, out number))
{
    Console.WriteLine("Conversion réussie: " + number);
}
else
{
    Console.WriteLine("Impossible de convertir la chaîne en entier.");
}
```

Dans cet exemple, nous utilisons la méthode `int.TryParse()` pour tenter une conversion sécurisée de la chaîne en entier. Cela évite de générer une exception si la chaîne n'est pas un nombre valide. Au lieu de cela, la méthode renvoie simplement `true` si la conversion réussit, ou `false` sinon.