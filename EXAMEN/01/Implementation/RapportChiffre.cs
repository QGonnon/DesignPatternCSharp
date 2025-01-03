public class RapportChiffre : RapportDecorator
{
    public RapportChiffre(IRapport rapport) : base(rapport) { }

    public override string GetContenu()
    {
        string contenu = rapport.GetContenu();
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(contenu));
    }

    public override string GetAuteur()
    {
        return rapport.GetAuteur();
    }
}