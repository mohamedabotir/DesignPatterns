using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IVisitor
    {
        string PrintAppartmentReport(string formula);
        string PrintHouseReport(string formula);
        string PrintSkyscraperReport(string formula);
    }
}
