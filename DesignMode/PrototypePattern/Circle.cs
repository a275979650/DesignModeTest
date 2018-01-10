namespace DesignMode.PrototypePattern
{
    public class Circle:Shape
    {
        public Circle()
        {
            Type = "Circle";
        }
        public override string draw()
        {
            return "Inside Circle::draw() method.";
        }
    }
}