# La problématique de la concurrence

Lorsque plusieurs threads manipulent des données partagées, il est crucial de garantir la cohérence de ces données en les protégeant contre les modifications concurrentes.

Le planificateur de threads peut interrompre l'exécution d'un thread à tout moment, ce qui peut conduire à des situations où un thread accède à des données incohérentes, voire corrompues, si aucune mesure de protection n'est mise en place.

## Exemple de code

Considérons une classe `GestionnaireStock` qui simule la gestion d'un stock de produits. Cette classe dispose d'une méthode `ModifierStock()` permettant de mettre à jour la quantité de produits en stock.

```csharp
using System;
using System.Threading;

namespace GestionStockMultiThread
{
    public class GestionnaireStock
    {
        private int quantiteProduits;

        public void ModifierStock(int quantite)
        {
            // Simuler un traitement prenant du temps
            Thread.Sleep(1000);

            // Mettre à jour la quantité de produits en stock
            quantiteProduits += quantite;

            // Afficher le nouveau stock
            Console.WriteLine($"Stock mis à jour. Nouvelle quantité : {quantiteProduits}");
        }
    }
}
```

Dans cet exemple, la méthode `ModifierStock()` est susceptible d'être appelée par plusieurs threads simultanément pour mettre à jour la quantité de produits en stock.

## Synchronisation des threads

Lorsque plusieurs threads accèdent à une méthode ou à des ressources partagées, il est impératif de synchroniser leur accès pour éviter les conflits et garantir la cohérence des données.

Considérons un scénario où plusieurs threads tentent de modifier le stock en parallèle sans aucune synchronisation :

```csharp
using System;
using System.Threading;
using GestionStockMultiThread;

Console.WriteLine("***** Synchronisation des Threads *****\n");
GestionnaireStock gestionnaireStock = new GestionnaireStock();

Thread[] threads = new Thread[5];
for (int i = 0; i < 5; i++)
{
    int quantite = i + 1; // Quantité de produits à ajouter
    threads[i] = new Thread(() => gestionnaireStock.ModifierStock(quantite))
    {
        Name = $"Thread {i + 1}"
    };
}

foreach (Thread thread in threads)
{
    thread.Start();
}
```

Dans cet exemple, cinq threads sont créés pour modifier le stock en ajoutant différentes quantités de produits simultanément. Sans aucune synchronisation, les threads pourraient interagir de manière imprévisible, entraînant des résultats incorrects ou corrompus.
