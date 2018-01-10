using System;

namespace DesignMode
{
    public class Blue : IColor
    {
        public string Fill()
        {
            return "Inside Blue::fill() method.\r\n";
        }
    }
}