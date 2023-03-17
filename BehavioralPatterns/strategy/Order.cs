using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy
{
    public class Order
    {
        public Product Product { get; set; }
        public int qty { get; set; }
        public double Price
        {
            get
            {
                return Product.Price * qty;
            }
        }
    }
}