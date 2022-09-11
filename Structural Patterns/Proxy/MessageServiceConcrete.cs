using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proxy
{
    public class MessageServiceConcrete : MessageService
    {
        public override string SendMessage(string name, int custId, string message)
        {
            return $"{name} is Sent message :{message}";
        }
    }
}