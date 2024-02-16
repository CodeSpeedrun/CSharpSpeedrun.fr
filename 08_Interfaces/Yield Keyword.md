## Qu'est-ce que le mot-clé Yield ?
Le type de retour du mot-clé yield renvoie toujours un objet IEnumerable.

```csharp
using System;
using System.Collections.Generic;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in Fibonacci(7))
            {
                Console.WriteLine(i);
            }
        }

        public static IEnumerable<int> Fibonacci(int range)
        {
            int number1 = 0, number2 = 1, result = 0;
            Console.WriteLine(number1); // affiche 0, 1
            Console.WriteLine(number2);
            for (int i = 2; i < range; i++)
            {
                result = number1 + number2;
                yield return result;
                number1 = number2;
                number2 = result;
            }
        }
    }
}
/*
0
1
1
2
3
5
8
*/
```
La raison pour laquelle la méthode Fibonacci semble "entrer et sortir de la méthode" 
est due à son utilisation de l'instruction `yield return`. 

En C#, lorsque vous utilisez `yield return` dans une méthode, 
vous indiquez que la méthode est un itérateur, 
et elle produira une séquence de valeurs paresseusement à la demande. 
Chaque fois que vous appelez `yield return`, cela produit une valeur 
dans la séquence et suspend temporairement l'exécution de la méthode, 
retournant le contrôle à l'appelant.

Voici comment cela fonctionne dans votre méthode Fibonacci :

1. La méthode commence à s'exécuter lorsqu'elle est appelée dans la boucle `foreach` dans la méthode `Main`.
2. Elle calcule le prochain nombre de Fibonacci (`result`) et le `yield return`.
3. Le contrôle revient à l'appelant (`Main`), et la prochaine itération de la boucle `foreach` continue là où elle s'était arrêtée.
4. La méthode `Main` affiche la valeur produite (`i`) et appelle ensuite à nouveau la méthode Fibonacci.
5. La méthode Fibonacci continue son exécution là où elle a été suspendue, et le processus se répète jusqu'à ce que la boucle se termine.

Ainsi, chaque fois que vous itérez sur la méthode `Fibonacci` en utilisant `foreach`, elle calcule le prochain nombre de Fibonacci et le renvoie à l'appelant, permettant à l'appelant de traiter la valeur avant de passer à l'itération suivante. 

Cette évaluation paresseuse est la raison pour laquelle il semble que la méthode "entre et sorte" de la boucle.
