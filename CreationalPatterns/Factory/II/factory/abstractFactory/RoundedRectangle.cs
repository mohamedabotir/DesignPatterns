using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factory.abstractFactory
{
    public class RoundedRectangle : IRectangle
    {
        public void Draw()
        {
            Console.WriteLine("I'm Rounded Rectangle ;)");
        }
    }
}