### Syntaxe Standard des Méthodes

```csharp
static int Add(int num1, int num2)
{
    return num1 + num2;
}
```

La méthode `Add` prend deux paramètres entiers `num1` et `num2` et retourne leur somme.

### Expression Lambda

```csharp
static int Add(int x, int y) => x + y;
```

En utilisant la syntaxe lambda `=>`, la méthode `Add` peut être réécrite de manière concise. Il s'agit d'une opération lambda, une syntaxe abrégée pour définir des fonctions.

### Fonctions Locales

Les fonctions locales permettent d'encapsuler des fonctionnalités à l'intérieur d'une méthode, offrant une meilleure lisibilité et organisation.

#### Exemple de Fonction Locale

```csharp
static int AddWrapper(int a, int b)
{
    // Effectuer la validation ici
    
    return Add();

    int Add()
    {
        return a + b;
    }
}
```

Dans cet exemple, la méthode `AddWrapper` encapsule la logique de validation et définit une fonction locale `Add` pour effectuer l'addition. Cela améliore l'organisation du code et sa lisibilité.

### Modificateurs de Paramètres de Méthode

#### Passage de Paramètres par Valeur (Défaut)

Par défaut, les paramètres sont passés à une fonction par valeur. Cela signifie que la fonction reçoit une copie de la valeur du paramètre.

```csharp
void MethodeExemple(int valeur)
{
    // Les modifications de 'valeur' n'affecteront pas l'argument original
}
```

#### Passage de Paramètres par Référence

Les paramètres peuvent également être passés par référence en utilisant le mot-clé `ref`. Cela permet à la fonction de modifier la valeur originale passée.

```csharp
void MethodeExemple(ref int valeur)
{
    valeur += 10; // Modifie la 'valeur' originale
}
```

#### Paramètres de Sortie

En utilisant le mot-clé `out`, une méthode peut retourner plusieurs valeurs via ses paramètres.

```csharp
void MethodeExemple(out int resultat)
{
    resultat = 10; // Affecte une valeur au paramètre 'resultat'
}
```

#### Paramètres Params

Le mot-clé `params` permet aux méthodes d'accepter un nombre variable de paramètres d'un type spécifié.

```csharp
void MethodeExemple(params int[] nombres)
{
    // 'nombres' peut être accédé comme un tableau d'entiers
}
```

### Conclusion

Comprendre la syntaxe des méthodes, les opérations lambda, les fonctions locales et les modificateurs de paramètres est essentiel pour une programmation efficace en C#. En maîtrisant ces concepts, les développeurs peuvent écrire un code plus propre et plus maintenable.