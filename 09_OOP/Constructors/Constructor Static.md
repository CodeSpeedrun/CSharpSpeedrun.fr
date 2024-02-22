## Constructeur statique

### Explication

Un constructeur statique en C# est utilisé pour initialiser des données statiques ou effectuer une action particulière une seule fois, au moment du chargement de la classe. Contrairement à un constructeur d'instance, un constructeur statique n'a pas de modificateurs d'accès et ne peut pas avoir de paramètres. Il est appelé automatiquement avant la création de la première instance ou l'accès à tout membre statique.

```csharp
static Motorcycle()
{
    // Implémentation du constructeur statique
}
```

### Exemple d'utilisation

L'exemple suivant illustre l'utilisation de la méthode `MakeSomeBikes`, qui instancie des objets `Motorcycle` avec différentes combinaisons d'arguments de constructeur.

```csharp
public static void MakeSomeBikes()
{
    // Créer des objets Motorcycle avec différents arguments de constructeur
}
```

#### Exemple d'instanciation

```csharp
// Instancier des objets Motorcycle avec différents arguments de constructeur
Motorcycle bike1 = new Motorcycle();
Motorcycle bike2 = new Motorcycle(name: "Tiny");
Motorcycle bike3 = new Motorcycle(intensity: 7);
```

##### Sortie :

- **Moto 1 :**
  - Nom du conducteur : ""
  - Intensité : 0

- **Moto 2 :**
  - Nom du conducteur : "Tiny"
  - Intensité : 0

- **Moto 3 :**
  - Nom du conducteur : ""
  - Intensité : 7

Dans cette démonstration, le constructeur statique de la classe `Motorcycle` n'est pas fourni explicitement, mais on suppose qu'il est présent. Les constructeurs statiques sont utiles pour initialiser des champs statiques ou effectuer des tâches de configuration ponctuelles pour une classe. Ils sont automatiquement invoqués par le runtime avant que des membres statiques ne soient accessibles ou que des instances ne soient créées.