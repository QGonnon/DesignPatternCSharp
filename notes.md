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
Au moment de l'achat de vehicule, un commercial va creer une liasse de documents (bon de commande, demande d'immatriculation, certificat de cession, etc...). Ces documents sont disponibles au format PDF ou HTML selon le choix du client. Dans le premier , le client fournit une instance de la classe ConstructeurLiasseVehiculeHtml et dans le second cas, il fournit une instance de la classe ConstructeurLiasseVehiculePdf.
Dans un second temps le commercial effectue la demande de creation de chaque document de la liasse liee a l'instance.

Le vendeur cree alors les documents de la liasse a l'aide des methodes construitBonDeCommande et construitDemandeImmatriculation.

## Définition
Son but est de séparer des documents complexes

composition : mécanisme qui permet à une classe de contenir une instance de cette même classe ou d'une autre

### le pattern Prototype
- Création de nouveaux objets par duplication d'objets existants
- On les appelle Prototype
- Capacité de clonage

#### Utilisation 
- Le design pattern Prototype permet de créer des copies d'objets existants sans rendre le code dépendant de leurs classes concrètes. Au lieu de créer un objet a partir de zero, on clone un objet existant (le prototype) et on le modifie si besoin.
- C'est comme faire une photocopie d'un document : on copie l'original et on peut modifier la copie
- L'avantage principal est la création d'objets complexes simplifée.
- Cas d'usage:
    - Objets avec de nombreuses configuration ( editeur   graphique : formes geometriques)
    - En jeux video, creation d'enemis et leur variation en   grande quantité
    - Creation d'une configuration par defaut dans un jeu/logiciel (permet de restaurer le defaut rapidement et de configurer a nouveau)
    - Pour eviter la creation d'objets systemes couteux : connexions reseaux, ressources partagées ...

### Le pattern de Structuration 
- Permet de faciliter l'indépendance de l'interface d'un objet vis a vis de son implementation. Dans le cas d'un ensemble d'objets, il s'agit aussi de rendre cette interface indépendante de la hierarchie des classes et de la composition des objets.
- Les patterns de structuration encapsulent la composition des objets (augmentation du niveau d'abstraction)
- Précédemment les patterns de création encapsulaient la création des objets.| 

### Le pattern Adapter
- Convertis l'interface d'une classe existante en une interface attendue par ses client (afin qu'ils puissent travailler ensemble)
- Autrement dit, c'est fournir une nouvelle interface pour répondre aux besoins de clients

### Le pattern Bridge
- Séparer l'aspect d'implémentation d'un objet de son aspect représentation et d'interface

#### Exemple
Le pattern Bridge sépare une grosse classe en deux parties qui peuvent être developpees independamment.

Exemple avec une telecommande TV:

- Abstraction: La telecommande (les boutons volumes, chaines, etc)
- Implementation: Les marques de TV (Sony, Samsung, etc)