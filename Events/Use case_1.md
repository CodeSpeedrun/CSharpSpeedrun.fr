### Classe Voiture

#### Déclaration de la classe Voiture
```csharp
public class Voiture
```
- C'est la déclaration de la classe `Voiture`.

#### Déclaration des délégués et des événements
```csharp
public delegate void GestionnaireMoteurVoiture(string messagePourAppelant);
public event GestionnaireMoteurVoiture Explose;
public event GestionnaireMoteurVoiture SurLePointDExploser;
```
- Un délégué est un type qui représente les références à des méthodes avec une liste de paramètres spécifique et un type de retour spécifique.
- Les délégués définis ici sont utilisés pour définir la signature des gestionnaires d'événements.
- Les événements `Explose` et `SurLePointDExploser` sont déclarés pour être déclenchés lorsque certaines conditions se produisent dans la voiture.

#### Propriétés et variables
```csharp
private bool _voitureEstMorte = false;
public int VitesseMax { get; }
public int VitesseActuelle { get; private set; }
```
- `_voitureEstMorte` est une variable booléenne pour suivre l'état de la voiture.
- `VitesseMax` est la vitesse maximale de la voiture.
- `VitesseActuelle` est la vitesse actuelle de la voiture.

#### Constructeur
```csharp
public Voiture(string nom, int vitesseMax, int vitesseInitiale)
{
    Console.WriteLine($"Création d'une voiture : {nom}");
    VitesseMax = vitesseMax;
    VitesseActuelle = vitesseInitiale;
}
```
- Le constructeur de la classe `Voiture` initialise une nouvelle instance de la voiture avec un nom, une vitesse maximale et une vitesse initiale.

#### Méthode Accelerer
```csharp
public void Accelerer(int delta)
{
    if (_voitureEstMorte)
    {
        Explose?.Invoke("Désolé, cette voiture est morte...");
    }
    else
    {
        VitesseActuelle += delta;

        if (10 == VitesseMax - VitesseActuelle)
        {
            SurLePointDExploser?.Invoke("Attention mon ami ! Elle va exploser !");
        }

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
```
- Cette méthode simule l'accélération de la voiture.
- Si la voiture est morte, elle déclenche l'événement `Explose`.
- Sinon, elle vérifie si la voiture est sur le point d'exploser en déclenchant l'événement `SurLePointDExploser`.
- Elle vérifie également si la vitesse actuelle dépasse la vitesse maximale et marque la voiture comme morte si c'est le cas.

### Classe Program

#### Méthode Main
```csharp
static void Main(string[] args)
{
    // Création d'une instance de voiture.
    Voiture v1 = new Voiture("Coccinelle", 100, 10);

    // Enregistrement des gestionnaires d'événements.
    v1.SurLePointDExploser += VoitureEstPresqueMorte;
    v1.SurLePointDExploser += VoitureSurLePointDExploser;
    Voiture.GestionnaireMoteurVoiture gestionnaire = VoitureExplose;
    v1.Explose += gestionnaire;

    // Simulation de l'accélération de la voiture.
    for (int i = 0; i < 6; i++)
    {
        v1.Accelerer(20);
    }

    // Suppression d'un gestionnaire d'événements.
    v1.Explose -= gestionnaire;

    Console.ReadLine();
}
```
- Cette méthode est le point d'entrée du programme.
- Elle crée une instance de la classe `Voiture`.
- Elle enregistre des gestionnaires d'événements pour les événements `SurLePointDExploser` et `Explose`.
- Elle simule ensuite l'accélération de la voiture en appelant la méthode `Accelerer`.
- Finalement, elle supprime un gestionnaire d'événements pour l'événement `Explose`.

#### Autres méthodes
```csharp
static void VoitureEstPresqueMorte(string message)
{
    Console.WriteLine($"Voiture sur le point d'exploser : {message}");
}

static void VoitureSurLePointDExploser(string message)
{
    Console.WriteLine($"Voiture presque morte : {message}");
}

static void VoitureExplose(string message)
{
    Console.WriteLine($"Voiture morte : {message}");
}
```
- Ce sont des méthodes qui agissent comme des gestionnaires d'événements. Elles seront appelées lorsque les événements correspondants sont déclenchés.

