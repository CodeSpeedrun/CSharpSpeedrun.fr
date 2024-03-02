# Types Dynamiques et le Runtime Dynamique du Langage en C#

Les types dynamiques en C# permettent d'intégrer des comportements semblables à du scripting dans le monde fortement typé de la sécurité des types, des points-virgules et des accolades. Cette flexibilité facilite grandement certaines tâches de codage complexes et offre la possibilité d'interopérer avec plusieurs langages dynamiques compatibles avec .NET Core.

## Introduction aux Types Dynamiques

Le mot-clé `dynamic` en C# permet de définir des types dynamiques. Contrairement aux types statiques, les types dynamiques autorisent un typage plus souple, où les appels sont associés à l'objet en mémoire correct via le Runtime Dynamique du Langage (DLR). Il est important de ne pas confondre le mot-clé `dynamic` avec le concept d'assemblage dynamique.

## Avantages des Types Dynamiques

L'inférence de type implicite est particulièrement utile, notamment avec LINQ, où de nombreuses requêtes LINQ retournent des énumérations de classes anonymes (via des projections) qui ne peuvent pas être déclarées directement dans le code C#.

## Utilisation des Types Dynamiques

D'un point de vue élevé, le mot-clé `dynamic` peut être considéré comme une forme spécialisée de `System.Object`, dans la mesure où n'importe quelle valeur peut lui être assignée.

## Exemples de Codes

### Affichage de Trois Chaînes de Caractères

```csharp
static void AfficherTroisChaines()
{
    var chaine1 = "Bonjour";
    object chaine2 = "de la part de";
    dynamic chaine3 = "Montréal";
    
    Console.WriteLine("chaine1 est de type : {0}", chaine1.GetType());
    Console.WriteLine("chaine2 est de type : {0}", chaine2.GetType());
    Console.WriteLine("chaine3 est de type : {0}", chaine3.GetType());
}
```

Dans cet exemple, nous avons trois variables `chaine1`, `chaine2`, et `chaine3`. Les deux premières sont typées de manière implicite (`var` et `object`), tandis que la troisième est typée dynamiquement avec `dynamic`. Cependant, lors de l'exécution, toutes les variables contiennent des chaînes de caractères et sont de type `System.String`.

### Changement du Type Dynamique

```csharp
static void ChangerTypeDynamique()
{
    // Déclarer un point de données dynamique nommé "variable".
    dynamic variable = "Bonjour !";
    Console.WriteLine("La variable est de type : {0}", variable.GetType());
    
    variable = false;
    Console.WriteLine("La variable est de type : {0}", variable.GetType());
    
    variable = new List<string>();
    Console.WriteLine("La variable est de type : {0}", variable.GetType());
}
```

Dans cet exemple, nous avons une variable dynamique `variable` qui est d'abord initialisée avec une chaîne de caractères, puis avec un booléen, et enfin avec une liste de chaînes de caractères. À chaque réaffectation, le type de la variable change dynamiquement pour correspondre au type de la nouvelle valeur assignée.

```
La variable est de type : System.String
La variable est de type : System.Boolean
La variable est de type : System.Collections.Generic.List`1[System.String]
```

## Conclusion

Les types dynamiques offrent une flexibilité supplémentaire dans la programmation en C#, facilitant l'interopérabilité avec des langages dynamiques et simplifiant certains scénarios de développement.