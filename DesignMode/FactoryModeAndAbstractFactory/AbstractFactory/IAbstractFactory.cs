namespace DesignMode
{
    public interface IAbstractFactory
    {
        IColor getColor(string color);
        IShape getShape(string shape);
    }
}