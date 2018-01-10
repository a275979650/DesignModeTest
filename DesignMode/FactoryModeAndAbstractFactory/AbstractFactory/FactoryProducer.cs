namespace DesignMode
{
    public class FactoryProducer
    {
        public static IAbstractFactory getFactory(string choice)
        {
            if (choice.Equals("SHAPE"))
            {
                return new ShapeFactory2();
            }
            else if (choice.Equals("COLOR"))
            {
                return new ColorFactory();
            }
            return null;
        }
    }
}