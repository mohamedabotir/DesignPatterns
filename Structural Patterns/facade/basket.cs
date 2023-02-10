using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace facade
{
    public class basket
    {
        public List<Item> order = new();

        public void addToBasket(Item item) => order.Add(item);

     
    }
}