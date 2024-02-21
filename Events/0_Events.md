# Compréhension des événements en C#

Les délégués sont des constructions intéressantes, car ils permettent aux objets en mémoire d'engager une conversation à deux voies.
Exposer des membres de délégué publics rompt l'encapsulation, ce qui peut non seulement rendre le code difficile à maintenir (et à déboguer) mais pourrait également ouvrir votre application à des risques de sécurité potentiels !

Heureusement, vous n'avez pas besoin de créer des méthodes personnalisées pour ajouter ou supprimer des méthodes à la liste d'invocation d'un délégué. C# fournit le mot-clé event.

## Exemple de code :

```csharp
public class Voiture
{
    // Ce délégué fonctionne en conjonction avec les événements de la voiture.
    public delegate void GestionnaireMoteurVoiture(string messagePourAppelant);

    // Cette voiture peut déclencher ces événements.
    public event GestionnaireMoteurVoiture Explose;
    public event GestionnaireMoteurVoiture SurLePointDExploser;

    public void Accelerer(int delta)
    {
        // Si la voiture est en panne, déclencher l'événement Explose.
        if (_voitureEstMorte)
        {
            Explose?.Invoke("Désolé, cette voiture est morte...");
        }
        else
        {
            VitesseActuelle += delta;
            
            // Presque en panne ?
            if (10 == VitesseMax - VitesseActuelle)
            {
                SurLePointDExploser?.Invoke("Attention mon ami ! Elle va exploser !");
            }
            
            // Toujours en marche !
            if (VitesseActuelle >= VitesseMax)
            {
                _voitureEstMorte = true;
            }
            else
            {
                Console.WriteLine("Vitesse actuelle = {0}", VitesseActuelle);
            }
        }
    }
}
```

## Ajouter et supprimer des gestionnaires d'événements

Lorsque vous souhaitez attacher à une source d'événements, utilisez l'opérateur +=, suivant le modèle suivant :

```csharp
Voiture.GestionnaireMoteurVoiture gestionnaire = new Voiture.GestionnaireMoteurVoiture(MoteurVoitureExplose);
maVoiture.Explose += gestionnaire;
```

Lorsque vous souhaitez détacher d'une source d'événements, utilisez l'opérateur -=, suivant le modèle suivant :

```csharp
maVoiture.Explose -= gestionnaire;
```

Notez que vous pouvez également utiliser la syntaxe de conversion de groupe de méthodes avec des événements :

```csharp
Voiture.GestionnaireMoteurVoiture gestionnaire = MoteurVoitureExplose;
maVoiture.Explose += gestionnaire;
```

## Utilisation de la syntaxe d'enregistrement des événements

Voici le code d'appel refacturé, maintenant utilisant la syntaxe d'enregistrement d'événement en C# :

```csharp
Console.WriteLine("***** Amusement avec les événements *****\n");
Voiture v1 = new Voiture("Coccinelle", 100, 10);

// Enregistrer les gestionnaires d'événements.
v1.SurLePointDExploser += VoitureEstPresqueMorte;
v1.SurLePointDExploser += VoitureSurLePointDExploser;
Voiture.GestionnaireMoteurVoiture gestionnaire = VoitureExplose;
v1.Explose += gestionnaire;

Console.WriteLine("***** Accélération *****");
for (int i = 0; i < 6; i++)
{
    v1.Accelerer(20);
}

// Supprimer la méthode VoitureExplose de la liste d'invocation.
v1.Explose -= gestionnaire;
```

## Conclusion

Les événements en C# sont un mécanisme puissant pour la communication entre objets. Ils permettent aux classes de notifier d'autres classes lorsqu'un événement spécifique se produit, ce qui facilite la conception de logiciels modulaires et extensibles. En comprenant les délégués et les événements, les développeurs peuvent créer des applications plus robustes et mieux organisées.