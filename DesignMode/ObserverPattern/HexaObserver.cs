using System;

namespace DesignMode.ObserverPattern
{
    public class HexaObserver:Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }
        public override string update()
        {
            return "Hex String: "
                               + Convert.ToString(subject.getState(),16);
        }
    }
}