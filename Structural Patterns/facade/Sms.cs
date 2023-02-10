using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace facade
{
    public class Sms
    {
        public void sendInvoice(invoice invoice)
        {
            Console.WriteLine(invoice.getInvoice());
        }
    }
}