# L'utilisation de code non sécurisé en C#

Dans le développement de projets .NET Core, il est peu probable que vous utilisiez fréquemment l'une des fonctionnalités les moins utilisées de C#.

Le plateforme .NET Core définit deux grandes catégories de données : les types de valeurs et les types de références. En vérité, cependant, il existe une troisième catégorie : les types de pointeurs.

* L'opérateur '*' est utilisé pour créer une variable de pointeur (c'est-à-dire une variable qui représente un emplacement direct en mémoire). Comme en C++, le même opérateur est utilisé pour l'indirection de pointeur.
* L'opérateur '&' est utilisé pour obtenir l'adresse d'une variable en mémoire.

Lorsque vous cherchez à optimiser certaines parties de votre application en manipulant directement la mémoire en dehors de la gestion de l'exécution .NET 5 :
- Vous appelez des méthodes d'une .dll basée sur C ou d'un serveur COM qui demandent des types de pointeurs en tant que paramètres. Même dans ce cas, vous pouvez souvent contourner les types de pointeurs en faveur du type System.IntPtr et des membres du type System.Runtime.InteropServices.Marshal.

Vous devez informer le compilateur C# de vos intentions en autorisant votre projet à prendre en charge le "code non sécurisé".

```csharp
using CodeNonSecurise;
Console.WriteLine("***** Appel de méthode avec code non sécurisé *****");
unsafe
{
    // Travaillez avec les types de pointeurs ici !
}
// Impossible de travailler avec des pointeurs ici !
```

## Exemples d'utilisation de code non sécurisé en C#

### Exemple 1 : Manipulation directe de la mémoire
```csharp
unsafe
{
    int* pointeurEntier; // Déclaration d'un pointeur sur un entier
    int entier = 10;
    pointeurEntier = &entier; // Obtention de l'adresse de la variable 'entier'

    Console.WriteLine($"Valeur de l'entier : {entier}");
    Console.WriteLine($"Adresse de l'entier : {(int)pointeurEntier}");
}
```

Dans cet exemple, nous déclarons un pointeur sur un entier (`int* pointeurEntier`). Ensuite, nous obtenons l'adresse de la variable `entier` en utilisant l'opérateur `&`. Nous affichons ensuite la valeur de l'entier et l'adresse de l'entier en mémoire.

### Exemple 2 : Utilisation du type System.IntPtr
```csharp
using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Exemple d'utilisation de System.IntPtr
        IntPtr adresse = Marshal.AllocHGlobal(100); // Allocation d'un bloc de mémoire non managée de 100 octets
        Console.WriteLine($"Adresse allouée : {adresse}");

        // Libération de la mémoire allouée
        Marshal.FreeHGlobal(adresse);
    }
}
```

Dans cet exemple, nous utilisons `System.IntPtr` pour manipuler des adresses mémoire. Nous allouons un bloc de mémoire non managée à l'aide de `Marshal.AllocHGlobal()` et libérons cette mémoire avec `Marshal.FreeHGlobal()`.

### Exemple 3 : Appel de méthodes non sécurisées
```csharp
using System;
using System.Runtime.InteropServices;

class Program
{
    // Import d'une méthode non sécurisée d'une DLL
    [DllImport("user32.dll")]
    static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

    static void Main(string[] args)
    {
        // Appel de la méthode MessageBox
        MessageBox(IntPtr.Zero, "Hello World!", "Message", 0);
    }
}
```

Dans cet exemple, nous importons et appelons une méthode non sécurisée de la DLL `user32.dll`, utilisant `DllImport` pour indiquer au runtime comment interagir avec la méthode native.

