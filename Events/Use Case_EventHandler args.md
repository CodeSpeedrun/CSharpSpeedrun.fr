Voici un exemple simple d'utilisation de la Programmation Orientée Événements avec `EventHandler<T>` dans un cas d'utilisation de développement de jeu :

```csharp
using System;

// Définition d'un événement pour signaler l'événement de fin de niveau
public class FinNiveauEventArgs : EventArgs
{
    public int Niveau { get; set; }
}

// Classe représentant le niveau du jeu
public class Niveau
{
    // Événement déclenché lors de la fin du niveau
    public event EventHandler<FinNiveauEventArgs> OnFinNiveau;

    // Méthode pour simuler la fin du niveau
    public void TerminerNiveau(int numéroNiveau)
    {
        Console.WriteLine($"Niveau {numéroNiveau} terminé !");
        
        // Déclenchement de l'événement de fin de niveau avec le numéro de niveau
        OnFinNiveau?.Invoke(this, new FinNiveauEventArgs { Niveau = numéroNiveau });
    }
}

// Classe principale du jeu
public class Jeu
{
    // Méthode pour gérer la fin du niveau
    public void GérerFinNiveau(object sender, FinNiveauEventArgs e)
    {
        Console.WriteLine($"Félicitations ! Niveau {e.Niveau} terminé !");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Création d'une instance de niveau et du gestionnaire de jeu
        Niveau niveau = new Niveau();
        Jeu jeu = new Jeu();

        // Association de la méthode de rappel à l'événement de fin de niveau
        niveau.OnFinNiveau += jeu.GérerFinNiveau;

        // Simuler la fin du niveau
        niveau.TerminerNiveau(1);
    }
}

/* 
Niveau 1 terminé !
Félicitations ! Niveau 1 terminé !
*/
```

Dans cet exemple, la classe `Niveau` représente un niveau dans un jeu. Lorsque le niveau est terminé, la méthode `TerminerNiveau` est appelée pour déclencher l'événement `OnFinNiveau`, qui est associé à un objet `FinNiveauEventArgs` contenant le numéro du niveau.

La classe `Jeu` agit comme un gestionnaire d'événements et contient une méthode `GérerFinNiveau` qui est appelée lorsque l'événement de fin de niveau est déclenché. Cette méthode affiche un message de félicitations pour indiquer que le niveau a été terminé avec succès.

En associant la méthode `GérerFinNiveau` à l'événement `OnFinNiveau`, le jeu peut réagir de manière appropriée à la fin de chaque niveau sans avoir à surveiller activement l'état du niveau.


## Explication détaillée
 
```csharp
using System;
```

- `using System;` : Cette ligne permet d'importer l'espace de noms (namespace) `System`, qui contient les fonctionnalités de base fournies par le framework .NET.

```csharp
// Définition d'un événement pour signaler l'événement de fin de niveau
```

- `//` : Ce symbole indique un commentaire en C#. Les commentaires sont des annotations dans le code qui sont ignorées lors de l'exécution. Ils servent à expliquer le code.
- `Définition d'un événement pour signaler l'événement de fin de niveau` : Ceci est un commentaire explicatif qui décrit l'intention de la ligne suivante de définir un événement pour signaler la fin d'un niveau dans un jeu.

```csharp
public class FinNiveauEventArgs : EventArgs
```

- `public class FinNiveauEventArgs : EventArgs` : Cela définit une nouvelle classe appelée `FinNiveauEventArgs` qui hérite de la classe `EventArgs`. Cette classe est utilisée pour transporter des données lorsqu'un événement est déclenché.

```csharp
public int Niveau { get; set; }
```

- `public int Niveau { get; set; }` : Cela définit une propriété publique appelée `Niveau` dans la classe `FinNiveauEventArgs`. Cette propriété permet de récupérer ou définir le numéro du niveau.

```csharp
// Classe représentant le niveau du jeu
public class Niveau
```

- `// Classe représentant le niveau du jeu` : C'est un commentaire qui décrit l'intention de la classe suivante de représenter un niveau dans un jeu.

```csharp
{
    // Événement déclenché lors de la fin du niveau
    public event EventHandler<FinNiveauEventArgs> OnFinNiveau;
```

