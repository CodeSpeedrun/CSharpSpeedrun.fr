### Utilisation de `Convert.ToInt32();`

Le code ci-dessous illustre l'utilisation de la méthode `Convert.ToInt32()` pour convertir une entrée utilisateur en entier. Cette méthode est utile lorsque vous attendez spécifiquement une valeur numérique entière en entrée.

```csharp
Console.WriteLine("Veuillez entrer votre âge : ");
int age = Convert.ToInt32(Console.ReadLine()); // Convertit une entrée de type chaîne en entier
Console.WriteLine("Âge = " + age);
```

#### Détails :
- `Convert.ToInt32()` convertit la valeur de l'objet spécifié en un entier 32 bits signé équivalent.
- Cette méthode lève une exception `FormatException` si la chaîne d'entrée ne peut pas être convertie en un entier valide.

#### Exemple supplémentaire :
```csharp
string userInput = "25";
int convertedValue = Convert.ToInt32(userInput);
Console.WriteLine(convertedValue); // Affichera 25
```

### `Console.Read()`

La deuxième méthode pour capturer l'entrée utilisateur est `Console.Read()`, qui lit toute la ligne d'entrée mais ne renvoie que la valeur ASCII du premier caractère. Par exemple, la valeur ASCII de A est 65. Certaines applications ou périphériques utilisent encore l'encodage ASCII, donc cette méthode peut être utile dans certains cas spécifiques.

```csharp
Console.WriteLine("Entrez le code de coupon : ");
int code = Console.Read();

Console.WriteLine("ASCII = " + code);
```

#### Détails :
- `Console.Read()` renvoie le code ASCII du premier caractère de l'entrée utilisateur.
- Il est important de noter que cette méthode ne lit qu'un seul caractère, même si l'utilisateur entre plus d'un caractère.

#### Exemple supplémentaire :
```csharp
char firstChar = (char)Console.Read();
Console.WriteLine(firstChar); // Affichera le premier caractère de l'entrée utilisateur
```

### `Console.ReadKey()`

La troisième méthode pour capturer l'entrée utilisateur est `Console.ReadKey()`. Cette méthode enregistre la première touche du clavier et renvoie la structure `ConsoleKeyInfo`, qui peut être utilisée pour afficher des informations supplémentaires sur la touche qui a été pressée.

```csharp
Console.WriteLine("Appuyez sur n'importe quelle touche pour continuer...");
ConsoleKeyInfo key = Console.ReadKey();

Console.WriteLine();
Console.WriteLine("Touche pressée = " + key.Key);
```

#### Détails :
- `Console.ReadKey()` renvoie une instance de `ConsoleKeyInfo`, qui contient des informations sur la touche pressée, telles que la touche elle-même et si des touches de modification telles que Alt ou Shift étaient également pressées.
- Cette méthode n'attend pas que l'utilisateur appuie sur la touche "Entrée" et lit directement la saisie de l'utilisateur.

#### Exemple supplémentaire :
```csharp
ConsoleKeyInfo keyInfo = Console.ReadKey(true); // Le paramètre true masque l'affichage de la touche pressée
Console.WriteLine($"Touche pressée : {keyInfo.KeyChar}");
``` 

En combinant ces différentes méthodes de capture d'entrée utilisateur, vous pouvez concevoir des interfaces utilisateur interactives et conviviales dans vos applications C#.