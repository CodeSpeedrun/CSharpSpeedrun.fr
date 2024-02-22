**Comportement par Défaut avec `get` et `set`:**

- **Méthodes `Clone` et `with` Automatiques:** Lorsque vous déclarez à la fois des accesseurs `get` et `set` pour une propriété dans un enregistrement, le compilateur génère automatiquement ces méthodes :
    - `Clone()`: Crée une copie profonde de l'instance de l'enregistrement.
    - `with { ... }`: Permet la création d'une nouvelle instance d'enregistrement avec des valeurs de propriété modifiées basées sur l'originale.
- **Accès et Modification Non-Destructifs:** Les accesseurs générés garantissent un comportement non-destructif, ce qui signifie que l'accès ou la modification d'une propriété n'altère pas l'instance originale de l'enregistrement. Cela crée une nouvelle instance ou une copie modifiée si nécessaire.

**Considérations Clés:**

- **Immuabilité et `readonly`:** Pour des enregistrements vraiment immuables, utilisez le mot-clé `readonly` dans la déclaration de l'enregistrement. Cela empêche le compilateur de générer des accesseurs `set`, ce qui garantit l'immutabilité. Si vous ajoutez accidentellement des accesseurs `set` à un enregistrement `readonly`, le compilateur générera une erreur.
- **Propriétés Calculées:** Vous pouvez définir des propriétés avec uniquement un accesseur `get` pour calculer des valeurs en fonction d'autres propriétés ou de données externes. Ces propriétés se comportent comme des champs en lecture seule et ne peuvent pas être modifiées à l'aide de `set`.
- **Comportement Personnalisé:** Si vous devez implémenter une logique spécifique pour l'accès ou la modification d'une propriété, vous pouvez substituer les méthodes générées automatiquement (`Clone()` et les accesseurs `get` et `set` synthétisés). Cependant, il est essentiel de considérer attentivement les implications de la substitution de ces méthodes en termes de sémantique et de comportement de l'enregistrement.

**Exemple:**

```csharp
public record Person(string Name, int Age)
{
    public string Nickname { get; set; } // À la fois get et set pour le surnom facultatif

    private string CalculateFullName() => $"{Name} (Age: {Age})";

    public string FullName => CalculateFullName(); // Propriété calculée avec uniquement get
}
```

**En Résumé:**

- Déclarer `get` et `set` dans une propriété d'enregistrement permet la lecture et l'écriture de valeurs, fournissant des accesseurs pour modifier l'état de l'enregistrement.
- Cependant, pour les enregistrements immuables, utilisez `readonly` pour éviter toute modification non intentionnelle et maintenir l'intégrité des données.
- Soyez attentif aux méthodes générées et remplacez-les avec prudence si nécessaire.