namespace DesignMode.CommandPattern
{
    public class Stock
    {
        private string name = "ABC";
        private int quantity = 10;

        public string buy()
        {
            return "Stock [ Name: " + name + ", Quantity: " + quantity +" ] bought\r\n";
        }
        public string sell()
        {
            return "Stock [ Name: " + name + ", Quantity: " + quantity +" ] sold\r\n";
        }
    }
}