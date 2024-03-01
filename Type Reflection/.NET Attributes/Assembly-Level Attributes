# Les attributs au niveau de l'assemblage

Les attributs au niveau de l'assemblage fournissent des métadonnées cruciales sur une assembly C#. Ces métadonnées peuvent contrôler divers aspects du comportement de l'assembly, y compris sa conformité à des normes spécifiques telles que la CLS (Common Language Specification).

## Utilisation des attributs au niveau de l'assemblage

Dans le code C#, il est conseillé de déclarer en premier lieu les directives "using" pour spécifier les espaces de noms utilisés. Ensuite, les attributs au niveau de l'assemblage sont définis en utilisant le préfixe `[assembly:]`. Par exemple :

```csharp
using System;

[assembly: CLSCompliant(true)]
```

Dans cet exemple, l'attribut `CLSCompliant` est utilisé pour indiquer que toutes les classes publiques de cette assembly sont conformes à la spécification CLS.

## Imposer la conformité CLS

La spécification CLS (Common Language Specification) définit un ensemble de règles auxquelles toutes les langues .NET doivent se conformer pour garantir une interopérabilité maximale entre les langues. En marquant une assembly comme conforme à la CLS, vous vous assurez que toutes les classes publiques de cette assembly suivent ces règles.

Si une classe ou une méthode contient du code non conforme à la CLS, le compilateur émettra un avertissement pour signaler ce non-conformité. Par exemple, si une méthode expose des types de données non signés, cela peut entraîner un avertissement du compilateur.

## Exemple de non-conformité CLS

Considérons un exemple où une méthode expose un type de données non signé, ce qui est contraire à la spécification CLS :

```csharp
public class ExempleNonConformeCLS
{
    // Méthode non conforme à la CLS car elle expose un type de données non signé.
    public uint MethodeNonConformeCLS()
    {
        return 100u;
    }
}
```

Dans cet exemple, la méthode `MethodeNonConformeCLS` renvoie un entier non signé (`uint`), ce qui n'est pas conforme à la CLS. Lorsque cette méthode est compilée dans une assembly marquée comme conforme à la CLS, le compilateur émettra un avertissement pour signaler cette non-conformité.

## Conclusion

Les attributs au niveau de l'assemblage, tels que `CLSCompliant`, sont des outils puissants pour contrôler le comportement et la conformité d'une assembly C#. En marquant correctement une assembly comme conforme à la CLS, vous pouvez garantir une interopérabilité maximale avec d'autres langues .NET.