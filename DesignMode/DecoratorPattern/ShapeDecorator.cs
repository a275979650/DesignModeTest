namespace DesignMode.DecoratorPattern
{
    public class ShapeDecorator:IShape
    {
        protected IShape decoratedShape;

        public ShapeDecorator(IShape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }

        public string draw()
        {
            return decoratedShape.draw();
        }
    }
}