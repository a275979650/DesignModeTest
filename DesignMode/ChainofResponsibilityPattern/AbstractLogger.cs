namespace DesignMode.ChainofResponsibilityPattern
{
    public abstract class AbstractLogger
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;

        protected int level;

        //责任链中的下一个元素
        protected AbstractLogger nextLogger;

        public void setNextLogger(AbstractLogger nextLogger)
        {
            this.nextLogger = nextLogger;
        }

        public string logMessage(int level, string message)
        {
            string str = "";
            if (this.level <= level)
            {
                str += write(message);
            }
            if (nextLogger != null)
            {
                str+=nextLogger.logMessage(level, message);
            }
            return str;
        }

        abstract protected string write(string message);
    }
}