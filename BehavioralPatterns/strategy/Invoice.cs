using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using strategy.Strategy;
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

            if (cart.TotalPrice > 10000)
            {

                _invoice.Append($"Total:{new DiamondDiscountStrategy().CheckoutAfterDiscount(cart)}");
            }
            else if (cart.TotalPrice > 5000)
            {
                _invoice.Append($"Total:{new GoldDiscountStrategy().CheckoutAfterDiscount(cart)}");
            }
            else
                _invoice.Append($"Total:{cart.TotalPrice}");

            return _invoice.ToString();
        }
    }
}