using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factory.deligationFactoryToSolveInput
{

    public partial class Invoice
    {
        private List<double> prices = new(){
            50,12,400,23
        };
        private int tax;
        private Invoice(int taxValue)
        {
            tax = taxValue;
        }

        public double calculateValue() =>
              prices.Sum() + prices.Sum() * (tax / 100);


    }
}