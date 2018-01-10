namespace DesignMode.ChainofResponsibilityPattern
{
    public class FileLogger:AbstractLogger
    {
        public FileLogger(int level)
        {
            this.level = level;
        }
        protected override string write(string message)
        {
            return "File::Logger: " + message + "\r\n";
        }
    }
}