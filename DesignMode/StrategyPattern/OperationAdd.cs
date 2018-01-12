namespace DesignMode.StrategyPattern
{
    public class OperationAdd:IStrategy
    {
        public int doOperation(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}