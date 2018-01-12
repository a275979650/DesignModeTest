namespace DesignMode.VisitorPattern
{
    public interface IComputerPart
    {
        string accept(IComputerPartVisitor computerPartVisitor);
    }
}