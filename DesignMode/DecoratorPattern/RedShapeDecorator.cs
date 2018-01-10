namespace DesignMode.DecoratorPattern
{
    public class RedShapeDecorator:ShapeDecorator
    {
        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape)
        {
        }
        public string draw()
        {
            string str = "";
            str += decoratedShape.draw() + "\r\n";
            str += setRedBorder(decoratedShape) + "\r\n";
            return str;
        }

        private string setRedBorder(IShape decoratedShape)
        {
            return "Border Color: Red";
        }
    }
}