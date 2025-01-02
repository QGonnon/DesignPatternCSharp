using System;

public class ContratAutomobile : Contrat
{

    public ContratAutomobile(string nom, DateTime date, int montant) : base(nom, date, montant)
    {
        clauseStandard = "Contrat d'assurance automobile";
    }
}