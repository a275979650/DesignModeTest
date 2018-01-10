namespace DesignMode.CommandPattern
{
    public class SellStock:IOrder
    {
        private Stock abcStock;

        public SellStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }
        public string execute()
        {
            return abcStock.sell();
        }
    }
}