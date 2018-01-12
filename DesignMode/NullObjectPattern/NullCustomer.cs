namespace DesignMode.NullObjectPattern
{
    public class NullCustomer:AbstractCustomer
    {
        public override bool isNil()
        {
            return true;
        }

        public override string getName()
        {
            return "Not Available in Customer Database";
        }
    }
}