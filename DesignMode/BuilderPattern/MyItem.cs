namespace DesignMode.BuilderPattern
{
    public abstract class MyItem
    {
        public abstract string name();
        public abstract IPacking packing();
        public abstract float price();
    }
}