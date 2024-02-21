## Conversion de Type et Gestion de Débordement en C#

### Introduction
En C#, la conversion de type joue un rôle crucial pour assurer la compatibilité entre différents types de données. Cependant, des conversions inappropriées peuvent entraîner un comportement inattendu, tel que la perte de données ou des erreurs d'exécution. Ce document explique divers scénarios liés à la conversion de type et à la gestion de débordement en C#.

### Conversion Étroite
```csharp
// Tentative de conversion étroite
static void TentativeConversionEtroite()
{
    byte monOctet = 0;
    int monEntier = 200;
    monOctet = (byte)monEntier; // Conversion explicite d'int en byte
    Console.WriteLine("Valeur de monOctet : {0}", monOctet);
}
```
Dans cet exemple, une variable de type `int`, `monEntier`, est assignée à une variable de type `byte`, `monOctet`, entraînant une conversion étroite. Pour éviter toute perte de données potentielle, un casting explicite est nécessaire.

### Gestion de Débordement
```csharp
// Gestion du débordement à l'aide du mot-clé checked
try
{
    byte somme = checked((byte)Additionner(b1, b2)); // Utilisation du mot-clé checked pour détecter le débordement
    Console.WriteLine("somme = {0}", somme);
}
catch (OverflowException ex)
{
    Console.WriteLine(ex.Message);
}
```
Ici, le mot-clé `checked` est utilisé pour détecter le débordement lors d'opérations arithmétiques. Si un débordement se produit, une `OverflowException` est levée.

### Configuration de la Vérification de Débordement à l'Échelle du Projet (Visual Studio)
Pour activer la vérification de débordement pour l'ensemble d'un projet dans Visual Studio :
1. Ouvrez les propriétés du projet.
2. Sélectionnez "Toutes les configurations."
3. Cliquez sur le bouton "Avancé" dans l'onglet Compilation.
4. Cochez "Vérifier le dépassement/débordement arithmétique."

### Réflexion pour la Vérification de Type
```csharp
// Utilisation de la réflexion pour la vérification de type
static void DéclarerVariablesImplicites()
{
    // Variables locales typées implicitement
    var monEntier = 0;
    var monBooléen = true;
    var maChaine = "Le temps passe...";

    // Affichage du type sous-jacent
    Console.WriteLine("monEntier est un(e) : {0}", monEntier.GetType().Name);
}
```
La réflexion permet de déterminer le type d'une variable lors de l'exécution. Dans cette méthode, le type sous-jacent des variables typées implicitement (`var`) est affiché en utilisant la réflexion.

### Exemple Supplémentaire
```csharp
int n = int.Parse(choixLangage); // Conversion de chaîne en int
```
Dans cet exemple, une chaîne `choixLangage` est analysée en un `int` en utilisant `int.Parse()`. Cela démontre la conversion de chaîne en entier.