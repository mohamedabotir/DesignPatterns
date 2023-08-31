using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    internal class TeamLeaderHandler : IApprovalHandler
    {
        IApprovalHandler _handler;

        public void initialize(Vacation vacation) {
            ProcessHandler(vacation);
        }
        public void CallNext(IApprovalHandler next, Vacation vacation)
        {
            next.ProcessHandler(vacation);
        }

        public void ProcessHandler(Vacation vacation)
        {
            if (vacation.To.Day - vacation.From.Day == 3)
                Console.WriteLine($"Team Leader Accepted Vacation {vacation.To.Day - vacation.From.Day}");
            else
            CallNext(new TechnicalLeaderHandler(),vacation);
        }
    }
}
