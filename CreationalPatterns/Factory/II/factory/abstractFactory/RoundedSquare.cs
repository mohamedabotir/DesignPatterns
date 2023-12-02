using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factory.abstractFactory
{
    public class RoundedSquare : ISquare
    {
        public void Draw()
        {
            Console.WriteLine("I'am Rounded Square ;)");
        }
    }
}