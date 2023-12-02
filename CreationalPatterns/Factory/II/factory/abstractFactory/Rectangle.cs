using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factory.abstractFactory
{
    public class Rectangle : IRectangle
    {
        public void Draw()
        {
            Console.WriteLine("i ' m Rectangle ;)");
        }
    }
}