public abstract class RapportDecorator : IRapport
{
    protected IRapport rapport;

    public RapportDecorator(IRapport rapport)
    {
        this.rapport = rapport;
    }

    public abstract string GetContenu();
    public abstract string GetAuteur();
}