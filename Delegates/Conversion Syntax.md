# Utilisation des délégués comme activants d'événements

Dans ce code, nous illustrons l'utilisation des délégués comme activants d'événements en C#.

## Déclaration de méthodes

```csharp
public delegate void MoteurVoitureEventHandler(string message);
```
Nous déclarons un délégué `MoteurVoitureEventHandler` qui peut pointer vers des méthodes qui prennent une chaîne de caractères comme paramètre.

## Définition de la classe Voiture

```csharp
public class Voiture
{
    // Déclaration de l'événement moteur.
    public event MoteurVoitureEventHandler Moteur;

    // Méthode pour accélérer la voiture.
    public void Accelerer(int vitesse)
    {
        // Logique d'accélération de la voiture.
        if (vitesse > 0)
        {
            // Si la vitesse est positive, déclencher l'événement.
            Moteur?.Invoke($"La voiture accélère à {vitesse} km/h.");
        }
    }
}
```

## Utilisation des délégués comme activants d'événements

```csharp
Console.WriteLine("***** Utilisation des délégués comme activants d'événements *****\n");

// Création d'une instance de Voiture.
Voiture voiture = new Voiture();

// Définition des méthodes de gestion d'événements.
void GestionnaireEvenement1(string message)
{
    Console.WriteLine("Événement 1: " + message);
}

void GestionnaireEvenement2(string message)
{
    Console.WriteLine("Événement 2: " + message);
}

// Enregistrement des gestionnaires d'événements.
voiture.Moteur += GestionnaireEvenement1;
voiture.Moteur += GestionnaireEvenement2;

// Accélération de la voiture.
Console.WriteLine("***** Accélération *****");
for (int i = 0; i < 5; i++)
{
    voiture.Accelerer(20);
}

// Désenregistrement du gestionnaire d'événement 1.
voiture.Moteur -= GestionnaireEvenement1;

// Accélération supplémentaire de la voiture.
Console.WriteLine("***** Accélération supplémentaire *****");
for (int i = 0; i < 5; i++)
{
    voiture.Accelerer(30);
}
```

Dans ce code, nous créons une instance de la classe `Voiture` et définissons deux méthodes `GestionnaireEvenement1` et `GestionnaireEvenement2` pour gérer les événements déclenchés par la voiture. Nous enregistrons ensuite ces gestionnaires d'événements avec l'événement `Moteur` de la voiture. Ensuite, nous accélérons la voiture plusieurs fois, ce qui déclenche les événements et appelle les gestionnaires correspondants. Enfin, nous désenregistrons le gestionnaire d'événement 1 et accélérons à nouveau la voiture pour observer que seul le gestionnaire d'événement 2 est appelé.