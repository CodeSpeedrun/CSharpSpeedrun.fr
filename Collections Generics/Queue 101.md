
https://referencesource.microsoft.com/#mscorlib/system/collections/queue.cs
Classe depuis .net Framework
```csharp
public virtual void Enqueue(Object obj) {
if (_size == _array.Length) {
    int newcapacity = (int)((long)_array.Length * (long)_growFactor / 100);
    if (newcapacity < _array.Length + _MinimumGrow) {
        newcapacity = _array.Length + _MinimumGrow;
    }
    SetCapacity(newcapacity);
}

_array[_tail] = obj;
_tail = (_tail + 1) % _array.Length;
_size++;
_version++;
}
```

VS19 description
```csharp
namespace System.Collections.Generic {
    public class Queue<T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, ICollection {
        //
        // Summary:
        //     Adds an object to the end of the System.Collections.Generic.Queue`1.
        //
        // Parameters:
        //   item:
        //     The object to add to the System.Collections.Generic.Queue`1. The value can be
        //     null for reference types.
        public void Enqueue(T item);
```

Usage
```csharp
namespace CSharpSpeedrun {
    class Program: Queue {
        static void Main(string[] args) {
            Queue<string> clients = new Queue<string>();
```

Lorsque vous utilisez la classe `Queue<T>` dans votre code C#, vous interagissez généralement avec ses méthodes et propriétés publiques telles que `Enqueue`, `Dequeue`, `Peek`, `Count`, etc. Vous ne voyez pas directement ni n'interagissez avec les détails de l'implémentation de ces méthodes car elles font partie du framework .NET, qui est généralement fourni sous forme compilée (DLL).

L'implémentation de ces méthodes est effectivement réalisée au sein du framework .NET lui-même, et elle est écrite en C#. En tant que développeur, vous n'avez pas besoin de vous soucier des détails de l'implémentation interne de ces méthodes. Au lieu de cela, vous pouvez vous fier à leur comportement documenté et les utiliser dans votre code pour obtenir la fonctionnalité souhaitée.

Si vous êtes curieux de savoir comment ces méthodes sont implémentées en interne, vous pouvez explorer le code source du framework .NET sur GitHub ou utiliser un outil de décompilation, comme mentionné précédemment. Cependant, gardez à l'esprit que comprendre les détails de l'implémentation interne n'est souvent pas nécessaire pour utiliser efficacement ces classes dans vos applications.

++
Lorsque vous appelez `clients.Enqueue("Client2");`, l'implémentation de la .NET Framework est appelée via ce qu'on appelle une invocation de méthode.

Voici ce qui se passe en coulisse :

1. **Compilation** : Lorsque vous compilez votre code C#, le compilateur C# traduit votre code source en langage intermédiaire (IL).

2. **Exécution au moment de l'exécution** : Au moment de l'exécution, le Common Language Runtime (CLR) exécute le code IL. Lorsqu'il rencontre l'appel de méthode `Enqueue` sur l'objet `clients`, il recherche l'implémentation de la méthode dans les métadonnées de la classe `Queue<T>`.

3. **Invocation de méthode** : Le CLR invoque ensuite l'implémentation de la méthode `Enqueue` qui correspond à la classe `Queue<T>`, en passant la chaîne `"Client2"` en tant qu'argument.

4. **Exécution de Enqueue** : À l'intérieur de l'implémentation de la méthode `Enqueue`, la .NET Framework ajoute la chaîne `"Client2"` à la file d'attente, en effectuant les opérations nécessaires comme le redimensionnement du tableau interne si nécessaire.

En résumé, l'implémentation de la .NET Framework est appelée via un mécanisme d'invocation de méthode fourni par le CLR. Le CLR gère les détails de localisation et d'exécution de l'implémentation de méthode appropriée au moment de l'exécution.

### Separation
La séparation à laquelle vous faites référence est probablement due à la manière dont le runtime .NET Core est distribué et à la manière dont les IDE interagissent avec lui.

Lorsque vous écrivez du code dans un IDE comme Visual Studio ou Visual Studio Code, l'IDE fournit des fonctionnalités d'IntelliSense et de complétion de code en fonction des métadonnées disponibles et de la documentation pour les assemblies .NET Core référencés dans votre projet.

Dans le cas de .NET Core, le runtime et les bibliothèques de classes de base sont distribués sous forme de packages NuGet. Les IDE utilisent généralement ces packages pour fournir IntelliSense et d'autres fonctionnalités. Cependant, le code source complet de .NET Core peut ne pas être inclus directement dans votre projet ou visible dans l'IDE.

Ainsi, bien que vous ne voyiez peut-être que les signatures de méthodes comme `public void Enqueue(T item);` dans l'IDE, l'implémentation réelle de ces méthodes existe dans le runtime .NET Core et les bibliothèques de classes de base. Vous pouvez vous référer au code source de ces bibliothèques séparément, comme fourni dans le lien que vous avez mentionné précédemment, pour voir les détails complets de l'implémentation.

La séparation de la distribution du runtime et des bibliothèques par rapport à l'environnement de développement permet de maintenir des installations d'IDE légères et de réduire le désordre. Les développeurs peuvent toujours accéder au code source complet et à la documentation au besoin, que ce soit via des référentiels en ligne, des sites de documentation ou en parcourant directement le code source.