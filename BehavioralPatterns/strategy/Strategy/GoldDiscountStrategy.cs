using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy.Strategy
{
    public class GoldDiscountStrategy : DiscountStrategy
    {
        public double CheckoutAfterDiscount(Cart cart)
        {

            return cart.TotalPrice - (cart.TotalPrice * 0.15);
        }
    }
}