namespace DesignMode.VisitorPattern
{
    public class Mouse:IComputerPart
    {
        public string accept(IComputerPartVisitor computerPartVisitor)
        {
            return computerPartVisitor.visit(this);
        }
    }
}