using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    internal class Vacation
    {
        public int staffId { get; set; }
        public string staffName { get; set; } 
        public DateOnly From { get; set; }
        public DateOnly To { get; set; }
    }
}
