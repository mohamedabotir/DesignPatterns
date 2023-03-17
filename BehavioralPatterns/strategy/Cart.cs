using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy
{
    public class Cart
    {
        private List<Order> _orders = new();
        private double _total;
        public double TotalPrice
        {
            get
            {
                _total = 0;
                foreach (var item in _orders)
                {
                    _total += item.Price;
                }
                return _total;
            }
        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }
        public IEnumerable<Order> GetCart()
        {
            foreach (var item in _orders)
            {
                yield return item;
            }
        }

    }
}