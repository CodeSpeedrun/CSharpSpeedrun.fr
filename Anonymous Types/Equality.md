# La Sémantique de l'Égalité pour les Types Anonymes

Pour illustrer la sémantique de l'égalité pour les types anonymes en C#, nous allons créer deux objets anonymes représentant des voitures et explorer leur comportement en matière d'égalité.

1. **Création des objets anonymes**

Nous créons deux objets anonymes, `premiereVoiture` et `deuxiemeVoiture`, ayant les mêmes paires de noms/valeurs, à savoir la couleur, la marque et la vitesse actuelle.

```csharp
var premiereVoiture = new { Couleur = "Rose Vif", Marque = "Saab", VitesseActuelle = 55 };
var deuxiemeVoiture = new { Couleur = "Rose Vif", Marque = "Saab", VitesseActuelle = 55 };
```

2. **Test d'égalité**

Nous testons si les deux objets anonymes sont considérés comme égaux en utilisant la méthode `Equals()`.

```csharp
if (premiereVoiture.Equals(deuxiemeVoiture))
{
    // Code exécuté si les deux objets sont considérés comme égaux.
}
```

Dans cet exemple, les deux objets anonymes `premiereVoiture` et `deuxiemeVoiture` ont les mêmes valeurs pour leurs propriétés (`Couleur`, `Marque` et `VitesseActuelle`). Cependant, ils sont considérés comme deux instances distinctes en raison de la nature des types anonymes en C#. L'appel à la méthode `Equals()` retournera `false`, car les deux objets ne font pas référence au même emplacement mémoire, même s'ils ont les mêmes valeurs.

3. **Conclusion**

En résumé, les types anonymes en C# sont considérés comme égaux uniquement s'ils référencent exactement le même objet en mémoire. Dans le cas des objets anonymes, même s'ils ont les mêmes valeurs pour leurs propriétés, ils ne sont pas considérés comme égaux, car ce sont deux instances distinctes. Pour comparer les valeurs des propriétés, il est souvent préférable de comparer chaque propriété individuellement plutôt que d'utiliser la méthode `Equals()` pour les objets anonymes.