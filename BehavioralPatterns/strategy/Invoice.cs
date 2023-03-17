using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace strategy
{
    public class Invoice
    {
        private StringBuilder _invoice = new();
        public string GenerateInvoice(Cart cart)
        {
            _invoice.AppendLine("***********Invoice***********");
            foreach (var item in cart.GetCart())
            {
                _invoice.Append($"Product:{item.Product.ProductName},Qty:{item.qty},SubTotal:{item.Price}\n");
                _invoice.AppendLine("**********************");
            }
            _invoice.Append($"Total:{cart.TotalPrice}");
            return _invoice.ToString();
        }
    }
}