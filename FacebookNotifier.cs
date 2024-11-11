using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    public class FacebookNotifier : DecoratorNotifier
    {
        public FacebookNotifier(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Facebook сообщение отправлено: {message}");
        }
    }
}
