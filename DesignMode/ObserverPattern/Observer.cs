namespace DesignMode.ObserverPattern
{
    public abstract class Observer
    {
        protected Subject subject;
        public abstract string update();
    }
}