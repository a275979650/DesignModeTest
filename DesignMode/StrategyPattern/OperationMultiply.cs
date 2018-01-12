namespace DesignMode.StrategyPattern
{
    public class OperationMultiply:IStrategy
    {
        public int doOperation(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}