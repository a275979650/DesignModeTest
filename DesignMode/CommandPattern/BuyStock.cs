namespace DesignMode.CommandPattern
{
    public class BuyStock:IOrder
    {
        private Stock abcStock;

        public BuyStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }
        public string execute()
        {
            return abcStock.buy();
        }
    }
}