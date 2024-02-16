# Types de données en C# et raccourcis : Compréhension des types système et conformité CLS

## Introduction
En C#, les types de données sont essentiels pour définir des variables et leurs valeurs. Ce document Markdown explore divers types de données, leur plage et leurs représentations abrégées dans le contexte de la conformité à la spécification de langage commun (CLS).

### Booléen (bool)
- **Conforme au CLS** : Oui
- **Plage** : Booléen représente vrai ou faux, indiquant la véracité ou la fausseté.

### Byte signé (sbyte)
- **Conforme au CLS** : Non
- **Plage** : -128 à 127
- **Description** : Nombre signé sur 8 bits, permettant la représentation de valeurs entières dans la plage de -128 à 127.

### Byte non signé (byte)
- **Conforme au CLS** : Oui
- **Plage** : 0 à 255
- **Description** : Nombre non signé sur 8 bits, permettant la représentation de valeurs entières de 0 à 255.

### Entier court signé (short)
- **Conforme au CLS** : Oui
- **Plage** : -32 768 à 32 767
- **Description** : Nombre signé sur 16 bits, permettant la représentation de valeurs entières dans la plage de -32 768 à 32 767.

### Entier court non signé (ushort)
- **Conforme au CLS** : Non
- **Plage** : 0 à 65 535
- **Description** : Nombre non signé sur 16 bits, capable de représenter des valeurs entières de 0 à 65 535.

### Entier signé (int)
- **Conforme au CLS** : Oui
- **Plage** : -2 147 483 648 à 2 147 483 647
- **Description** : Entier signé sur 32 bits, adapté à la représentation de valeurs entières dans une large plage.

## Extraits de code et explication

### Vérification du type d'une valeur littérale
```csharp
Console.WriteLine("13.GetType() = {0}", 13.GetType());
// Sortie : 13.GetType() = System.Int32
```
Cet extrait montre comment déterminer le type de données d'une valeur littérale, en utilisant la méthode `GetType()`.

### Fonctionnalité du type Char
```csharp
Console.WriteLine("=> Fonctionnalité du type char :");
char myChar = 'a';
Console.WriteLine("char.IsDigit('a') : {0}", char.IsDigit(myChar));
Console.WriteLine("char.IsLetter('a') : {0}", char.IsLetter(myChar));
Console.WriteLine("char.IsWhiteSpace('Hello There', 5) : {0}",
char.IsWhiteSpace("Hello There", 5));
Console.WriteLine("char.IsWhiteSpace('Hello There', 6) : {0}",
char.IsWhiteSpace("Hello There", 6));
Console.WriteLine("char.IsPunctuation('?') : {0}",
char.IsPunctuation('?'));
```
Cette section illustre diverses fonctionnalités liées au type `char`, telles que la vérification si un caractère est un chiffre, une lettre, un espace blanc ou une ponctuation.

### Analyse des types de données
```csharp
Console.WriteLine("=> Analyse des types de données :");
bool b = bool.Parse("True");
Console.WriteLine("Valeur de b : {0}", b);
double d = double.Parse("99.884");
Console.WriteLine("Valeur de d : {0}", d);
int i = int.Parse("8");
Console.WriteLine("Valeur de i : {0}", i);
char c = Char.Parse("w");
Console.WriteLine("Valeur de c : {0}", c);
```
Ici, l'analyse des types de données est illustrée en utilisant diverses méthodes comme `bool.Parse`, `double.Parse`, `int.Parse` et `Char.Parse`.

### Analyse des types de données avec TryParse
```csharp
Console.WriteLine("=> Analyse des types de données avec TryParse :");
if (bool.TryParse("True", out bool b))
{
Console.WriteLine("Valeur de b : {0}", b);
}
else
{
Console.WriteLine("Valeur par défaut de b : {0}", b);
}
```
Cet extrait illustre l'analyse des types de données en utilisant les méthodes `TryParse`, offrant une approche plus sûre en évitant les exceptions.

### Constructeur DateTime
```csharp
// Ce constructeur prend (année, mois, jour).
DateTime dt = new DateTime(2015, 10, 17);
```
Un exemple de création d'un objet `DateTime` en utilisant son constructeur avec des paramètres pour l'année, le mois et le jour.