### Toujours Statique?
La méthode `VoitureEstPresqueMorte` n'a pas besoin d'être statique. Dans cet exemple, elle est statique car elle est utilisée à l'intérieur de la classe `Program`, et en C#, la méthode `Main` (le point d'entrée du programme) est toujours statique. Cependant, si vous deviez déplacer cette méthode dans une autre classe et l'utiliser dans des contextes non statiques, vous supprimeriez le modificateur `static`.

Voici un exemple de comment vous pourriez la rendre non statique :

```csharp
public class EventHandler
{
    public void VoitureEstPresqueMorte(string message)
    {
        Console.WriteLine($"Voiture sur le point d'exploser : {message}");
    }
}
```

Ensuite, dans la méthode `Main` :

```csharp
static void Main(string[] args)
{
    EventHandler gestionnaireEvenement = new EventHandler();
    
    // ...

    v1.SurLePointDExploser += gestionnaireEvenement.VoitureEstPresqueMorte;
    
    // ...
}
```

Dans ce cas, `VoitureEstPresqueMorte` n'est plus statique, et elle est accédée via une instance de la classe `EventHandler`.

## Alternative



## Code
```csharp
using System;

public class Voiture {
    public delegate void GestionnaireMoteurVoiture(string messagePourAppelant);

    public event GestionnaireMoteurVoiture Explose;
    public event GestionnaireMoteurVoiture SurLePointDExploser;

    private bool _voitureEstMorte = false;
    public int VitesseMax { get; }
    public int VitesseActuelle { get; private set; }

    public Voiture(string nom, int vitesseMax, int vitesseInitiale) {
        Console.WriteLine($"Création d'une voiture : {nom}");
        VitesseMax = vitesseMax;
        VitesseActuelle = vitesseInitiale;
    }

    public void Accelerer(int delta) {
        if (_voitureEstMorte) {
            Explose?.Invoke("Désolé, cette voiture est morte...");
        } else {
            VitesseActuelle += delta;

            if (10 == VitesseMax - VitesseActuelle) {
                SurLePointDExploser?.Invoke("Attention mon ami ! Elle va exploser !");
            }

            if (VitesseActuelle >= VitesseMax) {
                _voitureEstMorte = true;
            } else {
                Console.WriteLine("Vitesse actuelle = {0}", VitesseActuelle);
            }
        }
    }
}

class Program {
    static void Main(string[] args) {
        Console.WriteLine("***** Amusement avec les événements *****\n");
        Voiture v1 = new Voiture("Coccinelle", 100, 10);

        // Enregistrer les gestionnaires d'événements.
        v1.SurLePointDExploser += VoitureEstPresqueMorte;
        v1.SurLePointDExploser += VoitureSurLePointDExploser;
        Voiture.GestionnaireMoteurVoiture gestionnaire = VoitureExplose;
        v1.Explose += gestionnaire;

        Console.WriteLine("***** Accélération *****");
        for (int i = 0; i < 6; i++) {
            v1.Accelerer(20);
        }

        // Supprimer la méthode VoitureExplose de la liste d'invocation.
        v1.Explose -= gestionnaire;

        Console.ReadLine();
    }

    static void VoitureEstPresqueMorte(string message) {
        Console.WriteLine($"Voiture sur le point d'exploser : {message}");
    }

    static void VoitureSurLePointDExploser(string message) {
        Console.WriteLine($"Voiture presque morte : {message}");
    }

    static void VoitureExplose(string message) {
        Console.WriteLine($"Voiture morte : {message}");
    }
}
/* 
***** Amusement avec les événements *****

Création d'une voiture : Coccinelle
***** Accélération *****
Vitesse actuelle = 30
Vitesse actuelle = 50
Vitesse actuelle = 70
Voiture sur le point d'exploser : Attention mon ami ! Elle va exploser !
Voiture presque morte : Attention mon ami ! Elle va exploser !
Vitesse actuelle = 90
Voiture morte : Désolé, cette voiture est morte...
*/
```