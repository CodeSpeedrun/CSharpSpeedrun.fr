# Activation de la Multidiffusion

En d'autres termes, un objet délégué peut maintenir une liste de méthodes à appeler, plutôt qu'une seule méthode. Lorsque vous souhaitez ajouter plusieurs méthodes à un objet délégué, vous utilisez simplement l'opérateur += surchargé, plutôt qu'une affectation directe.

```csharp
public class Voiture
{
    // Maintenant avec le support de la multidiffusion !
    // Notez que nous utilisons maintenant l'opérateur +=, et non
    // l'opérateur d'affectation (=).
    private CarEngineHandler _listeDesGestionnaires;

    public void EnregistrerAvecMoteurVoiture(
        CarEngineHandler methodeAAppeler)
    {
        _listeDesGestionnaires += methodeAAppeler;
    }

    Voiture v1 = new Voiture("Coccinelle", 100, 10);
    // Enregistrez plusieurs cibles pour les notifications.
    v1.EnregistrerAvecMoteurVoiture(new Voiture.CarEngineHandler(OnEvenementMoteurVoiture));
    v1.EnregistrerAvecMoteurVoiture(new Voiture.CarEngineHandler(OnEvenementMoteurVoiture2));
    // Accélérer (cela déclenchera les événements).
    Console.WriteLine("***** Accélération *****");
    for (int i = 0; i < 6; i++)
    {
        v1.Accélérer(20);
    }
    Console.ReadLine();

    // Nous avons maintenant DEUX méthodes qui seront appelées par la voiture
    // lors de l'envoi de notifications.
    static void OnEvenementMoteurVoiture(string msg)
    {
        Console.WriteLine("\n*** Message De l'Objet Voiture ***");
        Console.WriteLine("=> {0}", msg);
    }
}
```

Dans cet exemple, nous avons une classe `Voiture` qui démontre l'utilisation de la multidiffusion pour les événements du moteur de voiture. Plutôt que de lier un seul gestionnaire d'événements à l'objet délégué, nous pouvons enregistrer plusieurs gestionnaires d'événements en utilisant l'opérateur +=.

- **Définition de la Classe Voiture**: La classe `Voiture` contient une méthode publique `EnregistrerAvecMoteurVoiture`, qui permet d'enregistrer des gestionnaires d'événements pour les événements du moteur de voiture.
- **Utilisation de la Multidiffusion**: L'opérateur += est utilisé pour ajouter des gestionnaires d'événements à une liste d'objets délégués (`_listeDesGestionnaires`).
- **Enregistrement des Gestionnaires d'Événements**: Nous pouvons enregistrer plusieurs gestionnaires d'événements en appelant la méthode `EnregistrerAvecMoteurVoiture` avec différents gestionnaires d'événements.
- **Exemple d'Accélération**: Nous accélérons la voiture, ce qui déclenche les événements du moteur de voiture, et chaque gestionnaire d'événements enregistré est appelé.

Cette approche permet une flexibilité accrue dans la gestion des événements, car plusieurs objets peuvent réagir à un seul événement sans nécessiter de modification de l'objet source.