using System;

public class Liasse{
    public List<Contrat> Contrats;

    public Liasse(){
        Contrats = new List<Contrat>();
    }

    public void ajouterContrat(Contrat contrat){
        Contrats.Add(contrat);
    }

    public void supprimerContrat(Contrat contrat){
        Contrats.Remove(contrat);
    }

    public void afficherInfo(){
        foreach(Contrat contrat in Contrats){
            contrat.afficherInfo();
            Console.WriteLine();
        }
    }
}