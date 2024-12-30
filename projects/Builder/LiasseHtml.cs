using System;

public class LiasseHtml : Liasse
{
    private List<string> _documents = new List<string>();
    public LiasseHtml() {}

    public void ajouteDocument(string document){
        if (document.StartsWith("<HTML>")) _documents.Add(document);
    }
    public void imprime(){
        Console.WriteLine("Liasse HTML");
        foreach (string s in _documents) Console.WriteLine(s);
    }
}