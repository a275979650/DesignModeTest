namespace DesignMode.VisitorPattern
{
    public class Monitor:IComputerPart
    {
        public string accept(IComputerPartVisitor computerPartVisitor)
        {
            return computerPartVisitor.visit(this);
        }
    }
}