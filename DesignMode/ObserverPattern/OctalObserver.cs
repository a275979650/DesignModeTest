using System;

namespace DesignMode.ObserverPattern
{
    public class OctalObserver:Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }

        public override string update()
        {
            return "Octal String: "
                               + Convert.ToString(subject.getState(),8);
        }
    }
}