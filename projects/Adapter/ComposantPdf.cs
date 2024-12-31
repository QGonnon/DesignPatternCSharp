using System;

public class ComposantPdf
{
  protected string contenu;

  public void pdfFixeContenu(string contenu)
  {
    this.contenu = contenu;
  }

  public void pdfPrepareAffichage()
  {
    Console.WriteLine("Affichage du PDF : " + contenu);
  }

  public void pdfRafraichit()
  {
    Console.WriteLine("Rafraîchissement du PDF : " + contenu);
  }

  public void pdfTermineAffichage()
  {
    Console.WriteLine("Finalisation du PDF : " + contenu);
  }

  public void pdfEnvoieImprimante()
  {
    Console.WriteLine("Impression du PDF : " + contenu);
  }
}