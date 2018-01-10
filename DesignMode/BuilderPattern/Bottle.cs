using System;

namespace DesignMode.BuilderPattern
{
    public class Bottle : IPacking
    {
        public string pack()
        {
            return "Bottle";
        }
    }
}