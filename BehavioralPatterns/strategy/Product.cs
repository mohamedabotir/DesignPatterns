using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy
{
    public class Product
    {
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public string ProductName { get; set; }
        public required int qty { get; set; }
    }
}