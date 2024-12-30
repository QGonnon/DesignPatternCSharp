using System;

public abstract class ConstructeurLiasseVehicule
{
  protected Liasse liasse;

  public ConstructeurLiasseVehicule(Liasse liasse)
  {
    this.liasse = liasse;
  }

  public abstract void construitBonDeCommande();
  public abstract void construitDemandeImmatriculation();
  public abstract void resultat();
}