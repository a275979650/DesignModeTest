namespace DesignMode.ChainofResponsibilityPattern
{
    public class ErrorLogger:AbstractLogger
    {
        public ErrorLogger(int level)
        {
            this.level = level;
        }
        protected override string write(string message)
        {
            return "Error Console::Logger: " + message + "\r\n";
        }
    }
}