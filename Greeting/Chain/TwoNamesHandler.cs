using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting.Chain
{
    public class TwoNamesHandler : GreetingHandler
    {
        protected override string Greet(params string[] names) => $"Hello, {names[0]} and {names[1]}.";

        public override string Handle(params string[] names)
        {
            if (names.Length == 2)
                return Greet(names);
            else return Next.Handle(names);
        }
    }
}
