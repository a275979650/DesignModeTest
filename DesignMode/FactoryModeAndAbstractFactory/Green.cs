using System;

namespace DesignMode
{
    public class Green : IColor
    {
        public string Fill()
        {
            return "Inside Green::fill() method.\r\n";
        }
    }
}