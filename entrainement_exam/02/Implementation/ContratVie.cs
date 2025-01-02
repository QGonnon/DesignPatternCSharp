using System;

public class ContratVie : Contrat
{

    public ContratVie(string nom, DateTime date, int montant) : base(nom, date, montant)
    {
        clauseStandard = "Contrat d'assurance vie";
    }
}