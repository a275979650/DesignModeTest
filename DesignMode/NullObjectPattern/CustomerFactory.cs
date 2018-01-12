namespace DesignMode.NullObjectPattern
{
    public class CustomerFactory
    {
        public static readonly string[] names = {"Rob", "Joe", "Julie"};

        public static AbstractCustomer getCustomer(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Equals(name,System.StringComparison.CurrentCultureIgnoreCase))
                {
                    return new RealCustomer(name);
                }
            }
            return new NullCustomer();
        }
    }
}