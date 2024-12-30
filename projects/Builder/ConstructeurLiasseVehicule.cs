using System;

public interface ConstructeurLiasseVehicule
{
  void construitBonDeCommande(string nomClient);
  void construitDemandeImmatriculation(string nomDemandeur);
  Liasse resultat();
}