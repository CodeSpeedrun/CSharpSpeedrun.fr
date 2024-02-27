# Expressions Lambda avec plusieurs (ou zéro) paramètres

Le concept d'expressions lambda est un élément essentiel de la programmation fonctionnelle en C#. Les expressions lambda permettent de définir des fonctions anonymes de manière concise et flexible. Ce document explore l'utilisation des expressions lambda avec plusieurs paramètres, ainsi que la possibilité de définir des délégués prenant en charge ces expressions.

## Déclaration d'un délégué

```csharp
public delegate void MessageDelegue(string message, int resultat);
```

Dans cet exemple, nous définissons un délégué nommé `MessageDelegue` qui prend deux paramètres : un message de type `string` et un résultat de type `int`. Ce délégué sera utilisé pour encapsuler une méthode qui accepte ces types de paramètres.

## Utilisation d'une expression lambda avec un délégué

```csharp
public class CalculSimple
{
    private MessageDelegue _delegueMessage;
    
    public void DefinirGestionnaire(MessageDelegue cible)
    {
        _delegueMessage = cible;
    }
    
    public void Additionner(int x, int y)
    {
        _delegueMessage?.Invoke("L'addition est terminée !", x + y);
    }
}
```

Dans cet exemple, la classe `CalculSimple` possède une méthode `Additionner` qui prend deux entiers en paramètres et utilise un délégué pour envoyer un message après avoir effectué l'addition.

## Utilisation d'une expression lambda pour définir le gestionnaire de délégué

```csharp
CalculSimple calcul = new CalculSimple();
calcul.DefinirGestionnaire((message, resultat) =>
{
    Console.WriteLine("Message: {0}, Résultat: {1}", message, resultat);
});
calcul.Additionner(10, 10);
```

Ici, nous utilisons une expression lambda pour définir le gestionnaire de délégué de la classe `CalculSimple`. L'expression lambda accepte deux paramètres (message et résultat) et affiche ces valeurs à la console.

## Utilisation d'une expression lambda sans paramètres

```csharp
public delegate string DelegueSimple();
```

Ce code définit un délégué nommé `DelegueSimple` qui renvoie une chaîne de caractères. Nous pouvons utiliser une expression lambda pour implémenter ce délégué sans avoir besoin de paramètres explicites.

```csharp
DelegueSimple simpleDelegate = () => "Profitez de votre chaîne de caractères !";
Console.WriteLine(simpleDelegate());
```

Dans cet exemple, l'expression lambda ne prend aucun paramètre et retourne directement la chaîne de caractères "Profitez de votre chaîne de caractères !".

```csharp
using System;

class Program {
    public delegate void DelegueSimple();
    static void Main(string[] args) {
        DelegueSimple simpleDelegate 
            = () => Console.WriteLine("Profitez de votre chaîne de caractères!!!");
        simpleDelegate();
    }
}
```

Les expressions lambda offrent une flexibilité et une concision accrues lors de la définition de fonctions anonymes en C#. Elles sont largement utilisées dans divers contextes, notamment pour les gestionnaires d'événements, le traitement de collections et la programmation asynchrone.