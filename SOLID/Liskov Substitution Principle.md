# Principe de Substitution de Liskov en C#

Le **Principe de Substitution de Liskov** (PSL) est un concept fondamental de la programmation orientée objet visant à assurer que les sous-classes peuvent être utilisées de manière interchangeable avec leur classe parente sans altérer le comportement du programme. En d'autres termes, toute instance de sous-classe doit pouvoir remplacer une instance de la classe parente sans causer de problèmes.

## Compréhension du Principe de Substitution de Liskov

Le PSL, proposé par Barbara Liskov en 1987, est l'un des cinq principes SOLID de la programmation orientée objet. Il stipule que les sous-classes doivent respecter le contrat de la classe parente, notamment en conservant les préconditions, postconditions et invariants.

### Exemple de Principe de Substitution de Liskov

Considérons un exemple de géométrie avec une classe parente `Forme` et deux sous-classes `Carré` et `Triangle`. La classe `Forme` contient une méthode `CalculerAire()` pour calculer l'aire de la forme.

```csharp
using System;

public abstract class Forme
{
    public abstract double CalculerAire();
}

public class Carré : Forme
{
    private double côté;

    public double Côté
    {
        get => côté;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("La longueur du côté doit être positive et non nulle.");
            }

            côté = value;
        }
    }

    public override double CalculerAire()
    {
        return Côté * Côté;
    }
}


public class Triangle : Forme
{
    public double Base { get; set; }
    public double Hauteur { get; set; }

    public override double CalculerAire()
    {
        return (Base * Hauteur) / 2;
    }
}

class Program
{
    static void AfficherAire(Forme forme)
    {
        try
        {
            Console.WriteLine($"L'aire de la forme est : {forme.CalculerAire()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erreur : {ex.Message}");
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Carré carré = new Carré { Côté = 5 };
            Triangle triangle = new Triangle { Base = 4, Hauteur = 3 };

            AfficherAire(carré);
            AfficherAire(triangle);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erreur : {ex.Message}");
        }
    }
}


```

Dans cet exemple, les classes `Carré` et `Triangle` héritent de `Forme` et implémentent la méthode `CalculerAire()` pour leurs propres calculs. Ainsi, on peut utiliser des instances de `Carré` ou `Triangle` là où une instance de `Forme` est attendue, respectant ainsi le principe de substitution de Liskov.

### Respect du Principe de Substitution de Liskov

Pour garantir le respect du PSL, les sous-classes doivent maintenir les contrats de la classe parente :

1. **Signature des méthodes** : Les méthodes des sous-classes doivent avoir la même signature que celles de la classe parente.
2. **Préconditions** : Les préconditions des méthodes des sous-classes ne doivent pas être plus strictes que celles de la classe parente.
3. **Postconditions** : Les postconditions des méthodes des sous-classes ne doivent pas être moins strictes que celles de la classe parente.
4. **Invariants** : Les invariants de la classe parente doivent être conservés par les sous-classes.

En respectant ces principes, les sous-classes peuvent être utilisées en toute sécurité dans le code existant sans causer de comportement inattendu.

## Avantages du Principe de Substitution de Liskov

Le respect du PSL apporte plusieurs avantages :

- **Réutilisabilité du code** : Les sous-classes peuvent être réutilisées dans différents contextes sans nécessiter de modifications supplémentaires.
- **Facilité de maintenance** : En respectant les contrats de la classe parente, la maintenance du code est simplifiée.
- **Robustesse du code** : Les comportements inattendus sont évités, ce qui renforce la robustesse du code.

En conclusion, le Principe de Substitution de Liskov est essentiel pour garantir la modularité, la réutilisabilité et la robustesse du code en programmation orientée objet. En respectant ce principe, on s'assure que les sous-classes peuvent être utilisées en toute sécurité dans n'importe quel contexte sans causer de problèmes.