namespace DesignMode.ChainofResponsibilityPattern
{
    public class ConsoleLogger:AbstractLogger
    {
        public ConsoleLogger(int level)
        {
            this.level = level;
        }

        protected override string write(string message)
        {
            return "Standard Console::Logger: " + message+"\r\n";
        }
    }
}