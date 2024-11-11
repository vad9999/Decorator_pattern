using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotifier notifier = new Notifier();

            notifier = new SMSNotifier(notifier);

            notifier = new FacebookNotifier(notifier);

            notifier.Send("Очень важное уведомление.");

            Console.Read();
        }
    }
}
