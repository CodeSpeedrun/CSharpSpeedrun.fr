# Notes sur la Delegate générique EventHandler<T>

Dans la programmation orientée objet en C#, les délégués sont des types de données qui permettent de référencer des méthodes avec la même signature que celle du délégué. La classe `EventHandler<T>` est une déléguée générique utilisée pour représenter les méthodes qui manipulent des événements.

```csharp
public class Voiture
{
    // Déclaration des événements
    public event EventHandler<EvenementVoitureArgs> EnFeu;
    public event EventHandler<EvenementVoitureArgs> SurLePointDExploser;

    // Code de la classe...
}
```

Dans cet exemple, nous avons une classe `Voiture` qui déclare deux événements : `EnFeu` et `SurLePointDExploser`. Ces événements sont définis avec le type générique `EventHandler<T>` où `T` est le type d'arguments passés avec l'événement.

Pour utiliser ces événements, nous devons enregistrer des gestionnaires d'événements, également connus sous le nom de méthodes de rappel, qui seront exécutées lorsque les événements se produisent.

```csharp
Voiture voiture1 = new Voiture();
voiture1.SurLePointDExploser += GestionnaireEvenement1;
voiture1.SurLePointDExploser += GestionnaireEvenement2;
EventHandler<EvenementVoitureArgs> gestionnaire = GestionnaireEvenement3;
voiture1.EnFeu += gestionnaire;
```

Dans ce code, nous instancions un objet de la classe `Voiture` appelé `voiture1`. Ensuite, nous ajoutons des gestionnaires d'événements aux événements `SurLePointDExploser`. Deux méthodes de gestion d'événements (`GestionnaireEvenement1` et `GestionnaireEvenement2`) sont enregistrées pour cet événement. Nous ajoutons également une méthode de gestion d'événements nommée `GestionnaireEvenement3` à l'événement `EnFeu` en utilisant une référence de délégué.

Les gestionnaires d'événements sont des méthodes qui correspondent à la signature spécifiée par le délégué. Par exemple, pour `EventHandler<EvenementVoitureArgs>`, la méthode de gestion d'événements doit prendre deux paramètres : l'objet source et les arguments de l'événement.

Les événements fournissent un mécanisme puissant pour la communication entre objets dans une application C#. Ils permettent aux objets d'être informés des changements ou des actions qui se produisent dans d'autres parties du programme, ce qui facilite la conception de systèmes modulaires et flexibles.

### Exemple complet :

```csharp
using System;

public class EvenementVoitureArgs : EventArgs
{
    // Définition des propriétés des arguments de l'événement
}

public class Voiture
{
    // Déclaration des événements
    public event EventHandler<EvenementVoitureArgs> EnFeu;
    public event EventHandler<EvenementVoitureArgs> SurLePointDExploser;

    // Code de la classe...
}

class Program
{
    static void Main(string[] args)
    {
        Voiture voiture1 = new Voiture();
        voiture1.SurLePointDExploser += GestionnaireEvenement1;
        voiture1.SurLePointDExploser += GestionnaireEvenement2;
        EventHandler<EvenementVoitureArgs> gestionnaire = GestionnaireEvenement3;
        voiture1.EnFeu += gestionnaire;

        // Logique de l'application...
    }

    static void GestionnaireEvenement1(object sender, EvenementVoitureArgs e)
    {
        // Implémentation du gestionnaire d'événements 1
    }

    static void GestionnaireEvenement2(object sender, EvenementVoitureArgs e)
    {
        // Implémentation du gestionnaire d'événements 2
    }

    static void GestionnaireEvenement3(object sender, EvenementVoitureArgs e)
    {
        // Implémentation du gestionnaire d'événements 3
    }
}
```

Dans cet exemple complet, nous avons une classe `Voiture` avec des événements déclarés. Nous avons également une méthode `Main` qui instancie un objet `Voiture` et ajoute des gestionnaires d'événements à ses événements. Ensuite, nous avons des méthodes de gestion d'événements `GestionnaireEvenement1`, `GestionnaireEvenement2` et `GestionnaireEvenement3` qui implémentent la logique de gestion des événements.