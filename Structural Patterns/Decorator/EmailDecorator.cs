using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class EmailDecorator : MessageService
    {
        protected MessageService service;
        public void setService(MessageService service)
        {
            this.service = service;
        }
        public override string SendMessage(string name, int custId, string message)
        {
            if (service != null)
            {
                return service.SendMessage(name, custId, message);
            }
            else
            {
                return "Service is not initialized";
            }
        }
    }
}