# Types Nullable en C#

Les types nullable en C# permettent l'assignation de `null` à des variables de type valeur. Cela est particulièrement utile lorsqu'il s'agit de scénarios où une variable peut avoir ou non une valeur, comme lors de l'interaction avec des bases de données où les colonnes peuvent être non définies ou facultatives.

## Syntaxe

```csharp
Nullable<int> highScore = null;
int? highScore = null;
```

Ici, `highScore` est une variable entière nullable qui peut contenir soit une valeur entière, soit `null`.

```csharp
bool? myBool = null;
```

Dans cet exemple, `myBool` est une variable booléenne nullable, ce qui signifie qu'elle peut être affectée à `true`, `false` ou `null`.

## Avantages et Utilisation

- **Interactions avec les Bases de Données**: Les types nullable sont particulièrement utiles lors de l'interaction avec des bases de données relationnelles où les colonnes peuvent avoir des valeurs manquantes ou facultatives.
  
- **Représentation de Valeurs Indéfinies**: Ils offrent un moyen pratique de représenter un point de données sans valeur, ce qui est courant dans les scénarios de base de données.

- **Types de Référence Nullables**: En plus des types de valeur nullable, C# prend également en charge les types de référence nullable, qui peuvent être activés en définissant le contexte nullable dans le fichier du projet.

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net5.0</TargetFramework>
    <Nullable>enable</Nullable>
  </PropertyGroup>
</Project>
```

En ajoutant le nœud `<Nullable>enable</Nullable>` dans le fichier du projet, les types de référence nullable sont activés pour le projet.

## Opérateur de Coalescence Null

L'opérateur de coalescence null (`??`) fournit un moyen concis de gérer les valeurs null, surtout lorsqu'il s'agit de types nullable.

```csharp
int? moreData = dr.GetIntFromDatabase();
if (!moreData.HasValue)
{
    moreData = 100;
}
```

Cela équivaut à :

```csharp
int? moreData = dr.GetIntFromDatabase() ?? 100;
```

Ici, si `dr.GetIntFromDatabase()` renvoie null, `moreData` se verra attribuer une valeur de `100`.

## Opérateur d'Assignation de Coalescence Null

C# 8.0 a introduit l'opérateur d'assignation de coalescence null (`??=`), qui affecte la valeur de son opérande de droite à son opérande de gauche uniquement si l'opérande de gauche évalue à `null`.

```csharp
int? nullableInt = null;
nullableInt ??= 12;
```

Dans cet exemple, `nullableInt` se verra attribuer une valeur de `12` uniquement s'il est `null`.

## Opérateur de Navigation Sûre

L'opérateur de navigation sûre (`?.`) est utilisé pour accéder de manière sécurisée aux membres d'un objet sans provoquer d'exception de référence null. Il est souvent utilisé en conjonction avec l'opérateur de coalescence null pour gérer les valeurs null.

```csharp
Console.WriteLine($"Vous m'avez envoyé {args?.Length ?? 0} arguments.");
```

Dans ce code, si `args` est `null`, l'expression s'évalue à `0`. Sinon, elle renvoie la longueur du tableau `args`. Cela empêche l'occurrence d'une exception de référence null.