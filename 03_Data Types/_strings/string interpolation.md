## Interpolation de chaînes

L'interpolation de chaînes est une méthode améliorée de combinaison de deux chaînes en C#. Le symbole dollar `$` au début de la chaîne indique au compilateur qu'il s'agit d'une chaîne interpolée. Les variables sont enveloppées dans des accolades `{}` et sont remplacées lors de l'exécution de l'application.

```csharp
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            string prenom = "Jean ";
            string nom = "Cena";

            Console.WriteLine($"Mon meilleur ami est {prenom}{nom}!");
        }
    }
}
```

#### Explication détaillée :
L'interpolation de chaînes est une manière pratique et lisible de formater les chaînes en insérant des variables dans des chaînes littérales. Dans l'exemple ci-dessus, la phrase `"Mon meilleur ami est {prenom}{nom}!"` utilise l'interpolation de chaînes pour insérer les valeurs des variables `prenom` et `nom` dans la chaîne finale.

**Points clés à retenir :**
- L'interpolation de chaînes commence par le symbole `$` pour indiquer au compilateur qu'il doit interpréter la chaîne de manière interpolée.
- Les variables sont insérées dans la chaîne en les plaçant entre des accolades `{}`.
- L'interpolation de chaînes rend le code plus lisible et évite les erreurs de concaténation de chaînes.
  
**Exemple supplémentaire :**

```csharp
string prenom = "Alice";
string nom = "Dupont";
int age = 30;

Console.WriteLine($"Bonjour, je m'appelle {prenom} {nom} et j'ai {age} ans.");
```

Dans cet exemple, trois variables sont interpolées dans une chaîne pour produire un message de salutation personnalisé avec le nom et l'âge.