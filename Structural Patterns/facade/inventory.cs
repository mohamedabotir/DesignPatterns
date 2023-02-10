using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace facade
{
    public class inventory
    {
        public static List<Item> items = new();
        public void addItem(Item item) => items.Add(item);

        public bool checkAvailability(Item item) => items.Select(e => e.qty > 0 && e.name == item.name).Count() > 0;
    
    
    }
}