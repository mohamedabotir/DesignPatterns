using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class MessageService
    {
        public abstract string SendMessage(string name, int custId, string message);
    }
}