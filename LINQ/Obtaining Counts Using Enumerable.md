# Obtention de Comptes à l'aide d'Enumerable

Lors de la projection de nouveaux lots de données, il est souvent nécessaire de déterminer le nombre exact d'éléments retournés dans la séquence. Chaque fois que le besoin se fait sentir de connaître le nombre d'éléments générés à partir d'une expression de requête LINQ, la méthode `Count()` est précieuse.

## Obtenir un Compte à partir d'une Requête

La méthode `Count()` est cruciale pour déterminer le nombre d'éléments dans une séquence résultant d'une requête LINQ.

```csharp
static void ObtenirCompteDepuisRequete()
{
    string[] livres = {"Le Grand Gatsby", "Ne tirez pas sur l'oiseau moqueur", "1984", "Orgueil et Préjugés", "L'Attrape-cœurs"};
    // Obtenir le compte à partir de la requête.
    int count = (from l in livres where l.Length > 10 select l).Count();
    // Afficher le compte.
    Console.WriteLine($"Nombre de livres avec plus de 10 caractères : {count}");
}
```

Dans cet exemple, `livres` est un tableau de chaînes contenant les titres des livres. Nous utilisons une requête LINQ pour sélectionner les livres dont les titres sont plus longs que 10 caractères, puis nous utilisons la méthode `Count()` pour obtenir le nombre d'éléments dans la séquence résultante. Enfin, nous affichons le nombre de tels livres.

## Conclusion

La méthode `Count()` est un outil puissant pour obtenir le nombre d'éléments dans une séquence résultant d'une requête LINQ. Sa polyvalence en fait un outil inestimable pour les tâches de manipulation de données dans les applications C#.