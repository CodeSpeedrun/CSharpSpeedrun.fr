## Le mot-clé "as"
En C#, le mot-clé "as" permet de déterminer dynamiquement à l'exécution si un type donné est compatible avec un autre. Lorsque vous utilisez le mot-clé "as", vous pouvez vérifier la compatibilité en vérifiant une valeur de retour nulle.

```csharp
// Utilisation de "as" pour tester la compatibilité.
object[] items = new object[4]; 
items[0] = new CustomShape(); 
items[1] = false;
items[2] = new DepartmentHead(); 
items[3] = "Dernier élément";
foreach (object obj in items) 
{
    CustomShape shape = obj as CustomShape; 
    if (shape == null)
    {
        Console.WriteLine("L'élément n'est pas une forme personnalisée"); 
    }
    else
    {
        shape.Draw(); 
    }
}
```

### Compatibilité des types en C# avec le mot-clé "as"

En C#, le mot-clé `as` permet de réaliser une vérification dynamique du type à l'exécution pour déterminer si un objet donné est compatible avec un type spécifique. Si l'objet est compatible, le mot-clé `as` effectue une conversion vers ce type; sinon, il renvoie `null`. Ceci est particulièrement utile lors du traitement de collections de types mixtes où vous souhaitez opérer sélectivement sur des objets d'un type spécifique.

#### Syntaxe
```csharp
object result = obj as TypeCible;
```

- `obj` : L'objet à vérifier la compatibilité.
- `TypeCible` : Le type avec lequel vérifier la compatibilité.

#### Exemple d'utilisation

```csharp
CustomShape shape = obj as CustomShape;
```

Dans cet exemple :
- `obj` est l'objet en cours de vérification.
- `CustomShape` est le type cible pour lequel la compatibilité est vérifiée.
- Si `obj` est compatible avec `CustomShape`, `shape` fera référence à cet objet ; sinon, `shape` sera `null`.

#### Cas d'utilisation
- Vérification de compatibilité avant de procéder à une conversion pour éviter des erreurs à l'exécution.
- Travailler avec des collections hétérogènes d'objets.

#### Limitations
- Le mot-clé `as` fonctionne uniquement avec les types de référence et les types nullable ; il ne peut pas être utilisé avec les types valeur.
- Il est généralement moins performant que la conversion directe (`(CustomShape)obj`) mais plus sûr lorsque la compatibilité est incertaine.