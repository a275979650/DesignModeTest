using System.Collections.Generic;

namespace DesignMode.ObserverPattern
{
    public class Subject
    {
        private List<Observer> observers
            = new List<Observer>();
        private int state;

        public int getState()
        {
            return state;
        }

        public string setState(int state)
        {
            this.state = state;
            return notifyAllObservers();
        }

        public void attach(Observer observer)
        {
            observers.Add(observer);
        }

        public string notifyAllObservers()
        {
            string str = "";
            foreach (Observer observer in observers)
            {
                str+=observer.update()+"\r\n";
            }
            return str;
        }
    }
}