
### Exemple de traitement des arguments au sein de plusieurs instructions
```csharp
static void SyntaxeExpressionLambda()
{
    // Créer une liste d'entiers.
    List<int> listeEntiers = new List<int>();
    listeEntiers.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

    // Traiter maintenant chaque argument au sein d'un groupe d'instructions de code.
    List<int> nombresPairs = listeEntiers.FindAll((entier) =>
    {
        Console.WriteLine("La valeur de l'entier est actuellement : {0}", entier);
        bool estPair = ((entier % 2) == 0);
        return estPair;
    });

    // Afficher les nombres pairs.
    Console.WriteLine("Voici vos nombres pairs :");
    foreach (int nombrePair in nombresPairs)
    {
        Console.Write("{0}\t", nombrePair);
    }
    Console.WriteLine();
}
```

Dans cet exemple, nous avons une méthode nommée `SyntaxeExpressionLambda`. Cette méthode illustre l'utilisation des expressions lambda pour traiter des arguments au sein de plusieurs instructions.

1. Tout d'abord, nous créons une liste d'entiers appelée `listeEntiers` et lui ajoutons quelques valeurs.

2. Ensuite, nous utilisons la méthode `FindAll` de la liste pour filtrer les éléments en fonction d'un prédicat. Le prédicat est une expression lambda `(entier) => { ... }` qui prend un entier en argument, imprime sa valeur et retourne `true` si l'entier est pair.

3. Les entiers pairs sont stockés dans une nouvelle liste appelée `nombresPairs`.

4. Enfin, nous parcourons la liste `nombresPairs` et affichons chaque nombre pair.

Ce code met en évidence l'utilisation des expressions lambda pour simplifier le traitement de données au sein de plusieurs instructions. Les expressions lambda sont couramment utilisées dans C# pour créer des fonctions anonymes de manière concise et élégante.