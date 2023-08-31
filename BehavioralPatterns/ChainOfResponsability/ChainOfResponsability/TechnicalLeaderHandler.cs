using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    internal class TechnicalLeaderHandler : IApprovalHandler
    {
        public void CallNext(IApprovalHandler next, Vacation vacation)
        {
            next.ProcessHandler(vacation);
        }

        public void ProcessHandler(Vacation vacation)
        {
            if (vacation.To.Day - vacation.From.Day > 3)
                Console.WriteLine($"Technical Lead has Accepted Length Of Vacation {vacation.To.Day - vacation.From.Day}");
            else
                CallNext(null, vacation);
        }
    }
}
