using System;

public  class Document
{
  protected string contenu;
  
  public Document(){}
  
  public abstract void setContenu(string contenu);
  public abstract void dessine();
  public abstract void imprime();
}