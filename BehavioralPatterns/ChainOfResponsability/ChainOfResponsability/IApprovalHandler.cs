using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    internal interface IApprovalHandler
    {

         void CallNext(IApprovalHandler next, Vacation vacation);
         void ProcessHandler(Vacation vacation);

    }
}
