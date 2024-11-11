using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    public abstract class DecoratorNotifier : INotifier
    {
        protected INotifier _notifier;

        public DecoratorNotifier(INotifier notifier)
        {
            _notifier = notifier;
        }

        public virtual void Send(string message)
        {
            _notifier.Send(message);
        }
    }
}
