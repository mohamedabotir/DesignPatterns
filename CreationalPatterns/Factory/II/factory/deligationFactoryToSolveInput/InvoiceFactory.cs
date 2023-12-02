using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factory.deligationFactoryToSolveInput
{
    public partial class Invoice
    {

        public class InvoiceFactory
        {
            private Invoice _invoice;
            private readonly EmailService _emailService;
            public delegate InvoiceFactory InvokeInvoice(int tax);

            public InvoiceFactory(EmailService emailService, int tax)
            {
                _invoice = new Invoice(tax);
                _emailService = emailService;
            }

            public void calculateTotal()
            {

                Console.WriteLine($"Total Values: {_invoice.calculateValue()}");
                _emailService.sendEmail();
            }


        }
    }
}