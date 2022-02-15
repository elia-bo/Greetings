using Greeting.Chain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    public class NullHandler : GreetingHandler
    {
        protected override string Greet(params string[] name) => "Hello, my friend.";

        public override string Handle(params string[] names)
        {
            if (names == null)
                return Greet(names);
            else return Next.Handle(names);
        }
    }
}
