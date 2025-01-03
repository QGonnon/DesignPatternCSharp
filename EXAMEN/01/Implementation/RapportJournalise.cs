public class RapportJournalise : RapportDecorator
{
    public RapportJournalise(IRapport rapport) : base(rapport) { }

    public override string GetContenu()
    {
        string contenu = rapport.GetContenu();
        JournaliserAcces();
        return contenu;
    }

    public override string GetAuteur()
    {
        return rapport.GetAuteur();
    }

    private void JournaliserAcces()
    {
        Console.WriteLine($"[LOG] Accès au rapport à {DateTime.Now}");
    }
}