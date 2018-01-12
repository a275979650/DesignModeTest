namespace DesignMode.VisitorPattern
{
    public class Keyboard:IComputerPart
    {
        public string accept(IComputerPartVisitor computerPartVisitor)
        {
            return computerPartVisitor.visit(this);
        }
    }
}