using System;

public abstract class Contrat
{
    public List<string> Annexes = new List<string>();
    public string? clauseStandard;
    public string Nom;
    public DateTime Date;
    public int Montant;

    public Contrat(string nom, DateTime date, int montant)
    {
        Nom = nom;
        Date = date;
        Montant = montant;
    }

    public void ajouterAnnexe(string clause){
        Annexes.Add(clause);
    }
    public void supprimerAnnexe(string clause){
        Annexes.Remove(clause);
    }

    public void afficherInfo(){
        Console.WriteLine("Nom : " + Nom);
        Console.WriteLine("Date : " + Date);
        Console.WriteLine("Montant : " + Montant);
        Console.WriteLine("Clause standard : " + clauseStandard);
        if(Annexes.Count > 0){
            Console.WriteLine("Annexes : ");
            foreach(string annexe in Annexes){
                Console.WriteLine(annexe);
            }
        }
    }
    
    public Contrat dupliquer()
    {
        return (Contrat)this.MemberwiseClone();
    }
}