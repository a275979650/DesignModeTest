using System.Collections.Generic;

namespace DesignMode.BuilderPattern
{
    public class Meal
    {
        private List<MyItem> items = new List<MyItem>();

        public void addItem(MyItem item)
        {
            items.Add(item);
        }

        public float getCost()
        {
            float cost = 0.0f;
            foreach (MyItem item in  items)
            {
                cost += item.price();
            }
            return cost;
        }

        public string showItems()
        {
            string str = "";
            foreach (MyItem item in items)
            {
                str +="Item : " + item.name();
                str += ", Packing : " + item.packing().pack();
                str += ", Price : " + item.price() + "\r\n";
            }
            return str;
        }
    }
}