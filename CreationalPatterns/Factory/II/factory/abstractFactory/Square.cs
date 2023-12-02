using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factory.abstractFactory
{
    public class Square : ISquare
    {
        public void Draw()
        {
            Console.WriteLine("I 'am Square ;)");
        }
    }
}