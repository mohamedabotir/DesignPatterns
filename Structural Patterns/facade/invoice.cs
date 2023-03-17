using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    public class invoice
    {
        private string Invoice { get; set; }
        public void GenerateInvoice(basket basket)
        {
            var builder = new StringBuilder();
            var totalPrice = 0m;
            builder.AppendLine("*****Invoice*****");
            foreach (var item in basket.order)
            {
                builder.AppendLine(item.name + " " + item.price + "$");
                totalPrice += item.price;
            }
            builder.AppendLine($"TotalPrice:{totalPrice}$");
            Invoice = builder.ToString();
        }
        public string getInvoice() => Invoice;

    }
    struct str
    {
        public str(int a)
        {

        }
        public str()
        {

        }

    }
}