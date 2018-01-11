namespace DesignMode.InterpreterPattern
{
    public interface IExpression
    {
        bool interpret(string context);
    }
}