using System;

public class LiassePdf : Liasse
{
    private List<string> _documents = new List<string>();
    public LiassePdf() {}

    public void ajouteDocument(string document){
        if (document.StartsWith("<PDF>")) _documents.Add(document);
    }
    public void imprime(){
        Console.WriteLine("Liasse PDF");
        foreach (string s in _documents) Console.WriteLine(s);
    }
}