using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    public class Notifier : INotifier
    {
        public void Send(string message)
        {
                Console.WriteLine($"Email отправлено: {message}");
        }
    }
}
