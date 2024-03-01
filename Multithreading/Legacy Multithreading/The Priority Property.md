# La Propriété de Priorité des Threads

Par défaut, tous les threads ont un niveau de priorité normal.

```csharp
public enum NiveauPrioriteThread
{
    LePlusBas,
    EnDessousDeNormal,
    Normal, // Valeur par défaut.
    AuDessusDeNormal,
    LePlusHaut
}
```

La propriété de priorité est utilisée pour définir le niveau de priorité d'un thread dans un programme C#. Les threads sont des unités d'exécution concurrentes dans un programme, et la priorité d'un thread détermine son importance relative par rapport aux autres threads en cours d'exécution.

La priorité du thread peut être définie en utilisant la propriété `Priority` d'une instance de `Thread`. Cette propriété accepte une valeur de l'énumération `NiveauPrioriteThread`, permettant de définir la priorité du thread selon cinq niveaux différents : LePlusBas, EnDessousDeNormal, Normal, AuDessusDeNormal, et LePlusHaut.

Par exemple, supposons que nous ayons un thread `monThread` et nous voulons lui attribuer une priorité élevée :

```csharp
Thread monThread = new Thread(MethodeDuThread);
monThread.Priority = NiveauPrioriteThread.LePlusHaut;
```

Dans cet exemple, le thread `monThread` se verra attribuer la priorité la plus élevée, ce qui signifie qu'il sera exécuté avec une priorité plus élevée par rapport aux autres threads dans le système.

Il est important de noter que la priorité du thread est relative et peut varier en fonction de plusieurs facteurs, tels que la politique de planification du système d'exploitation sous-jacent. Par conséquent, bien que la priorité puisse influencer l'ordre d'exécution des threads, elle ne garantit pas nécessairement un comportement spécifique dans tous les cas.