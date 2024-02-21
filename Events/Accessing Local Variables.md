# Accès aux Variables Locales

Les méthodes anonymes sont intéressantes, car elles peuvent accéder aux variables locales de la méthode qui les définit.

Une méthode anonyme ne peut pas accéder aux paramètres ref ou out de la méthode qui la définit.
- Une méthode anonyme ne peut pas avoir de variable locale portant le même nom qu'une variable locale dans la méthode externe.
- Une méthode anonyme peut accéder aux variables d'instance (ou aux variables statiques, le cas échéant) dans la portée de la classe externe.
- Une méthode anonyme peut déclarer des variables locales portant le même nom que les variables membres de la classe externe (les variables locales ont une portée distincte et masquent les variables membres de la classe externe).

```csharp
// Crée une voiture comme d'habitude.
Voiture voiture1 = new Voiture("SlugBug", 100, 10);
// Enregistre des gestionnaires d'événements sous forme de méthodes anonymes.
voiture1.PresqueEnPanne += delegate
{
    comptePresqueEnPanne++;
    Console.WriteLine("Aïe ! Trop vite !");
};
voiture1.PresqueEnPanne += delegate(object sender, CarEventArgs e)
{
    comptePresqueEnPanne++;
    Console.WriteLine("Message critique de la voiture : {0}", e.msg);
};
...
// Cela déclenchera éventuellement les événements.
for (int i = 0; i < 6; i++)
{
    voiture1.Accélérer(20);
}
Console.WriteLine("L'événement PresqueEnPanne a été déclenché {0} fois.",
    comptePresqueEnPanne);
Console.ReadLine();
```

Ce code démontre l'utilisation de méthodes anonymes pour gérer des événements dans C#. La classe `Voiture` a un événement `PresqueEnPanne` auquel on s'abonne avec des méthodes anonymes. Ces méthodes anonymes sont définies inline, sans nom, et peuvent accéder aux variables locales de la méthode qui les contient.

Les méthodes anonymes fournissent une manière concise de définir des gestionnaires d'événements ou des fonctions de rappel en ligne, sans avoir à déclarer explicitement une méthode séparée.

Il est important de noter que les méthodes anonymes ont des limitations telles que l'accès restreint aux variables locales et l'impossibilité d'accéder aux paramètres ref ou out, ce qui peut limiter leur utilisation dans certains cas.

Dans ce code, `voiture1.PresqueEnPanne` est un événement déclenché lorsque la vitesse de la voiture est proche du seuil de sécurité. Les méthodes anonymes associées à cet événement augmentent un compteur et affichent des messages d'alerte lorsque l'événement est déclenché.

Cela illustre comment les méthodes anonymes peuvent être utilisées de manière efficace pour gérer des événements dans C#, offrant une flexibilité et une concision accrues dans la gestion des comportements asynchrones.