FabriqueDocument fabrique;

Console.WriteLine("Voulez-vous créer des documents pour particulier (1) ou professionnel (2) :");
string? choix = Console.ReadLine();
if (choix == "1")
{
    Console.WriteLine("Documents pour client particulier:");
    fabrique = new FabriqueDocumentParticulier();
}
else
{
    Console.WriteLine("\nDocuments pour client professionnel:");
    fabrique = new FabriqueDocumentProfessionnel();
}
Releve releve = fabrique.CreerReleve();
Attestation attestation = fabrique.CreerAttestation();

releve.AfficherInfos();
attestation.AfficherInfos();
