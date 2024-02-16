# Boucles en C#

Les boucles sont des constructions fondamentales dans les langages de programmation qui permettent de répéter un bloc de code jusqu'à ce qu'une certaine condition soit rencontrée. En C#, il existe plusieurs types de boucles, chacune ayant un objectif différent.

## 1. Boucle `for`

La boucle `for` en C# est une instruction de flux de contrôle permettant d'itérer un nombre spécifique de fois. Elle se compose de trois parties : l'initialisation, la condition et l'incrémentation/décrémentation.

```csharp
for(int index = 0; index < 4; index++)
{
    Console.WriteLine("Le numéro est : {0} ", index);
}
```

### Exemple :
```csharp
for(int i = 0; i <= 10; i += 2)
{
    Console.WriteLine(i);
}
```

## 2. Boucle `foreach`

La boucle `foreach` en C# est utilisée pour itérer sur les éléments des collections ou des tableaux. Elle simplifie le code et le rend plus lisible par rapport aux boucles `for` traditionnelles.

```csharp
string[] marquesVoitures = {"Ford", "BMW", "Yugo", "Honda"};
foreach (string marque in marquesVoitures)
{
    Console.WriteLine(marque);
}
```

### Exemple :
```csharp
List<int> nombres = new List<int>{1, 2, 3, 4, 5};
foreach (int num in nombres)
{
    Console.WriteLine(num * num);
}
```

## 3. Boucle `while`

La boucle `while` en C# exécute de manière répétée une instruction cible tant qu'une condition donnée est vraie. Elle évalue la condition avant d'exécuter le corps de la boucle.

```csharp
int compteur = 0;
while (compteur < 5)
{
    Console.WriteLine("Compteur : {0}", compteur);
    compteur++;
}
```

### Exemple :
```csharp
int saisieUtilisateur;
while (!int.TryParse(Console.ReadLine(), out saisieUtilisateur))
{
    Console.WriteLine("Saisie invalide. Veuillez entrer un entier.");
}
```

## 4. Boucle `do/while`

La boucle `do/while` en C# est similaire à la boucle `while`, mais elle garantit que le bloc de code est exécuté au moins une fois, peu importe si la condition est initialement vraie ou fausse.

```csharp
int nombre = 5;
do
{
    Console.WriteLine("Nombre : {0}", nombre);
    nombre--;
} while (nombre > 0);
```

### Exemple :
```csharp
string reponse;
do
{
    Console.WriteLine("Voulez-vous continuer ? (oui/non)");
    reponse = Console.ReadLine().ToLower();
} while (reponse != "oui" && reponse != "non");
```

La différence entre la boucle `do/while` et la boucle `while` est que les boucles `do/while` garantissent l'exécution du bloc de code correspondant au moins une fois. En revanche, il est possible qu'une simple boucle `while` ne s'exécute jamais si la condition de terminaison est fausse dès le départ.