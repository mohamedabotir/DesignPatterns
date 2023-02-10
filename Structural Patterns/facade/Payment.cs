using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace facade
{
    public class Payment
    {
        private decimal money { get; set; } = 5000;

        public bool checkout(Order order)
        {
            var totalPrice = order.getOrderPrice();
            if (totalPrice < money)
                money -= totalPrice;


            return totalPrice < money ? true : false;
        }
    }
}