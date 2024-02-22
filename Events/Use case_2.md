### Qu'est-ce qu'un événement ?

Un événement est simplement un wrapper de délégué. Il est recommandé d'utiliser le délégué intégré `EventHandler` pour les événements courants. Les événements sont créés en utilisant des classes Éditeur (Publisher) et des classes Abonné (Subscriber). L'éditeur déclenche l'événement, tandis que les abonnés s'inscrivent aux événements et implémentent les méthodes gestionnaires d'événements.

#### Étapes de l'événement
1. Définir un délégué
2. Définir un événement basé sur le délégué
3. L'éditeur déclenche l'événement

#### Exemple de code expliqué

Ce code illustre un système d'événement simple en C#. Voici une explication détaillée du code :

##### Classe `ProductEventArgs`
Cette classe hérite de `EventArgs` et contient une propriété `Product` qui représente un produit.

##### Classes `MailSender` et `FaxSender`
Ces classes représentent des abonnés à l'événement. Elles implémentent chacune une méthode `OnProductOrdered` qui agit comme un gestionnaire d'événements. Lorsque l'événement est déclenché, ces méthodes sont appelées pour traiter l'événement.

##### Classe `Product`
Cette classe représente un produit avec une propriété `Title`.

##### Classe `OrderManager`
C'est la classe éditrice qui déclenche l'événement. Elle définit un événement `ProductOrderedEventHandler` basé sur le délégué `EventHandler<ProductEventArgs>`. La méthode `OrderProduct` simule la commande d'un produit et déclenche l'événement `ProductOrderedEventHandler` avec les données du produit. La méthode `OnProductOrdered` est protégée et virtuelle pour permettre aux classes dérivées de la substituer si nécessaire.

##### Méthode `Main`
Dans cette méthode, une instance de `Product` est créée, ainsi que des instances de `MailSender` et `FaxSender`. Un gestionnaire d'événements est ajouté pour chaque abonné à l'événement `ProductOrderedEventHandler`. Enfin, la méthode `OrderProduct` de `OrderManager` est appelée pour déclencher l'événement.

##### Résultat
Lorsque l'événement est déclenché, les abonnés à l'événement (ici `MailSender` et `FaxSender`) exécutent leurs méthodes de gestion d'événements pour traiter l'événement. Dans cet exemple, les messages "Mail order sent for => Nutella Breakfast Bar" et "Fax order sent for => Nutella Breakfast Bar" sont affichés, indiquant que les abonnés ont bien reçu et traité l'événement.

```csharp
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main()
        {
            // Création d'une instance de produit
            var product = new Product() { Title = "Nutella Breakfast Bar" };
            
            // Création des instances de MailSender et FaxSender
            var mailSender = new MailSender();
            var faxSender = new FaxSender();

            // Création d'une instance de OrderManager
            var orderManager = new OrderManager();

            // Abonnement des abonnés à l'événement ProductOrderedEventHandler
            orderManager.ProductOrderedEventHandler += mailSender.OnProductOrdered;
            orderManager.ProductOrderedEventHandler += faxSender.OnVideoEncoded;

            // Commande du produit
            orderManager.OrderProduct(product);
        }
    }
    
    // Classe dérivée d'EventArgs pour transporter des informations sur le produit
    class ProductEventArgs : EventArgs
    {
        public Product Product { get; set; }
    }
    
    // Classe représentant un expéditeur de courrier
    class MailSender
    {
        // Méthode de gestion d'événement pour l'envoi de courrier
        public void OnProductOrdered(object source, ProductEventArgs e)
        {
            Console.WriteLine("Mail order sent for => " + e.Product.Title);
        }
    }
    
    // Classe représentant un expéditeur de fax
    class FaxSender
    {
        // Méthode de gestion d'événement pour l'envoi de fax
        public void OnVideoEncoded(object source, ProductEventArgs e)
        {
            Console.WriteLine("Fax order sent for => " + e.Product.Title);
        }
    }
    
    // Classe représentant un produit
    class Product
    {
        public string Title { get; set; }
    }

    // Classe gérant les commandes de produits
    class OrderManager
    {
        // Événement déclenché lorsqu'un produit est commandé
        public event EventHandler<ProductEventArgs> ProductOrderedEventHandler;

        // Méthode pour commander un produit
        public void OrderProduct(Product product)
        {
            Console.WriteLine("Ordering product ...");

            // Création d'un objet ProductEventArgs pour transporter les informations sur le produit
            var data = new ProductEventArgs() { Product = product };

            // Déclenchement de l'événement
            OnProductOrdered(data);
        }

        // Méthode virtuelle protégée pour déclencher l'événement
        protected virtual void OnProductOrdered(ProductEventArgs e)
        {
            // Appel des méthodes des abonnés à l'événement s'il y en a
            ProductOrderedEventHandler?.Invoke(this, e);
        }
    }
}
```

## Résultat de l'exécution :

Ordering product ...
Mail order sent for => Nutella Breakfast Bar
Fax order sent for => Nutella Breakfast Bar