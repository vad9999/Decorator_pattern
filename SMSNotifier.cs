using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    public class SMSNotifier : DecoratorNotifier
    {
        public SMSNotifier(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"SMS отправлено: {message}");
        }
    }
}
