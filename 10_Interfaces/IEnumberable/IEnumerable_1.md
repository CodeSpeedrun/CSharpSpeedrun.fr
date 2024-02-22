### Qu'est-ce que IEnumerable ?

- La majuscule I dans `IEnumerable` indique qu'il s'agit d'une interface. 
Elle est principalement utilisée pour itérer sur des collections non génériques. 
- Avant tout, `IEnumerable` contient la méthode `GetEnumerator()`
qui renvoie un objet `IEnumerator`.

```csharp
/*
public interface IEnumerable<out T> : IEnumerable {
        IEnumerator<T> GetEnumerator();
        
public interface IEnumerable {
    IEnumerator GetEnumerator();

public interface IEnumerator {
    bool MoveNext();
    object Current { get; }
    void Reset();
*/
using System;
using System.Collections.Generic;

namespace CSharpSpeedrun
{
    public class Program
    {
        static void Main()
        {
            int[] ballIds = { 51, 7, 83 };
            List<int> batIds = new List<int>() { 12, 29, 27 };

            DisplayIds(ballIds);
            DisplayIds(batIds);
        }

        /*
        IEnumerable indique qu'il s'agit d'une collection pouvant être énumérée.
        <int> spécifie le type d'éléments dans la collection, dans ce cas, des entiers.
        */
        static void DisplayIds(IEnumerable<int> values)
        {
            foreach (int value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
/*
51
7
83
12
29
27
*/
```  