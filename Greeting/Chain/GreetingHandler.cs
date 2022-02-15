using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting.Chain
{
    public abstract class GreetingHandler : IGreetingHandler
    {
        protected IGreetingHandler Next;
        public abstract string Handle(params string[] names);
        protected abstract string Greet(params string[] names);
        public virtual IGreetingHandler SetNext(IGreetingHandler greetingHandler)
        {
            Next = greetingHandler;
            return Next;
        }

        protected bool ContainsUppercase(params string[] names) => names.Any(x => isUppercase(x));

        protected bool isUppercase(string name)
        {
            foreach (var item in name)
            {
                if (char.IsLower(item))
                    return false;
            }
            return true;
        }
    }
}
