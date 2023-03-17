using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy.Strategy
{
    public interface DiscountStrategy
    {
        public double CheckoutAfterDiscount(Cart cart);
    }

}