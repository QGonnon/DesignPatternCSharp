using System;

public class DocumentHtml : Document
{
  protected string contenu;
  protected ComposantPdf outilPdf = new ComposantPdf();
  
  public DocumentHtml(string contenu)
  {
    this.contenu = contenu;
  }
  
  public override void setContenu(string contenu)
  {
    outilPdf.pdfFixeContenu(contenu);
  }
  
  public override void dessine()
  {
    outilPdf.pdfPrepareAffichage();
    outilPdf.pdfRafraichit();
    outilPdf.pdfTermineAffichage();
  }
  
  public override void imprime()
  {
    outilPdf.pdfEnvoieImprimante();
  }
}