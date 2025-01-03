public class RapportAnonyme : RapportDecorator
{
    public RapportAnonyme(IRapport rapport) : base(rapport) { }

    public override string GetContenu()
    {
        return rapport.GetContenu().Replace("identifiant", "***").Replace("password", "***");
    }

    public override string GetAuteur()
    {
        return "ANONYME";
    }
}