- `{` : Cela marque le début du contenu de la classe `Niveau`.
- `// Événement déclenché lors de la fin du niveau` : Ceci est un commentaire expliquant que la ligne suivante définit un événement appelé `OnFinNiveau` qui est déclenché lorsque le niveau se termine. Cet événement utilise le délégué générique `EventHandler<T>` où `T` est le type de données que l'événement transporte, dans ce cas `FinNiveauEventArgs`.

```csharp
    // Méthode pour simuler la fin du niveau
    public void TerminerNiveau(int numéroNiveau)
```

- `// Méthode pour simuler la fin du niveau` : Ceci est un commentaire qui décrit l'intention de la méthode suivante de simuler la fin d'un niveau.
- `public void TerminerNiveau(int numéroNiveau)` : Cela définit une méthode publique appelée `TerminerNiveau` qui prend un entier `numéroNiveau` en paramètre. Cette méthode est utilisée pour simuler la fin d'un niveau dans le jeu.

```csharp
    {
        Console.WriteLine($"Niveau {numéroNiveau} terminé !");
```

- `{` : Cela marque le début du contenu de la méthode `TerminerNiveau`.
- `Console.WriteLine($"Niveau {numéroNiveau} terminé !");` : Cette ligne affiche un message à la console indiquant que le niveau avec le numéro spécifié est terminé. Le `$` permet d'insérer une variable (`numéroNiveau`) directement dans la chaîne de caractères.

```csharp
        // Déclenchement de l'événement de fin de niveau avec le numéro de niveau
        OnFinNiveau?.Invoke(this, new FinNiveauEventArgs { Niveau = numéroNiveau });
    }
```

- `// Déclenchement de l'événement de fin de niveau avec le numéro de niveau` : Ceci est un commentaire qui explique que la ligne suivante déclenche l'événement `OnFinNiveau` avec le numéro de niveau.
- `OnFinNiveau?.Invoke(this, new FinNiveauEventArgs { Niveau = numéroNiveau });` : Cette ligne déclenche l'événement `OnFinNiveau`, en passant l'instance actuelle de la classe `Niveau` (via `this`) et un nouvel objet `FinNiveauEventArgs` contenant le numéro de niveau, à tous les gestionnaires d'événements abonnés à cet événement.

```csharp
// Classe principale du jeu
public class Jeu
```

- `// Classe principale du jeu` : Ceci est un commentaire qui décrit l'intention de la classe suivante de représenter la classe principale du jeu.

```csharp
{
    // Méthode pour gérer la fin du niveau
    public void GérerFinNiveau(object sender, FinNiveauEventArgs e)
```

- `{` : Cela marque le début du contenu de la classe `Jeu`.
- `// Méthode pour gérer la fin du niveau` : Ceci est un commentaire qui décrit l'intention de la méthode suivante de gérer la fin d'un niveau.
- `public void GérerFinNiveau(object sender, FinNiveauEventArgs e)` : Cela définit une méthode publique appelée `GérerFinNiveau` qui prend deux paramètres : `sender`, qui est l'objet qui a déclenché l'événement (dans ce cas, une instance de `Niveau`), et `e`, qui est un objet `FinNiveauEventArgs` contenant des informations sur la fin du niveau.

```csharp
    {
        Console.WriteLine($"Félicitations ! Niveau {e.Niveau} terminé !");
    }
```

- `{` : Cela marque le début du contenu de la méthode `GérerFinNiveau`.
- `Console.WriteLine($"Félicitations ! Niveau {e.Niveau} terminé !");` : Cette ligne affiche un message à la console pour féliciter le joueur pour avoir terminé le niveau avec le numéro spécifié (`e.Niveau`).

```csharp
public class Program
```

- `public class Program` : Cela définit une classe publique appelée `Program`. La classe `Program` est souvent utilisée comme point d'entrée pour les applications console en C#.

```csharp
{
    public static void Main(string[] args)
```

- `{` : Cela marque le début du contenu de la méthode `Main`.
- `public static void Main(string[] args)` : Cela définit la méthode `Main`, qui est le point d'entrée de l'application. La méthode `Main` est exécutée en premier lorsque le programme est lancé. Elle prend un tableau de chaînes `args` en paramètre, qui

 contient les arguments passés à l'application lors de son démarrage.

```csharp
    {
        // Création d'une instance de niveau et du gestionnaire de jeu
        Niveau niveau = new Niveau();
        Jeu jeu = new Jeu();
```

