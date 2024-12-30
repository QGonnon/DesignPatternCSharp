using System;

public class Vendeur
{
  protected ConstructeurLiasseVehicule liasseVehicule;

  public Vendeur(ConstructeurLiasseVehicule liasseVehicule){
    this.liasseVehicule = liasseVehicule;
  }

  public void construit(string document){
    // return liasseVehicule.construitBonDeCommande();
  }
}