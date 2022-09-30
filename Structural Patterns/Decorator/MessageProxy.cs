using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
proxy types 
remote proxy
virtual proxy
protected proxy
*/
namespace Decorator
{
    public class MessageProxy
    {
        private MessageService _smsService;
        protected static Dictionary<int, int> userHolder = new System.Collections.Generic.Dictionary<int, int>();
        public string SendMessage(string name, int custId, string message)
        {
            if (_smsService == null)
                _smsService = new MessageServiceConcrete();

            if (!userHolder.ContainsKey(custId))
            {
                userHolder.Add(custId, 1);
                return _smsService.SendMessage(name, custId, message);
            }
            else
            {
                Console.WriteLine(userHolder[custId]);
                if (userHolder[custId] >= 3)
                {

                    return "Message Limit Exceeded";
                }
                else
                {
                    userHolder[custId]++;
                    return _smsService.SendMessage(name, custId, message);
                }
            }
        }
    }
}