- `{` : Cela marque le début du contenu de la méthode `Main`.
- `Niveau niveau = new Niveau();` : Cette ligne crée une nouvelle instance de la classe `Niveau`, qui représente un niveau dans le jeu.
- `Jeu jeu = new Jeu();` : Cette ligne crée une nouvelle instance de la classe `Jeu`, qui représente le gestionnaire principal du jeu.

```csharp
        // Association de la méthode de rappel à l'événement de fin de niveau
        niveau.OnFinNiveau += jeu.GérerFinNiveau;
```


- `niveau.OnFinNiveau += jeu.GérerFinNiveau;` : Cette ligne associe la méthode `GérerFinNiveau` de l'instance `jeu` à l'événement `OnFinNiveau` de l'instance `niveau`. Cela signifie que lorsque l'événement `OnFinNiveau` est déclenché dans l'instance `niveau`, la méthode `GérerFinNiveau` de l'instance `jeu` sera appelée pour gérer l'événement.

```csharp
        // Simuler la fin du niveau
        niveau.TerminerNiveau(1);
```

- `// Simuler la fin du niveau` : Ceci est un commentaire qui décrit l'intention de la ligne suivante de simuler la fin du premier niveau.
- `niveau.TerminerNiveau(1);` : Cette ligne appelle la méthode `TerminerNiveau` de l'instance `niveau` pour simuler la fin du premier niveau dans le jeu.

### Séparer les responsabilités
Dans la conception logicielle, il est généralement recommandé de séparer les responsabilités en différentes classes pour améliorer la lisibilité, la maintenabilité et la réutilisabilité du code. Cela est particulièrement vrai dans le contexte de la programmation orientée objet, où chaque classe devrait avoir une seule responsabilité claire et distincte.

Dans notre exemple :

- La classe `Niveau` est responsable de représenter un niveau dans le jeu, ainsi que de définir le comportement associé à ce niveau, tel que la simulation de la fin du niveau.
- La classe `Jeu` est responsable de gérer la logique globale du jeu, telle que la réaction aux événements qui se produisent pendant le jeu.

En séparant ces responsabilités en deux classes distinctes, nous obtenons un code plus modulaire et évolutif. Par exemple, si nous voulions ajouter de nouveaux niveaux ou modifier le comportement de chaque niveau, nous pourrions le faire dans la classe `Niveau` sans affecter la logique globale du jeu dans la classe `Jeu`.

De plus, séparer les responsabilités permet également de faciliter les tests unitaires, car chaque classe peut être testée indépendamment des autres.

Cependant, dans certains cas simples où la logique du jeu est très rudimentaire et où la séparation en classes distinctes peut sembler excessive, il pourrait être acceptable de combiner les responsabilités en une seule classe. Cependant, il est important de garder à l'esprit les principes de conception logicielle et de choisir la structure qui convient le mieux à votre application.

## Sans commentaires

```csharp
using System;

public class FinNiveauEventArgs : EventArgs {
    public int Niveau { get; set; }
}

public class Niveau {
    public event EventHandler<FinNiveauEventArgs> OnFinNiveau;

    public void TerminerNiveau(int numéroNiveau) {
        Console.WriteLine($"Niveau {numéroNiveau} terminé !");

        OnFinNiveau?.Invoke(this, new FinNiveauEventArgs { Niveau = numéroNiveau });
    }
}

public class Jeu {
    public void GérerFinNiveau(object sender, FinNiveauEventArgs e) {
        Console.WriteLine($"Félicitations ! Niveau {e.Niveau} terminé !");
    }
}

public class Program {
    public static void Main(string[] args) {
        Niveau niveau = new Niveau();
        Jeu jeu = new Jeu();

        niveau.OnFinNiveau += jeu.GérerFinNiveau;
        niveau.TerminerNiveau(1);
    }
}
```

Type `int`
```csharp
using System;

public class Niveau {
    public event EventHandler<int> OnFinNiveau;

    public void TerminerNiveau(int numéroNiveau) {
        Console.WriteLine($"Niveau {numéroNiveau} terminé !");

        OnFinNiveau?.Invoke(this, numéroNiveau);
    }
}

public class Jeu {
    public void GérerFinNiveau(object sender, int numéroNiveau) {
        Console.WriteLine($"Félicitations ! Niveau {numéroNiveau} terminé !");
    }
}

public class Program {
    public static void Main(string[] args) {
        Niveau niveau = new Niveau();
        Jeu jeu = new Jeu();

        niveau.OnFinNiveau += jeu.GérerFinNiveau;
        niveau.TerminerNiveau(1);
    }
}
```

