using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class PrintVisitor : IVisitor
    {
        public string PrintAppartmentReport(string formula)
        {
            return formula;
        }

        public string PrintHouseReport(string formula)
        {
            return formula;
        }

        public string PrintSkyscraperReport(string formula)
        {
            return formula;
        }
    }
}
