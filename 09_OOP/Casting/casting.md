# Conversion entre les types de classes liés

Le processus de conversion en C# vous permet de convertir vers le haut et vers le bas dans la hiérarchie de classes. Par exemple, une classe dérivée peut toujours être implicitement convertie en un type de base. Cependant, si vous souhaitez stocker un type de classe de base dans une variable dérivée, vous devez effectuer une conversion explicite.

## Exemple 1 : Conversion implicite et explicite entre types de classes liés

Considérons deux types de classes liés :

```csharp
class Base {}
class Derived : Base {}
```

Dans cet exemple, nous avons une classe de base `Base` et une classe dérivée `Derived`.

```csharp
Base maVariableBase;
maVariableBase = new Derived();
```

Ici, la classe dérivée `Derived` est implicitement convertie en un type de base `Base`.

```csharp
Derived maVariableDerivee = (Derived)maVariableBase;
```

Cependant, pour stocker une référence de type de base dans une variable de type dérivé, une conversion explicite est nécessaire.

## Exemple 2 : Utilisation du mot-clé 'as'

Si vous n'êtes pas certain que la conversion réussira, vous devriez utiliser le mot-clé 'as'.

```csharp
Base maVariableBase2 = new Derived();
```

Dans cet exemple, nous essayons de convertir un type de base en un type dérivé à l'aide du mot-clé 'as'. Si la conversion échoue, la variable résultante sera null.

```csharp
Derived maVariableDerivee2 = maVariableBase2 as Derived;
```

## Exemple 3 : Conversion de types de classes non liés

Dans certains cas, il peut être tentant de convertir des types de classes non liés, mais cela peut provoquer des erreurs ou des comportements imprévus.

Considérons un exemple où nous essayons de convertir un Rectangle en un Carré.

```csharp
class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
}

class Square
{
    public int SideLength { get; set; }
}
```

```csharp
Rectangle rect = new Rectangle
{
    Width = 3,
    Height = 10
};

Square sq = (Square)rect;
```

Dans cet exemple, nous essayons de convertir un Rectangle en un Carré, ce qui n'est pas une conversion valide car les propriétés et les comportements des deux classes sont différents.

```
C# Compiler Error CS0029
Cannot implicitly convert type 'Rectangle' to 'Square'
```

Il est important de noter que les conversions entre des types de classes non liés peuvent nécessiter une logique de conversion personnalisée.
