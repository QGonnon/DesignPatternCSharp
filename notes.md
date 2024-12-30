# Design pattern
## Résumé 
- Schema d'objet qui forme une solution à un problème connu qu'on rencontre fréquemment
- Ensemble de classes et de relation
- Dans le cadre de la POO
- Basé sur les bonnes pratiques

## Définiton
- Le langage UML et le C# (java, ...)
- Pour chaque pattern :
    - Nom
    - Description
    - Exemple sous forme UML
    - Structure générique du pattern
    - Le cas d'utilisation
    - Un example de code C#
    - (lien)

## Étude de cas : la vente en ligne de véhicules
- Description du système
- cahier des charges
- prises en compte des patterns de conception

### Cahier des charges
- Véhicules destinés à la vente
- Catalogue
- Options
- Panier / gestion de commandes

## Introduction aux patterns de construction
### Résumé 
- Abstraire le mechanisme de création d'objets

### Example
En C#, une instruction de creation de classe :

```csharp
let class = new MyClass()
```
Dans certains cas il est necessaire de parametrer la construction d'objets:

```csharp
public class Document{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public DateTime Created { get; set; }
}


public class Program{
    public Document CreateDoc(string typeDoc){
        Document doc = null;

        if (typeDoc == "Word")
        {
            doc = new Document();
            doc.Title = "New Document";
            doc.Content = "Content";
        }
        else if (typeDoc == "Excel")
        {
            doc = new Document();
            doc.Title = "New Excel Document";
            doc.Content = "Excel Content";
        }
        else
        {
            doc = new Document();
            doc.Title = "New Document";
            doc.Content = "Content";
        }
    }
}
```

## Introduction aux patterns de construction
### le pattern Abstract Factory
#### Description
Le but du pattern est la création d'objets regroupés en famille sans devoir connaitre les classes concretes destinées à la création de ces objets.

Fournit une interface pour la creation de familles d'objets lies ou dependants sans preciser leur classe concrete.

#### Contexte:

Le systeme de vente de vehicules gere des vehicules qui fonctionnent soit de maniere electrique soit avec de l'essence. La gestion de ce
mecanisme sera gere par la l'objet Catalogue . L'objet Catalogue se charge alors de cree de tels objets (vehicules).

Pour chacun des prduits, nous disposons d'une classe abstraite, et sous-classe qui decrit la version electrique et la version essence.

Si l'objet Catalogue utilise les sous classes pour instancier les produits, on devra apporter des modifications a la classe catalogue lors de
l'ajout de chaque nouveau produit.

Le pattern Abstract Factory resout cette problematique en introduisant une interface FabriqueVehicule qui contient la signature des methodes
pour definir chaque produit. Le type de retour de ces methodes est constitué par l'une des classes abstraites de produit. L'objet Catalogue n'a
alors pas besoin de connaitre les classes concretes des produits.

Une sous-classe d'implementation de FabriqueVehicule est introduite pour chaque famille de produit, à savoir les sous-classes
FabriqueVehiculeEssence et FabriqueVehiculeElectrique .
Une telle sous-classe implante les opérations de création du véhicule appropriée pour la famille à laquelle
elle est associée.

### le pattern Builder
## Contexte
Lors de l'achat d'un véhicule, plein de papiers (au format html, pdf...) sont créer/génerer et remplis avec le client et le commercial

## Définition
Son but est de séparer des documents complexes