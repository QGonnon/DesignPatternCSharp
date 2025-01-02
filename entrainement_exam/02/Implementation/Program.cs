using System;

Liasse liasse = new Liasse();
ContratHabitation contratHabitation = new ContratHabitation("Habitation", DateTime.Now, 1000);
ContratAutomobile contratAutomobile = new ContratAutomobile("Automobile", DateTime.Now, 2000);
contratHabitation.ajouterAnnexe("Clause 1 : oui");
liasse.ajouterContrat(contratHabitation);
liasse.ajouterContrat(contratAutomobile);

Console.WriteLine("Liasse : ");
liasse.afficherInfo();

liasse.supprimerContrat(contratHabitation);

Console.WriteLine("Liasse : ");
liasse.afficherInfo();