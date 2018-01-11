namespace DesignMode.InterpreterPattern
{
    public class TerminalExpression:IExpression
    {
        private string data;

        public TerminalExpression(string data)
        {
            this.data = data;
        }
        public bool interpret(string context)
        {
            if (context.Contains(data))
            {
                return true;
            }
            return false;
        }
    }
}