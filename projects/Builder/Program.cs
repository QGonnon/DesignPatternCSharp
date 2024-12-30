
using Builder;

ConstructeurLiasseVehicule constructeur;


string? choix = Console.ReadLine();

if (choix == "1")
{
    constructeur = new ConstructeurLiasseVehiculeHtml();
}
else
{
    constructeur = new ConstructeurLiasseVehiculePdf();
}


Vendeur vendeur = new Vendeur(constructeur);

Liasse liasse = vendeur.Construit("Nom client");

liasse.imprime();



















// Declaration de constructeur / builder 
// Determiner son type a l'aide du schema

// Proposer a l'utilisateur de choisir un type de 
// documents ( liasse pdf ou liasse html)



// Creation d'une instance de la classe Vendeur qui prend en parametre un objet de type ConstructeurLiasseVehicule...


// Vendeur.construit("nom client particulier"); retourne un une instance de type LiasseVehicule (html ou pdf ou autre)
// qu'on peut stocker dans une variable liasse

// liasse.imprime(); // imprime le contenu de la liasse (html ou pdf ou autre)

