# Modificateurs d'accès en C#

## Introduction aux modificateurs d'accès

Les modificateurs d'accès en C# déterminent la visibilité et l'accessibilité des types, membres et types imbriqués au sein d'une application. Comprendre les modificateurs d'accès est crucial pour l'encapsulation et le contrôle de l'accessibilité de différentes parties de votre base de code.

### Modificateur d'accès public

Les types ou membres de type publics n'ont aucune restriction d'accès. Ils peuvent être accessibles depuis n'importe quelle partie de l'application, y compris les objets et les classes dérivées. Les types publics peuvent également être accessibles depuis des assemblies externes.

```csharp
public class TypePublic
{
    public int MembrePublic { get; set; }
}
```

### Modificateur d'accès privé

Les membres de type privé ou les types imbriqués ne peuvent être accédés que par la classe (ou la structure) qui les définit.

```csharp
class TypePrive
{
    private int membrePrive;
}
```

### Modificateur d'accès protégé

Les membres de type protégé ou les types imbriqués peuvent être accédés par la classe définissante et toute classe enfant. Ils ne sont pas accessibles depuis la chaîne d'héritage extérieure.

```csharp
class ClasseDeBase
{
    protected int membreProtege;
}
```

### Modificateur d'accès interne

Les types ou membres de type internes sont accessibles uniquement à l'intérieur de l'assembly actuel. D'autres assemblies peuvent se voir accorder explicitement la permission de voir les éléments internes.

```csharp
internal class TypeInterne
{
    internal int membreInterne;
}
```

### Modificateur d'accès protégé interne

Les membres de type protégé interne ou les types imbriqués sont accessibles à l'intérieur de l'assembly définissant, par la classe définissante et par les classes dérivées à la fois à l'intérieur et à l'extérieur de l'assembly définissant.

```csharp
class ClasseDeBase
{
    protected internal int membreProtegeInterne;
}
```

### Modificateur d'accès privé protégé (C# 7.2)

Les membres de type privé protégé ou les types imbriqués sont accessibles à l'intérieur de la classe définissante et par les classes dérivées dans le même assembly.

```csharp
class ClasseDeBase
{
    private protected int membrePriveProtege;
}
```

## Définitions de classe et constructeurs

Par défaut, une définition de classe est définie comme interne et le constructeur par défaut du type est défini comme privé.

```csharp
internal class Radio
{
    private Radio() {} // constructeur par défaut privé
}
```

```csharp
public class Radio
{
    public Radio() {} // constructeur par défaut public
}
```

### Remarque sur les types imbriqués

Bien qu'il soit permis d'appliquer le modificateur d'accès privé sur les types imbriqués, les types non imbriqués doivent être définis avec les modificateurs publics ou internes.

### Exemple

```csharp
public class Bibliotheque
{
    private class Livre
    {
        public int nombreDePages;
    }

    public void EmprunterLivre()
    {
        Livre miniRoman = new Livre();
        miniRoman.nombreDePages = 30000000; // Définition du nombre de pages pour un livre
    }
}
```

Dans l'exemple ci-dessus, `nombreDePages` est accessible dans la classe `Bibliotheque`, démontrant l'encapsulation et le contrôle d'accès.