namespace DesignMode.BuilderPattern
{
    public abstract class ColdDrink:MyItem
    {
        public override IPacking packing()
        {
            return new Bottle();
        }
    }
}