Les déclarations switch en C# sont une structure de contrôle puissante qui permet une sélection efficace parmi plusieurs options en fonction de la valeur d'une expression. Explorons un exemple pratique de l'utilisation des déclarations switch dans une méthode pour accorder des bonus aux employés en fonction de leurs types de rémunération.

```csharp
public void AccorderPrime(float montantBonus)
{
    Prime = this switch
    {
        { CatégoriePaiement: CatégoriePaiementEmployéEnum.Commission } => Prime + 0.10F * montantBonus,
        { CatégoriePaiement: CatégoriePaiementEmployéEnum.Horaire } => Prime + 40F * montantBonus / 2080F,
        { CatégoriePaiement: CatégoriePaiementEmployéEnum.Salarié } => Prime + montantBonus,
        _ => Prime + 0 // Cas par défaut : aucun bonus
    };
}
```

## Dans cet exemple :

- La méthode `AccorderPrime` prend un paramètre `montantBonus`, représentant le montant du bonus à accorder.
- La déclaration `switch` est utilisée pour évaluer la propriété `CatégoriePaiement` de l'instance d'objet actuelle.
- Pour chaque cas, différentes formules de calcul de bonus sont appliquées en fonction de la catégorie de paiement de l'employé :
  - Pour les employés avec une catégorie de paiement `Commission`, le bonus est augmenté de 10 % du montant du bonus.
  - Pour les employés avec une catégorie de paiement `Horaire`, le bonus est augmenté d'une fraction du montant du bonus calculée en fonction du nombre d'heures travaillées.
  - Pour les employés avec une catégorie de paiement `Salarié`, le bonus est augmenté du montant total du bonus.
- Le cas `_` représente le cas par défaut, où aucun bonus n'est ajouté.