
# Utilisation de Délégués pour Envoyer des Notifications sur l'État d'un Objet

## Introduction
L'utilisation de délégués est une pratique courante en C# pour implémenter des fonctionnalités de rappel (callback). Dans ce tutoriel, nous allons explorer comment utiliser les délégués pour envoyer des notifications sur l'état d'un objet, en utilisant une classe de voiture comme exemple.

## Étape 1 : Définir un nouveau type de délégué
```csharp
public delegate void NotificationMoteurVoiture(string messagePourAppelant);
```
Dans cette étape, nous définissons un nouveau type de délégué appelé `NotificationMoteurVoiture`, qui peut être utilisé pour envoyer des notifications sur l'état du moteur de la voiture.

## Étape 2 : Déclarer une variable membre de délégué dans la classe Voiture
```csharp
private NotificationMoteurVoiture _listeGestionnaires;
```
Nous déclarons une variable membre de type `NotificationMoteurVoiture` dans la classe `Voiture` pour stocker les gestionnaires de notifications.

## Étape 3 : Créer une fonction d'aide sur la Voiture pour permettre au client de spécifier la méthode à rappeler
```csharp
public void EnregistrerGestionnaireMoteur(NotificationMoteurVoiture methodeARappeler)
{
    _listeGestionnaires = methodeARappeler;
}
```
Cette méthode permet au client d'enregistrer une méthode de rappel pour recevoir des notifications sur l'état du moteur de la voiture.

## Étape 4 : Implémenter la méthode Accélérer() pour invoquer la liste d'invocation du délégué
```csharp
public void Accelerer(int delta)
{
    if (_voitureEstMorte)
    {
        _listeGestionnaires?.Invoke("Désolé, cette voiture est hors service...");
    }
    else
    {
        // Logique d'accélération de la voiture
    }
}
```
Dans cette méthode, nous invoquons la liste d'invocation du délégué `_listeGestionnaires` pour envoyer des notifications sur l'état du moteur de la voiture, en fonction des circonstances.

## Exemple d'utilisation
```csharp
class Program
{
    static void Main(string[] args)
    {
        Voiture maVoiture = new Voiture("Mini", 120, 0);
        maVoiture.EnregistrerGestionnaireMoteur(
            new NotificationMoteurVoiture(GestionnaireEvenementMoteur));
        maVoiture.Accelerer(20);
        Console.ReadLine();
    }

    static void GestionnaireEvenementMoteur(string message)
    {
        Console.WriteLine("Notification du moteur : " + message);
    }
}
```
Dans cet exemple, nous créons une instance de la classe `Voiture`, enregistrons un gestionnaire d'événement pour les notifications sur l'état du moteur, puis accélérons la voiture, déclenchant ainsi les notifications.

Dans ce tutoriel, nous avons appris à utiliser les délégués en C# pour envoyer des notifications sur l'état d'un objet, en l'occurrence une voiture. Cette technique est utile pour implémenter des fonctionnalités de rappel dans vos applications C#.