namespace DesignMode.InterpreterPattern
{
    public class AndExpression:IExpression
    {
        private IExpression expr1 = null;
        private IExpression expr2 = null;

        public AndExpression(IExpression expr1, IExpression expr2)
        {
            this.expr1 = expr1;
            this.expr2 = expr2;
        }
        public bool interpret(string context)
        {
            return expr1.interpret(context) && expr2.interpret(context);
        }
    }
}