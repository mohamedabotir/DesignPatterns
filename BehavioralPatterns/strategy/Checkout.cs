using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy
{
    public class Checkout
    {

        public string ProcessCheckout(Cart cart)
        {

              
            return new Invoice().GenerateInvoice(cart);
        }
    }
}