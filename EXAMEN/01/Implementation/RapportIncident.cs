public class RapportIncident : IRapport
{
    private string contenu;
    private string auteur;

    public RapportIncident(string contenu, string auteur)
    {
        this.contenu = contenu;
        this.auteur = auteur;
    }

    public string GetContenu()
    {
        return contenu;
    }

    public string GetAuteur()
    {
        return auteur;
    }
}