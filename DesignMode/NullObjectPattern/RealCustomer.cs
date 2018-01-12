namespace DesignMode.NullObjectPattern
{
    public class RealCustomer:AbstractCustomer
    {
        public RealCustomer(string name)
        {
            this.name = name;
        }
        public override bool isNil()
        {
            return false;
        }

        public override string getName()
        {
            return name;
        }
    }
}