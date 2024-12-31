using System;

public class DocumentHtml : Document
{
  protected string contenu;
  
  public DocumentHtml(string contenu)
  {
    this.contenu = contenu;
  }
  
  public override void setContenu(string contenu)
  {
    this.contenu = contenu;
  }
  
  public override void dessine()
  {
    Console.WriteLine("Dessine le document HTML : " + contenu);
  }
  
  public override void imprime()
  {
    Console.WriteLine("Imprime le document HTML : " + contenu);
  }
}