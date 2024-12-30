using System;

public class ConstructeurLiasseVehiculeHtml : ConstructeurLiasseVehicule
{
  protected Liasse liasse;

  public ConstructeurLiasseVehiculeHtml() {
    this.liasse = new LiasseHtml();
  }

  public void construitBonDeCommande(string nomClient){
    string document;
    document = "<HTML>Bon de commande Client : " + nomClient + "</HTML>";
    liasse.ajouteDocument(document);
  }
  public void construitDemandeImmatriculation(string nomDemandeur){
    string document;
    document = "<HTML>Demande d'immatriculation Demandeur : " + nomDemandeur + "</HTML>";
    liasse.ajouteDocument(document);
  }
  public Liasse resultat(){
    return liasse;
  }
}