namespace DesignMode.VisitorPattern
{
    public interface IComputerPartVisitor
    {
         string visit(Computer computer);
         string visit(Mouse mouse);
         string visit(Keyboard keyboard);
         string visit(Monitor monitor);
    }
}