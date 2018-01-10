using System;

namespace DesignMode
{
    public class ColorFactory:IAbstractFactory
    {
        public IColor getColor(string color)
        {
            if (color == null)
            {
                return null;
            }
            if (color.Equals("RED"))
            {
                return new Red();
            }
            else if (color.Equals("GREEN"))
            {
                return new Green();
            }
            else if (color.Equals("BLUE"))
            {
                return new Blue();
            }
            return null;
        }

        public IShape getShape(string shape)
        {
            return null;
        }
    }
}