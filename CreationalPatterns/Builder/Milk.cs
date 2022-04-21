using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder
{
    public class Milk : IBuilder
    {
        private Product product = new Product();
        public void AddCarbohydrates()
        {
            product.addComponent("20% Carbohydrates");
        }

        public void AddFat()
        {
            product.addComponent("5% Fats");
        }

        public void Protein()
        {
            product.addComponent("8% Protein");
        }

        public void ShowComponents()
        {
            Console.WriteLine(product.showComponents(),ConsoleColor.Cyan);
        }
    }
}