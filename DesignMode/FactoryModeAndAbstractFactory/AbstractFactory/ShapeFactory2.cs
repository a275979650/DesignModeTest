using System;

namespace DesignMode
{
    public class ShapeFactory2:IAbstractFactory
    {
        public IColor getColor(string color)
        {
            return null;
        }

        public IShape getShape(string shape)
        {
            if (shape == null)
            {
                return null;
            }
            if (shape.Equals("CIRCLE"))
            {
                return new Circle();
            }
            else if (shape.Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (shape.Equals("SQUARE"))
            {
                return new Square();
            }
            return null;
        }
    }
}