namespace DesignMode.VisitorPattern
{
    public class Computer:IComputerPart
    {
        IComputerPart[] parts;

        public Computer()
        {
            parts = new IComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }

        public string accept(IComputerPartVisitor computerPartVisitor)
        {
            string str = "";
            for (int i = 0; i < parts.Length; i++)
            {
                str+=parts[i].accept(computerPartVisitor)+"\r\n";
            }
            str += computerPartVisitor.visit(this)+"\r\n";
            return str;
        }
    }
}