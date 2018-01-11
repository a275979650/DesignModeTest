namespace DesignMode.IteratorPattern
{
    public interface IIterator
    {
        bool hasNext();
        object next();
    }
}