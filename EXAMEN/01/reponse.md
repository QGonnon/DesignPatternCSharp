# Quelles sont les limitations du code actuel pour gérer les différents traitements ?
La gestion est entièrement faite dans la classe RapportIncident avec des propriétés booléens, rendant le code moins lisible et moins flexible.

# Comment faudrait-il modifier ce code pour ajouter un nouveau traitement ?
On devrait ajouter de nouveaux booléens, méthodes et conditions dans GetContenu afin d'ajouter un nouveau traitement.

# Quel problème pose l'ajout de multiples traitements combinés ?
L'ajout de multiples traitements combinés alourdit la classe et le code existant.

# En observant le diagramme de classes fourni, identifiez: le composant de base, les decorateurs, les relations entre les composants.
composant de base : RapportIncident
decorateurs : RapportDecorator, RapportAnonyme, RapportChiffre, RapportSigne, RapportJournalise
relations entre les composants: 
- RapportIncident et RapportDecorator implémentent IRapport
- RapportAnonyme, RapportChiffre, RapportSigne, et RapportJournalise héritent de RapportDecorator
- RapportDecorator contient une référence à IRapport (composition)

# Pourquoi utilise-t-on une interface IRapport ?
L'interface IRapport permet de traiter tous les types de rapports et décorateurs de manière uniforme.

# Quel est le role de la classe abstraite RapportDecorator ?
La classe abstraite RapportDecorator sert de base pour tous les décorateurs de rapports.

# Completez le code source de la solution
```csharp
using System;

public interface IRapport
{
    string GetContenu();
    string GetAuteur();
}

public class RapportIncident : IRapport
{
    private string contenu;
    private string auteur;

    public RapportIncident(string contenu, string auteur)
    {
        this.contenu = contenu;
        this.auteur = auteur;
    }

    public string GetContenu()
    {
        return contenu;
    }

    public string GetAuteur()
    {
        return auteur;
    }
}

public abstract class RapportDecorator : IRapport
{
    protected IRapport rapport;

    public RapportDecorator(IRapport rapport)
    {
        this.rapport = rapport;
    }

    public abstract string GetContenu();
    public abstract string GetAuteur();
}

public class RapportAnonyme : RapportDecorator
{
    public RapportAnonyme(IRapport rapport) : base(rapport) { }

    public override string GetContenu()
    {
        return rapport.GetContenu().Replace("identifiant", "***").Replace("password", "***");
    }

    public override string GetAuteur()
    {
        return "ANONYME";
    }
}

public class RapportChiffre : RapportDecorator
{
    public RapportChiffre(IRapport rapport) : base(rapport) { }

    public override string GetContenu()
    {
        string contenu = rapport.GetContenu();
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(contenu));
    }

    public override string GetAuteur()
    {
        return rapport.GetAuteur();
    }
}

public class RapportSigne : RapportDecorator
{
    public RapportSigne(IRapport rapport) : base(rapport) { }

    public override string GetContenu()
    {
        return rapport.GetContenu() + "\nSigné par: " + rapport.GetAuteur();
    }

    public override string GetAuteur()
    {
        return rapport.GetAuteur();
    }
}

public class RapportJournalise : RapportDecorator
{
    public RapportJournalise(IRapport rapport) : base(rapport) { }

    public override string GetContenu()
    {
        string contenu = rapport.GetContenu();
        JournaliserAcces();
        return contenu;
    }

    public override string GetAuteur()
    {
        return rapport.GetAuteur();
    }

    private void JournaliserAcces()
    {
        Console.WriteLine($"[LOG] Accès au rapport à {DateTime.Now}");
    }
}
```

# Comment créeriez-vous un rapport qui est à la fois anonyme et chiffré ? (code attendu)

```csharp
IRapport rapport = new RapportIncident(
    "Intrusion détectée.",
    "John Doe"
);

rapport = new RapportAnonyme(rapport);
rapport = new RapportChiffre(rapport);

Console.WriteLine($"Rapport par: {rapport.GetAuteur()}");
Console.WriteLine($"Contenu: {rapport.GetContenu()}");
```

# Comment l'ordre des décorateurs affecte-t-il le résultat final ?
L'ordre dans lequel on applique les décorateurs affecte le résultat final car chaque décorateur modifie le contenu ou l'auteur du rapport avant que le suivant n'y ajoute ses propres modifications.

# Donnez un exemple concret où l'ordre des décorateurs est important.4
Anonymiser les données (identifiant, mot de passe) avant de les chiffrer fonctionne de la manière souhaité. Cependant, l'ordre contraire où l'on chiffre avant d'anonymiser, rendrait l'anonymisation inefficace car les données seraient déjà illisibles et on ne saurait pas quoi anonymiser.