using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace facade
{
    public class purchaseFacade
    {
        public void PurchaseOrder(basket basket)
        {

            inventory inventory = new();
            var payment = new Payment();
            var paymentState = false;
            var invoice = new invoice();
            var smsProvicer = new Sms();
            Order order = new();
            foreach (var item in basket.order)
            {
                if (inventory.checkAvailability(item))
                    order.addToOrder(item);
            }
            paymentState = payment.checkout(order);

            if (paymentState)
            {

                invoice.GenerateInvoice(basket);
                smsProvicer.sendInvoice(invoice);
            }
            else
            {
                Console.WriteLine("Process Faild!");
            }

        }
    }
}