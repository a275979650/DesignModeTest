using System.Collections.Generic;

namespace DesignMode.CommandPattern
{
    public class Broker
    {

        private List<IOrder> orderList = new List<IOrder>();

        public void takeOrder(IOrder order)
        {
            orderList.Add(order);
        }

        public string placeOrders()
        {
            string str = "";
            foreach (IOrder order in orderList)
            {
                str += order.execute();
            }
            orderList.Clear();
            return str;
        }

    }
}