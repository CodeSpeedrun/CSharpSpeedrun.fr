# Exceptions et le mot-clé `when` en C#

Les exceptions sont un aspect crucial de la programmation en C#, permettant aux développeurs de gérer élégamment les erreurs inattendues ou les conditions exceptionnelles dans leur code. Le mot-clé `when` est une fonctionnalité introduite dans C# 6.0 qui offre un moyen flexible de filtrer les exceptions, permettant un contrôle plus granulaire sur la gestion des exceptions.

## Principes de gestion des exceptions

En C#, les exceptions sont des objets qui représentent des erreurs survenant pendant l'exécution d'un programme. Lorsqu'une condition exceptionnelle se présente, le système d'exécution crée un objet d'exception et le lance. L'exécution du programme est ensuite déplacée vers le bloc `catch` le plus proche qui peut gérer le type d'exception levé.

### Syntaxe d'un bloc `try-catch`

```csharp
try
{
    // Code pouvant générer une exception
}
catch (TypeException1 ex)
{
    // Gérer TypeException1
}
catch (TypeException2 ex)
{
    // Gérer TypeException2
}
finally
{
    // Code de nettoyage facultatif
}
```

## Introduction du mot-clé `when`

Le mot-clé `when` étend la clause `catch` dans un bloc `try-catch`, permettant de vérifier des conditions supplémentaires avant d'exécuter le code du bloc catch. Cela offre un contrôle plus précis sur le moment où un bloc catch doit être exécuté.

### Syntaxe d'une clause `catch` avec `when`

```csharp
try
{
    // Code pouvant générer une exception
}
catch (TypeException ex) when (Condition)
{
    // Gérer TypeException si Condition est vraie
}
```

## Exemple d'utilisation

Considérons un scénario où nous avons une exception personnalisée `CarIsDeadException`, qui représente une situation où une voiture a rencontré une défaillance critique. Nous voulons gérer cette exception différemment en fonction du jour de la semaine où elle s'est produite.

### Classe d'exception personnalisée

```csharp
public class CarIsDeadException : Exception
{
    public DateTime ErrorTimeStamp { get; }
    
    public CarIsDeadException(DateTime timeStamp, string message) 
        : base(message)
    {
        ErrorTimeStamp = timeStamp;
    }
}
```

### Gestion des exceptions avec la clause `when`

```csharp
try
{
    // Code pouvant générer CarIsDeadException
}
catch (CarIsDeadException ex) when (ex.ErrorTimeStamp.DayOfWeek != DayOfWeek.Monday)
{
    // Gérer CarIsDeadException si elle ne s'est pas produite un lundi
    Console.WriteLine("Attraper la voiture en panne !");
    Console.WriteLine(ex.Message);
}
```

Dans cet exemple, le bloc `catch` s'exécutera uniquement si la propriété `ErrorTimeStamp` de l'objet `CarIsDeadException` indique un jour de la semaine autre que lundi. Cela permet une gestion plus nuancée des exceptions en fonction de critères supplémentaires.

## Avantages de l'utilisation du mot-clé `when`

- **Contrôle précis**: Les développeurs peuvent spécifier des conditions supplémentaires pour la gestion des exceptions, offrant un contrôle plus précis sur la façon dont les exceptions sont traitées.
  
- **Lisibilité**: L'utilisation de clauses `when` peut améliorer la lisibilité du code en exprimant la logique de gestion des exceptions de manière plus directe en ligne avec le bloc catch.

- **Réduction de la duplication du code**: Au lieu de dupliquer le code dans plusieurs blocs catch, les clauses `when` permettent aux développeurs de consolider la logique de gestion des exceptions courantes tout en fournissant des variations conditionnelles.

## Conclusion

Le mot-clé `when` en C# améliore la flexibilité et l'expressivité de la gestion des exceptions, permettant aux développeurs d'écrire un code plus robuste et maintenable. En incorporant des conditions supplémentaires dans les blocs catch, les développeurs peuvent adapter la logique de gestion des exceptions à des scénarios spécifiques, améliorant ainsi la fiabilité et la lisibilité globale de leurs applications.