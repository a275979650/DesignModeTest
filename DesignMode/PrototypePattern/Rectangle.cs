namespace DesignMode.PrototypePattern
{
    public class Rectangle:Shape
    {
        public Rectangle()
        {
            Type = "Rectangle";
        }
        public override string draw()
        {
            return "Inside Rectangle::draw() method.";
        }
    }
}