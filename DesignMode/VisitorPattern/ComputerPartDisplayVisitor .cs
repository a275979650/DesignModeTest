namespace DesignMode.VisitorPattern
{
    public class ComputerPartDisplayVisitor:IComputerPartVisitor
    {
        public string visit(Computer computer)
        {
            return "Displaying Computer.";
        }

        public string visit(Mouse mouse)
        {
            return "Displaying Mouse.";
        }

        public string visit(Keyboard keyboard)
        {
            return "Displaying Keyboard.";
        }

        public string visit(Monitor monitor)
        {
            return "Displaying Monitor.";
        }
    }
}