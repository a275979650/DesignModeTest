namespace DesignMode.PrototypePattern
{
    public class Square:Shape
    {
        public Square()
        {
            Type = "Square";
        }
        public override string draw()
        {
            return "Inside Square::draw() method.";
        }
    }
}