using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace facade
{
    public class Order
    {
        List<Item> order = new();
        public void addToOrder(Item item)
        {
            order.Add(item);
            inventory.items.FirstOrDefault(e => e.name == item.name).qty -= 1;
        }
        public decimal getOrderPrice()
        {
            var totalPrice = 0m;
            foreach (var item in order)
            {
                totalPrice += item.price;
            }
            return totalPrice;
        }
    }
}