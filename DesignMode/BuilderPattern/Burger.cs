namespace DesignMode.BuilderPattern
{
    public abstract class Burger:MyItem
    {
        public override IPacking packing()
        {
            return new Wrapper();
        }
    }
}