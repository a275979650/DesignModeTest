using System;

namespace DesignMode.ObserverPattern
{
    public class BinaryObserver:Observer
    {
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }
        public override string update()
        {
            return"Binary String: "
                               + Convert.ToString(subject.getState(), 2);
        }
    }
}