Pas de type
```csharp
using System;

public class Niveau {
    public event EventHandler OnFinNiveau;

    public void TerminerNiveau(int numéroNiveau) {
        Console.WriteLine($"Niveau {numéroNiveau} terminé !");
        OnFinNiveau?.Invoke(this, EventArgs.Empty);
    }
}

public class Jeu {
    public void GérerFinNiveau(object sender, EventArgs e) {
        if (sender is Niveau niveau) {
            Console.WriteLine($"Félicitations ! Niveau {niveau} terminé !");
        }
    }
}

public class Program {
    public static void Main(string[] args) {
        Niveau niveau = new Niveau();
        Jeu jeu = new Jeu();

        niveau.OnFinNiveau += jeu.GérerFinNiveau;
        niveau.TerminerNiveau(1);
    }
}
```

Lambda Expression
```csharp
using System;

public class Niveau {
    public event EventHandler OnFinNiveau;

    public void TerminerNiveau(int numéroNiveau) {
        Console.WriteLine($"Niveau {numéroNiveau} terminé !");
        OnFinNiveau?.Invoke(this, EventArgs.Empty);
    }
}

public class Program {
    public static void Main(string[] args) {
        Niveau niveau = new Niveau();

        niveau.OnFinNiveau += (sender, e) => {
            if (sender is Niveau n) {
                Console.WriteLine($"Félicitations ! Niveau {n} terminé !");
            }
        };

        niveau.TerminerNiveau(1);
    }
}
```
### Les différences
Voici toutes les différences et les changements dans le code pour les différentes déclarations d'événements :

1. Déclaration d'événement sans type spécifique :
```csharp
public event EventHandler OnFinNiveau;
```
Dans cette déclaration, aucun argument spécifique n'est passé lors de l'invocation de l'événement `OnFinNiveau`.

2. Déclaration d'événement avec un argument de type `int` :
```csharp
public event EventHandler<int> OnFinNiveau;
```
Dans cette déclaration, un entier est passé en tant qu'argument lors de l'invocation de l'événement `OnFinNiveau`.

3. Déclaration d'événement avec un argument de type `FinNiveauEventArgs` :
```csharp
public event EventHandler<FinNiveauEventArgs> OnFinNiveau;
```
Dans cette déclaration, un objet de type `FinNiveauEventArgs` est passé en tant qu'argument lors de l'invocation de l'événement `OnFinNiveau`.

En plus de ces déclarations d'événements, d'autres changements sont nécessaires dans le code pour prendre en compte ces différences. Voici les autres changements possibles :

- Dans la méthode `TerminerNiveau` de la classe `Niveau`, l'objet événement doit être instancié en conséquence :
```csharp
// Pour la déclaration d'événement sans type spécifique
OnFinNiveau?.Invoke(this, EventArgs.Empty);

// Pour la déclaration d'événement avec un argument de type `int`
OnFinNiveau?.Invoke(this, numéroNiveau);

// Pour la déclaration d'événement avec un argument de type `FinNiveauEventArgs`
OnFinNiveau?.Invoke(this, new FinNiveauEventArgs { Niveau = numéroNiveau });
```

- Dans la méthode `GérerFinNiveau` de la classe `Jeu`, la signature et l'utilisation des arguments doivent être adaptées en fonction du type d'argument de l'événement :
```csharp
// Pour la déclaration d'événement sans type spécifique
public void GérerFinNiveau(object sender, EventArgs e) {
    Console.WriteLine("Félicitations ! Niveau terminé !");
}

// Pour la déclaration d'événement avec un argument de type `int`
public void GérerFinNiveau(object sender, int numéroNiveau) {
    Console.WriteLine($"Félicitations ! Niveau {numéroNiveau} terminé !");
}

// Pour la déclaration d'événement avec un argument de type `FinNiveauEventArgs`
public void GérerFinNiveau(object sender, FinNiveauEventArgs e) {
    Console.WriteLine($"Félicitations ! Niveau {e.Niveau} terminé !");
}
```

En prenant en compte ces changements, le code est modifié pour fonctionner correctement avec les différentes déclarations d'événements.