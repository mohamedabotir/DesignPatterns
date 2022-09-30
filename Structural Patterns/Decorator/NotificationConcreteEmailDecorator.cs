using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class NotificationConcreteEmailDecorator : EmailDecorator
    {

        public string notification(int custId, string message)
        {
            return $"Message {message} , sent to {custId} At {DateTime.Now}";
        }

        public override string SendMessage(string name, int custId, string message)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(base.SendMessage(name, custId, message));
            builder.AppendLine(notification(custId, message));
            return builder.ToString();
        }

    }
}