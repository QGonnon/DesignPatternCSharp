using System;

public class ConstructeurLiasseVehiculePdf : ConstructeurLiasseVehicule
{
  protected Liasse liasse;

  public ConstructeurLiasseVehiculePdf() {
    this.liasse = new LiassePdf();
  }

  public void construitBonDeCommande(string nomClient){
    string document;
    document = "<PDF>Bon de commande Client : " + nomClient + "</PDF>";
    liasse.ajouteDocument(document);
  }
  public void construitDemandeImmatriculation(string nomDemandeur){
    string document;
    document = "<PDF>Demande d'immatriculation Demandeur : " + nomDemandeur + "</PDF>";
    liasse.ajouteDocument(document);
  }
  public Liasse resultat(){
    return liasse;
  }
}