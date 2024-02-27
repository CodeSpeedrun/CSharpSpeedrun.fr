# EventHandler<> avec expressions lambda

Les expressions lambda fournissent un moyen propre et concis de définir une méthode anonyme, ce qui simplifie indirectement le travail avec les délégués. Dans cet exemple, nous allons réaménager `CarEventArgs`  en utilisant la syntaxe des expressions lambda. Voici une version simplifiée de la classe `Program` de ce projet, qui utilise la syntaxe des expressions lambda pour se connecter à chaque événement envoyé par l'objet Car :

```csharp
using System;

// Définition de la classe EvenementVoiture pour encapsuler les événements
public class EvenementVoitureArgs : EventArgs {
    public string Message { get; }

    public EvenementVoitureArgs(string message) {
        Message = message;
    }
}

// Définition de la classe Voiture
public class Voiture {
    public event EventHandler<EvenementVoitureArgs> AlarmeSurPointDeSurchauffe;
    public event EventHandler<EvenementVoitureArgs> Explosion;

    private int _temperature;

    public Voiture(int temperatureInitiale) {
        this._temperature = temperatureInitiale;
    }

    public void Accelerer(int increment) {
        if (_temperature > 110) {
            AlarmeSurPointDeSurchauffe?.Invoke
            (this, new EvenementVoitureArgs("Attention : surchauffe !"));
        }

        if (_temperature > 130) {
            Explosion?.Invoke
            (this, new EvenementVoitureArgs("BOOM ! La voiture a explosé."));
            return;
        }

        _temperature += increment;
        Console.WriteLine($"La voiture accélère. La température est maintenant de {_temperature} degrés.");
    }
}

class Program {
    static void Main(string[] args) {
        // Crée une voiture comme d'habitude.
        Voiture voiture1 = new Voiture(10);

        // Se connecte aux événements avec des lambdas !
        voiture1.AlarmeSurPointDeSurchauffe += (expediteur, evenement) => {
            Console.WriteLine(evenement.Message);
        };

        voiture1.Explosion += (expediteur, evenement) => {
            Console.WriteLine(evenement.Message);
        };

        // Accélère (ceci va générer les événements).
        Console.WriteLine("\n***** Accélération *****");
        for (int i = 0; i < 8; i++) {
            voiture1.Accelerer(20);
        }

        Console.ReadLine();
    }
}
/*
***** Accélération *****
La voiture accélère. La température est maintenant de 30 degrés.
La voiture accélère. La température est maintenant de 50 degrés.
La voiture accélère. La température est maintenant de 70 degrés.
La voiture accélère. La température est maintenant de 90 degrés.
La voiture accélère. La température est maintenant de 110 degrés.
La voiture accélère. La température est maintenant de 130 degrés.
Attention : surchauffe !
La voiture accélère. La température est maintenant de 150 degrés.
Attention : surchauffe !
BOOM ! La voiture a explosé.
*/
```

Dans cet exemple, nous avons utilisé des expressions lambda pour connecter des gestionnaires d'événements aux événements déclenchés par l'objet `Voiture`. 

## Comprendre les Expressions Lambda

Les expressions lambda sont des fonctions anonymes qui peuvent contenir des expressions et des instructions. Elles sont utilisées principalement pour créer des délégués ou des arbres d'expression. Une expression lambda se compose des paramètres (s'ils existent), de l'opérateur `=>` (appelé opérateur lambda) et du corps.

Dans notre exemple :
- `(expediteur, evenement) => { Console.WriteLine(evenement.message); }` est une expression lambda qui agit comme un gestionnaire d'événements.
- `expediteur` est le paramètre représentant l'objet envoyant l'événement.
- `evenement` est le paramètre représentant les données de l'événement.
- `{ Console.WriteLine(evenement.message); }` est le corps de l'expression lambda, qui définit les actions à effectuer lorsque l'événement est déclenché.

## Avantages des Expressions Lambda

Les expressions lambda offrent plusieurs avantages, notamment :
- **Concision du code :** Elles permettent de définir des fonctions anonymes en quelques lignes de code, ce qui rend le code plus lisible et compact.
- **Facilité d'utilisation :** Elles simplifient le travail avec les délégués et les événements en permettant une syntaxe plus simple et plus intuitive.

En utilisant des expressions lambda, nous pouvons rendre notre code plus élégant et plus facile à comprendre, tout en conservant la même fonctionnalité que l'exemple précédent utilisant des délégués bruts.