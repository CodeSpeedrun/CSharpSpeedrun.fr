# Namespace ObjetModel

## ObservableCollection<T> 
La classe ObservableCollection<T> représente une collection de données dynamique qui fournit des notifications lorsque des éléments sont ajoutés, supprimés, ou lorsque la liste entière est actualisée.

## ReadOnlyObservableCollection<T> 
La classe ReadOnlyObservableCollection<T> représente une version en lecture seule de ObservableCollection<T>.

La classe ObservableCollection<T> est utile car elle a la capacité d'informer des objets externes lorsque son contenu change de quelque manière que ce soit.

Travailler avec ObservableCollection<T> est identique à travailler avec List<T>, étant donné que ces deux classes implémentent les mêmes interfaces de base.

Ce qui rend la classe ObservableCollection<T> unique, c'est que cette classe prend en charge un événement nommé CollectionChanged. Cet événement se déclenchera chaque fois qu'un nouvel élément est inséré, qu'un élément actuel est supprimé (ou déplacé), ou lorsque la collection entière est modifiée.

Pour illustrer cela, considérons un exemple de création d'une collection d'objets Personne et de gestion de l'événement CollectionChanged.

```csharp
// Créer une collection à observer et ajouter quelques objets Personne.
ObservableCollection<Personne> personnes = new ObservableCollection<Personne>()
{
    new Personne{ Prénom = "Pierre", Nom = "Dupont", Age = 30 },
    new Personne{ Prénom = "Marie", Nom = "Lambert", Age = 25 },
};

// Connecter l'événement CollectionChanged.
personnes.CollectionChanged += Personnes_CollectionChanged;

// Méthode de gestion de l'événement CollectionChanged.
static void Personnes_CollectionChanged(object sender,
System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
{
    // Traitement à effectuer lorsqu'un changement se produit dans la collection.
    // Par exemple, mise à jour de l'interface utilisateur, enregistrement des données, etc.
}
```

Dans cet exemple, chaque fois qu'un élément est ajouté, supprimé ou déplacé dans la collection de personnes, la méthode `Personnes_CollectionChanged` est appelée pour gérer cet événement.

Cela offre une grande flexibilité dans la gestion des données dynamiques, notamment dans les applications où les utilisateurs peuvent ajouter ou supprimer des éléments de manière interactive.
 