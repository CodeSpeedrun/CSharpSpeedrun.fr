# La classe System.Type

La classe System.Type définit des membres qui permettent d'examiner les métadonnées d'un type, notamment en renvoyant des types de l'espace de noms System.Reflection. Par exemple, Type.GetMethods() renvoie un tableau d'objets MethodInfo, Type.GetFields() renvoie un tableau d'objets FieldInfo, etc.

## Méthodes de la classe System.Type

- **GetConstructors()**: Retourne les constructeurs du type.
- **GetEvents()**: Retourne les événements du type.
- **GetFields()**: Retourne les champs du type.
- **GetInterfaces()**: Retourne les interfaces implémentées par le type.
- **GetMembers()**: Retourne tous les membres du type.
- **GetMethods()**: Retourne les méthodes du type.
- **GetNestedTypes()**: Retourne les types imbriqués dans le type.
- **GetProperties()**: Retourne les propriétés du type.
- **FindMembers()**: Retourne un tableau de MemberInfo basé sur des critères de recherche.
- **GetType()**: Retourne une instance de Type à partir d'un nom de chaîne.
- **InvokeMember()**: Permet une "liaison tardive" pour un élément donné.

Ces méthodes (parmi d'autres) vous permettent d'obtenir un tableau représentant les éléments (interface, méthode, propriété, etc.) qui vous intéressent. Chaque méthode renvoie un tableau associé (par exemple, GetFields() renvoie un tableau de FieldInfo, GetMethods() renvoie un tableau de MethodInfo, etc.). Notez que chacune de ces méthodes a une forme singulière (par exemple, GetMethod(), GetProperty(), etc.) qui vous permet de récupérer un élément spécifique par son nom, plutôt qu'un tableau de tous les éléments associés.

Vous pouvez obtenir une instance de la classe Type de différentes manières. Cependant, vous ne pouvez pas créer directement un objet Type à l'aide du mot-clé new car Type est une classe abstraite.

## Exemples de récupération d'informations de type

Vous pouvez obtenir une instance de la classe Type de plusieurs manières. Voici quelques exemples :

1. En utilisant une instance de classe existante :
```csharp
Voiture v = new Voiture();
Type t = v.GetType();
```

2. En utilisant l'opérateur typeof :
```csharp
Type t = typeof(Voiture);
```

3. En utilisant la méthode statique Type.GetType() :
```csharp
Type t = Type.GetType("Bibliotheque.Voiture", false, true);
```

Dans ces exemples, "Voiture" est le nom de la classe pour laquelle nous voulons obtenir des informations de type. Assurez-vous de remplacer "Voiture" par le nom de la classe que vous utilisez réellement.

Ces méthodes offrent différentes façons d'obtenir des informations sur un type en C#. Utilisez-les en fonction de vos besoins spécifiques dans vos applications.