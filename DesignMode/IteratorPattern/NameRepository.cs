namespace DesignMode.IteratorPattern
{
    public class NameRepository:IContainer
    {
        public static string[] names = { "Robert", "John", "Julie", "Lora" };
        public IIterator getIterator()
        {
            return new NameIterator();
        }

        private class NameIterator : IIterator
        {

            int index;

            public bool hasNext()
            {
                if (index < names.Length)
                {
                    return true;
                }
                return false;
            }

            public object next()
            {
                if (this.hasNext())
                {
                    return names[index++];
                }
                return null;
            }
        }
    }
}