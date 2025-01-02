using System;

public class ContratHabitation : Contrat
{

    public ContratHabitation(string nom, DateTime date, int montant) : base(nom, date, montant)
    {
        clauseStandard = "Contrat d'assurance habitation";
    }
}