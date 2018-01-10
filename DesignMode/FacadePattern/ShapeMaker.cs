namespace DesignMode.FacadePattern
{
    public class ShapeMaker
    {
        private IShape circle;
        private IShape rectangle;
        private IShape square;

        public ShapeMaker()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public string drawCircle()
        {
            return circle.draw();
        }
        public string drawRectangle()
        {
            return rectangle.draw();
        }
        public string drawSquare()
        {
            return square.draw();
        }
    }
}