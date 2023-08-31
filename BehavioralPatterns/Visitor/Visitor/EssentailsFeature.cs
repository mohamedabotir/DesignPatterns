using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class SkyscraperFeature
    {
        public void PrintMyMaterial() {
            Console.WriteLine("print me");
        }

        public string CallPrint(IVisitor visitor) => visitor.PrintSkyscraperReport("my formula");
    }
}
