using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy
{
    public class Inventory
    {
        public static List<Product> _inventory = new();
        public void AddProduct(Product product)
        {
            _inventory.Add(product);
        }

        public void AddBulkProducts(List<Product> products)
        {
            _inventory.AddRange(products);
        }

        public IEnumerable<Product> GetProducts()
        {
            foreach (var item in _inventory)
            {
                yield return item;
            }
        }
        public CheckProductAvailability GetProduct(Order order)
        {
            var products = 0;
            foreach (var item in GetProducts())
            {
                if (item.ProductId == order.Product.ProductId)
                {

                    if (order.qty < item.qty)
                        return CheckProductAvailability.Available;
                }

            }
            return CheckProductAvailability.NotAvailable;

        }
    }
    public enum CheckProductAvailability
    {
        Available, NotAvailable
    }
}